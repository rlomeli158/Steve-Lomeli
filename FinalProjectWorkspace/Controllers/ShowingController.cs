using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalProjectWorkspace.Controllers
{

    public class ShowingController : Controller
    {
        private readonly AppDbContext _context;

        public ShowingController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Showing
        public IActionResult Index(DateTime StartingShowingDate, String theatre, DateTime ShowingDate, String status)
        {
            if (StartingShowingDate == new DateTime(01, 01, 0001) && theatre == null && ShowingDate == new DateTime(01, 01, 0001) && status == null)
            {
                return View();
            }

            //LINQ to query job postings
            var query = from jp in _context.Showings select jp;
            query = query.Include(s => s.Movie);

            if (status == "Unpublished")
            {
                query = query.Where(s => s.Status == status);
                List<Showing> SelectedUnpublishedShowings = query.ToList();

                foreach (Showing s in SelectedUnpublishedShowings)
                {
                    var seatsAvailable = GetSeatsAvailable(s.ShowingID);
                    s.SeatsAvailable = seatsAvailable;
                }

                return View(SelectedUnpublishedShowings.OrderBy(s => s.StartTime));
            }

            if (StartingShowingDate != new DateTime(01, 01, 0001))
            {
                if (StartingShowingDate.DayOfWeek != DayOfWeek.Friday)
                {
                    return View("Error", new string[]
                    { "The starting date you selected isn't on a Friday! Please select a Friday to view the entire schedule week." });
                }
                DateTime EndShowingDate = StartingShowingDate.AddDays(6);
                query = query.Where(s => s.ShowingDate >= StartingShowingDate && s.ShowingDate <= EndShowingDate);

            }

            if (ShowingDate != new DateTime(01, 01, 0001))
            {
                query = query.Where(s => s.ShowingDate == ShowingDate);
            }

            if (theatre != "Both" && theatre != null)
            {
                if (theatre == "theatre1")
                {
                    query = query.Where(s => s.Theatre == Theatre.Theatre1);
                }
                else if (theatre == "theatre2")
                {
                    query = query.Where(s => s.Theatre == Theatre.Theatre2);
                }
            }

            List<Showing> SelectedShowings = query.ToList();
            foreach (Showing s in SelectedShowings)
            {
                var seatsAvailable = GetSeatsAvailable(s.ShowingID);
                s.SeatsAvailable = seatsAvailable;
            }

            return View(SelectedShowings.OrderBy(s => s.StartTime));

            //return View(await _context.Showings.Include(s => s.Movie).ToListAsync());
        }

        // GET: Showing/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Showing showing = await _context.Showings
                .Include(p => p.Movie)
                .FirstOrDefaultAsync(m => m.ShowingID == id);

            var seatsAvailable = GetSeatsAvailable(showing.ShowingID);
            showing.SeatsAvailable = seatsAvailable;

            if (showing == null)
            {
                return NotFound();
            }

            return View(showing);
        }

        private SelectList GetAllMovies()
        {
            //Get the list of suppliers from the database
            List<Movie> movieList = _context.Movies.ToList();

            //add a dummy entry so the user can select all suppliers
            Movie SelectNone = new Movie() { MovieID = 0, Title = "Select A Movie" };
            movieList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //SupplierID and SupplierName are the names of the properties on the Supplier class
            //SupplierID is the primary key
            SelectList movieSelectList = new SelectList(movieList.OrderBy(s => s.MovieID), "MovieID", "Title");

            //return the MultiSelectList
            return movieSelectList;
        }

        public List<string> GetSeatsAvailable(int showingID)
        {
            List<string> allSeats = new List<string>()
             {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5"
             };

            List<string> seatsTaken = _context.Ticket
                .Include(t => t.Order)
                .Include(t => t.Showing)
                .Where(t => t.Showing.ShowingID == showingID)
                .Where(t => t.Order.OrderStatus != "Cancelled")
                .Select(t => t.SeatNumber).ToList();

            List<string> seatsAvailable = allSeats.Except(seatsTaken).ToList();

            //SelectList slSeatsAvailable = new SelectList(seatsAvailable, nameof(Showing.ShowingID), nameof(Showing.StartTime));

            return seatsAvailable;
        }

        // GET: Showing/Create
        [Authorize(Roles = "Manager")]
        public IActionResult Create()
        {
            ViewBag.AllTheatres = GetAllTheatres();
            ViewBag.AllMovies = GetAllMovies();
            return View();
        }

        public SelectList GetAllTheatres()
        {

            var TheatreSelectList = new SelectList(Enum.GetValues(typeof(Theatre)).Cast<Theatre>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(), "Value", "Text");

            return TheatreSelectList;
        }


        // POST: Showing/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShowingID,ShowingDate,StartTime,EndTime,Theatre,SeatsAvailable,SpecialEvent")] Showing showing, int SelectedMovie, int SelectedTheatre)
        {
            //This code has been modified so that if the model state is not valid
            //we immediately go to the "sad path" and give the user a chance to try again
            if (ModelState.IsValid == false)
            {
                //re-populate the view bag with the theaters and movies
                ViewBag.AllTheatres = GetAllTheatres();
                ViewBag.AllMovies = GetAllMovies();
                //go back to the Create view to try again
                return View(showing);
            }

            //Get the correct theater enum based on the selected theater on the create view
            if (SelectedTheatre == 0)
            {
                showing.Theatre = Theatre.Theatre1;
            }
            else if (SelectedTheatre == 1)
            {
                showing.Theatre = Theatre.Theatre2;
            }

            //if code gets to this point, we know the model is valid (except for the showing time) and
            //we can add the showing to the database once we check showing against business rules
            Movie dbMovie = _context.Movies.Find(SelectedMovie);
            showing.Movie = dbMovie;
            showing.Status = "Unpublished";
            showing.StartTime = new DateTime(showing.ShowingDate.Year, showing.ShowingDate.Month, showing.ShowingDate.Day,
                showing.StartTime.Hour, showing.StartTime.Minute, showing.StartTime.Millisecond);
            showing.EndTime = showing.StartTime.AddMinutes(showing.Movie.RunTime);

            DateTime compareOpeningTime = new DateTime(showing.StartTime.Year, showing.StartTime.Month, showing.StartTime.Day, 09, 00, 00);

            DateTime compareClosingTime = new DateTime(showing.StartTime.Year, showing.StartTime.Month, showing.StartTime.Day, 23, 59, 59);

            if (showing.StartTime < compareOpeningTime)
            {
                return View("Error", new string[]
                { "The showing you're wanting to create is too early. Please schedule it for after 9 AM." });
            }

            /* TODO: do we have to check for after 12 AM?
            if (showing.EndTime > compareOpeningTime)
            {
                return View("Error", new string[]
                { "The showing you're wanting to create is too late. Please schedule it for before 12 AM." });
            }
            */

            //Compare showing you want to add to the other showings on the same date for business rules
            List<Showing> showingsToCompare = _context.Showings
                                            .Include(s => s.Movie)
                                            .Where(s => s.ShowingDate == showing.ShowingDate)
                                            .Where(s => s.Theatre == showing.Theatre).ToList();

            //for each showing on the same day
            foreach(Showing s in showingsToCompare)
            {
                //if the showing you want to create starts before a showing on the same day,
                //you must check that its end time is at least 25 minutes before the other show starts
                if(showing.StartTime > s.StartTime)
                {
                    //if the other showing starts at least 25 minutes after the showing you're creating, then it's good
                    if (showing.StartTime > s.EndTime.AddMinutes(25) || s.Status == "Cancelled")
                    {
                        //good
                    }
                    //this means the other showing starts less than 25 minutes after the showing you want to put in
                    else
                    {
                        return View("Error", new string[]
                        { "The showing you're wanting to create has a start time less than 25 minutes after " + s.Movie.Title + " which ends at " + s.EndTime + ". To fix this, make the start time of " + showing.Movie.Title + " later. "});
                    }
                }
                //if the showing you want to add starts after another showing on the same day
                //you must check that its start time is at least 25 minutes after the other showing's end time
                else
                {
                    //if the showing you're creating's start time is 25 minutes after the end of another movie, it's good
                    if(s.StartTime > showing.EndTime.AddMinutes(25) || s.Status == "Cancelled")
                    {
                        //good
                    }
                    //this means the showing's start time is less than 25 minutes after the end of another movie
                    else
                    {
                        return View("Error", new string[]
                        { "The start time you input would make the end time of your showing be within 25 minutes of the start of " + s.Movie.Title + " at " + s.StartTime + ". To fix this, make the start time of " + showing.Movie.Title + " earlier or push back " + s.Movie.Title + "."});
                    }
                }
            }

            //Pull showings to compare that are from another theater
            //Because you cannot play the same movie at the same time at the other theater, they must be different times
            List<Showing> showingsToCompareForOtherTheatre = _context.Showings
                                            .Where(s => s.ShowingDate == showing.ShowingDate)
                                            .Where(s => s.Theatre != showing.Theatre).ToList();

            //For each showing in the opposite theater
            foreach(Showing s in showingsToCompareForOtherTheatre)
            {
                //If the same movie is being shown as the one we want to add
                if(s.Movie == showing.Movie)
                {
                    //And if their start times are the same
                    if (s.StartTime == showing.StartTime)
                    {
                        //This is not allowed, send this error
                        return View("Error", new string[] { showing.Movie.Title + " is being shown at the same time at the other theatre." });
                    }
                }
            }

            //everything checked out, add the showing to the database and save changes
            _context.Add(showing);
            await _context.SaveChangesAsync();

            //Send the user to the page with all the showings
            return RedirectToAction("Index", "Showing", new { theatre = showing.Theatre, ShowingDate = showing.ShowingDate});
        }


        public IActionResult CopySchedule()
        {
            CopyViewModel cvm = new CopyViewModel();
            return View(cvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CopySchedule(CopyViewModel cvm)
        {
            //This code has been modified so that if the model state is not valid
            //we immediately go to the "sad path" and give the user a chance to try again
            if (ModelState.IsValid == false)
            {
                return View(cvm);
            }

            //Get the showings you're copying from
            List<Showing> originalShowings = _context.Showings
                                            .Include(s => s.Movie)
                                            .Where(s => s.ShowingDate == cvm.SelectedCopyDate)
                                            .Where(s => s.Theatre == cvm.SelectedCopyTheatre).ToList();

            //Get the showings from the other theater on the day you're trying to copy to
            List<Showing> showingsToCompareForOtherTheatre = _context.Showings
                                .Where(s => s.ShowingDate == cvm.SelectedToDate)
                                .Where(s => s.Theatre != cvm.SelectedToTheatre).ToList();

            //For each showing you're copying from
            foreach (Showing s in originalShowings)
            {
                //Create a new showing, assign the exact same values to all the properties
                Showing showing = new Showing();
                Movie dbMovie = _context.Movies.Find(s.Movie.MovieID);
                showing.Movie = dbMovie;
                showing.ShowingDate = (DateTime)cvm.SelectedToDate;

                //Default to unpublished
                showing.Status = "Unpublished";
                showing.StartTime = new DateTime(showing.ShowingDate.Year, showing.ShowingDate.Month, showing.ShowingDate.Day,
                    s.StartTime.Hour, s.StartTime.Minute, s.StartTime.Millisecond);
                showing.EndTime = showing.StartTime.AddMinutes(showing.Movie.RunTime);
                showing.Theatre = cvm.SelectedToTheatre;
                showing.SeatsAvailable = s.SeatsAvailable;
                showing.SpecialEvent = s.SpecialEvent;

                //for every showing on the same day of the showing you're copying to
                foreach (Showing theaterShowing in showingsToCompareForOtherTheatre)
                {
                    //if the opposite theater is showing the same movie you're wanting to add
                    if (theaterShowing.Movie == showing.Movie)
                    {
                        //and it also starts at the same time
                        if (theaterShowing.StartTime == showing.StartTime)
                        {
                            //this is not allowed, throw an error for the whole thing
                            return View("Error", new string[]
                            { showing.Movie.Title + " is being shown at the same time at the other theatre. " });
                        }
                    }
                }

                //add the showing to the database and save changes
                _context.Add(showing);
                await _context.SaveChangesAsync();
            }

            //Return to index, showing only the copied showings
            return RedirectToAction("Index","Showing", new { theatre = cvm.SelectedToTheatre, ShowingDate = cvm.SelectedToDate} );
        }

        public IActionResult Publish()
        {
            PublishViewModel pvm = new PublishViewModel();
            return View(pvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Publish(PublishViewModel pvm)
        {
            //This code has been modified so that if the model state is not valid
            //we immediately go to the "sad path" and give the user a chance to try again
            if (ModelState.IsValid == false)
            {
                return View(pvm);
            }

            //Get all showings that are currently unpublished for the selected date and selected theater
            List<Showing> showings = _context.Showings
                .Include(s => s.Movie)
                .Where(s => s.Status == "Unpublished")
                .Where(s => s.ShowingDate == pvm.SelectedShowingDate)
                .Where(s => s.Theatre == pvm.SelectedTheatre)
                .ToList();

            //If there are no showings on this day, throw an error
            if (!showings.Any())
            {
                return View("Error", new string[]
                { "There are no movies on this date or in this theater! Please verify both and try again." });
            }

            //Use this to check if movie runs past 9:30 PM or 9:45 AM
            DateTime compareTime;
            DateTime compareTimeMorning;


            //Use this as a counter to ensure at least one movie ends past 9:30 PM
            Int32 movieEndPastNine = 0;

            //Use this as a counter to ensure at least one movie starts by 9:45 AM
            Int32 movieStartByNine = 0;

            //Sort the orders and put them in order of start time for that day
            showings = showings.OrderBy(s => s.StartTime).ToList();

            //Use this to check if the start time of the current movie
            //is no more than 45 minutes past the end time of previous movie
            //At first, set this to the first movie in the showings list
            DateTime goodEndTime = showings.Select(s => s.EndTime).First();

            foreach (Showing s in showings)
            {
                //Checks if a movie runs past 9:30 PM
                compareTime = new DateTime(s.EndTime.Year, s.EndTime.Month, s.EndTime.Day, 21, 30,00);

                //If it does, then add one to the counter. 
                if (s.EndTime > compareTime)
                {
                    movieEndPastNine += 1;
                }

                compareTimeMorning = new DateTime(s.EndTime.Year, s.EndTime.Month, s.EndTime.Day, 09, 45, 00);

                //TODO: If we have to add validation for a movie starting as close to 9 AM as possible, I think we would add another if statement here along
                //with a counter, similar to how we have a movie that ends past 9
                if (s.StartTime <= compareTimeMorning)
                {
                    movieStartByNine += 1;
                }

                //Checks if start time is no more than 45 minutes after previous movie's end time, enters the if statement if movies are too spaced out
                if (s.StartTime > goodEndTime.AddMinutes(45))
                {
                    return View("Error", new string[]
                    {  s.Movie.Title + " (ID: "+ s.ShowingID + ") " + "showing at " + s.StartTime + " is more than 45 minutes after the previous showing." });
                }

                //set the good end time to the end time of the current showing for the next loop
                goodEndTime = s.EndTime;
            }

            //if there wasn't a movie that ended past nine, you have to add one
            if (movieEndPastNine < 1)
            {
                return View("Error", new string[] { "There is no movie that runs past 9:30 PM. Please add one." });
            }
            else if (movieStartByNine < 1)
            {
                return View("Error", new string[] { "There is no movie that starts by 9:45 AM. Please add one." });
            }
            //otherwise, you are set to go, and you can set each showing to publish and update the DB
            else
            {
                foreach (Showing s in showings)
                {
                    s.Status = "Published";

                    //save the changes
                    _context.Showings.Update(s);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction(nameof(Index));
        }
        // GET: Showing/Edit/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var showing = await _context.Showings.FindAsync(id);
            if (showing == null)
            {
                return NotFound();
            }

            if(DateTime.Now >= showing.StartTime)
            {
                return View("Error", new string[] { "The movie has already started or has completed. You are unable to change this showing." });
            }

            ViewBag.AllMovies = GetAllMovies(showing.ShowingID);
            ViewBag.AllTheatres = GetAllTheatres();
            return View(showing);
        }

        private SelectList GetAllMovies(int showingID)
        {
            Showing showing = _context.Showings.Include(s => s.Movie).Where(s => s.ShowingID == showingID).First();

            Int32 selectedMovieID = showing.Movie.MovieID;

            //Create a new list of departments and get the list of the departments
            //from the database
            List<Movie> allMovies = _context.Movies.Include(m => m.Showings).ToList();

            //use the MultiSelectList constructor method to get a new MultiSelectList
            SelectList slAllMovies = new SelectList(allMovies.OrderBy(d => d.Title), "MovieID", "Title", selectedMovieID);

            //return the MultiSelectList
            return slAllMovies;

        }

        // POST: Showing/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]
        public IActionResult Edit(int id, [Bind("ShowingID,ShowingDate,StartTime,EndTime,Theatre,SeatsAvailable,SpecialEvent,Status")] Showing showing, int SelectedMovie, int SelectedTheatre)

        {
            Showing dbShowing = _context.Showings.FirstOrDefault();
            //this is a security check to see if the user is trying to modify
            //a different record.  Show an error message
            if (id != showing.ShowingID)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            if (ModelState.IsValid == false) //there is something wrong
            {
                ViewBag.AllMovies = GetAllMovies(); //TODO: Add int to bring back dropdown with movie already selected
                return View(showing);
            }

            //if code gets this far, attempt to edit the course
            try
            {
                //Find the course to edit in the database and include relevant 
                //navigational properties
                dbShowing = _context.Showings
                    .Include(cd => cd.Movie)
                    .Include(cd => cd.Tickets).ThenInclude(cd => cd.Order).ThenInclude(cd => cd.Purchaser)
                    .FirstOrDefault(c => c.ShowingID == showing.ShowingID);

                //Find the movie the person wants to watch in the database
                Movie dbMovie = _context.Movies.Find(SelectedMovie);

                //assign the new theater based off of the enum the person selected
                if (SelectedTheatre == 0)
                {
                    dbShowing.Theatre = Theatre.Theatre1;
                }
                else if (SelectedTheatre == 1)
                {
                    dbShowing.Theatre = Theatre.Theatre2;
                }

                //update the course's scalar properties
                dbShowing.Movie = dbMovie;
                dbShowing.ShowingDate = showing.ShowingDate;
                dbShowing.StartTime = new DateTime(showing.ShowingDate.Year, showing.ShowingDate.Month, showing.ShowingDate.Day,
                showing.StartTime.Hour, showing.StartTime.Minute, showing.StartTime.Millisecond);

                if (dbShowing.StartTime < DateTime.Now)
                {
                    return View("Error", new string[] { "You cannot reschedule this movie for the past!" });
                }
                dbShowing.EndTime = dbShowing.StartTime.AddMinutes(dbShowing.Movie.RunTime);
                //TODO: When we find out seats, change this
                dbShowing.SeatsAvailable = showing.SeatsAvailable;

                dbShowing.SpecialEvent = showing.SpecialEvent;
                //TODO: If the showing was published before, should it still be published, or should it go to unpublished?
                dbShowing.Status = showing.Status;


                //TODO: If we don't delete showings when they're cancelled, then add code here to check if status = inactive/cancelled
                //If so, then send customers emails, see if we have to set tickets to inactive anywhere *i don't think so*
                //because its not in the requirements.
                //TODO: if a ticket that was cancelled was paid for with popcorn points, then completely refund them the popcorn points

                //Compare showing you want to add to the other showings on the same date for business rules
                List<Showing> showingsToCompare = _context.Showings
                                                .Include(s => s.Movie)
                                                .Where(s => s.ShowingDate == dbShowing.ShowingDate)
                                                .Where(s => s.Theatre == dbShowing.Theatre).ToList();

                //for each showing on the same day
                foreach (Showing s in showingsToCompare)
                {
                    //if the showing you want to create starts before a showing on the same day,
                    //you must check that its end time is at least 25 minutes before the other show starts
                    if (dbShowing.StartTime > s.StartTime)
                    {
                        //if the other showing starts at least 25 minutes after the showing you're creating, then it's good
                        if (dbShowing.StartTime > s.EndTime.AddMinutes(25) || dbShowing.ShowingID == s.ShowingID || s.Status == "Cancelled")
                        {
                            //good
                        }
                        //this means the other showing starts less than 25 minutes after the showing you want to put in
                        else
                        {
                            return View("Error", new string[]
                            { "The start time you input less than 25 minutes after " + s.Movie.Title + " which ends at " + s.EndTime + ". To fix this, make the start time of " + dbShowing.Movie.Title + " later. "});

                        }
                    }
                    //if the showing you want to add starts after another showing on the same day
                    //you must check that its start time is at least 25 minutes after the other showing's end time
                    else
                    {
                        //if the showing you're creating's start time is 25 minutes after the end of another movie, it's good
                        if (s.StartTime > dbShowing.EndTime.AddMinutes(25) || dbShowing.ShowingID == s.ShowingID || s.Status == "Cancelled")
                        {
                            //good
                        }
                        //this means the showing's start time is less than 25 minutes after the end of another movie
                        else
                        {
                            return View("Error", new string[]
                            { "The start time you input would make the end time of your showing be within 25 minutes of the start of " + s.Movie.Title + " at " + s.StartTime + ". To fix this, make the start time of " + dbShowing.Movie.Title + " earlier or push back " + s.Movie.Title + "."});
                        }
                    }
                }

                //Pull showings to compare that are from another theater
                //Because you cannot play the same movie at the same time at the other theater, they must be different times
                List<Showing> showingsToCompareForOtherTheatre = _context.Showings
                                                .Where(s => s.ShowingDate == dbShowing.ShowingDate)
                                                .Where(s => s.Theatre != dbShowing.Theatre).ToList();

                //For each showing in the opposite theater
                foreach (Showing s in showingsToCompareForOtherTheatre)
                {
                    //If the same movie is being shown as the one we want to add
                    if (s.Movie == dbShowing.Movie)
                    {
                        //And if their start times are the same
                        if (s.StartTime == dbShowing.StartTime)
                        {
                            //This is not allowed, send this error
                            return View("Error", new string[] { dbShowing.Movie.Title + " is being shown at the same time at the other theatre." });
                        }
                    }
                }

                //save the changes
                _context.Showings.Update(dbShowing);
                _context.SaveChanges();

                if (dbShowing.Status == "Cancelled")
                {
                    foreach (Order o in dbShowing.Tickets.Where(t => t.Order.PaidWithPopcornPoints == true).Select(t => t.Order).ToArray())
                    {
                        o.PopcornPoints *= -1;
                        o.Purchaser.PCPBalance += o.PopcornPoints;
                        o.OrderStatus = "Cancelled";

                        _context.Order.Update(o);
                        _context.SaveChanges();

                        //TODO: Add code here for emailing customers and letting them know that their showing has been cancelled, so has their entire order
                        //and their popcorn points have been refunded
                        return RedirectToAction("OrderCancelled", "Email", new { ticketPurchaserID = dbShowing.Tickets.Select(t => t.Order.Purchaser.Id) });
                    }
                } else
                {
                    //TODO: add code here for emailing customers and letting them know their showing has been modified, no action is needed
                    return RedirectToAction("MovieReschedule", "Email", new { ticketPurchaserID = dbShowing.Tickets.Select(t => t.Order.Purchaser.Id) });
                }

            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this product.", ex.Message });
            }

            String theatre = "";
            if (dbShowing.Theatre == Theatre.Theatre1)
            {
                theatre = "0";
            }
            else
            {
                theatre = "1";
            }

            //if code gets this far, everything is okay
            //send the user back to the page with all the courses
            //return RedirectToAction("OrderCancelled", "Email", new { showing. });
            return RedirectToAction(nameof(Index), new { theatre = theatre, showingDate = dbShowing.ShowingDate });

        }

        // GET: Showing/Delete/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var showing = await _context.Showings
                .FirstOrDefaultAsync(m => m.ShowingID == id);
            if (showing == null)
            {
                return NotFound();
            }

            return View(showing);
        }

        // POST: Showing/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Manager")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var showing = await _context.Showings.FindAsync(id);
            _context.Showings.Remove(showing);
            await _context.SaveChangesAsync();

            String theatre = "";
            if (showing.Theatre == Theatre.Theatre1)
            {
                theatre = "0";
            } else
            {
                theatre = "1";
            }
            return RedirectToAction(nameof(Index), new { theatre = theatre, showingDate = showing.ShowingDate });
        }

        private bool ShowingExists(int id)
        {
            return _context.Showings.Any(e => e.ShowingID == id);
        }
    }
}
