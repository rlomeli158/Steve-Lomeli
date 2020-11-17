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
        public IActionResult Index(DateTime StartingShowingDate, String theatre, DateTime ShowingDate)
        {
            //LINQ to query job postings
            var query = from jp in _context.Showings select jp;
            query = query.Include(s => s.Movie);

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

            if(ShowingDate != new DateTime(01, 01, 0001))
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
            return View(SelectedShowings.OrderBy(s => s.ShowingDate));

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

        private SelectList GetAllDays()
        {
            //Get the list of suppliers from the database
            List<string> weekDays = new List<string>()
            {
                "Select a Day",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //convert the list to a SelectList by calling SelectList constructor
            //SupplierID and SupplierName are the names of the properties on the Supplier class
            //SupplierID is the primary key
            SelectList weekDaySelectList = new SelectList(weekDays, "ID", "day");

            //return the MultiSelectList
            return weekDaySelectList;
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
                //re-populate the view bag with the departments
                ViewBag.AllTheatres = GetAllTheatres();
                ViewBag.AllMovies = GetAllMovies();
                //go back to the Create view to try again
                return View(showing);
            }

            if (SelectedTheatre == 0)
            {
                showing.Theatre = Theatre.Theatre1;
            }
            else if (SelectedTheatre == 1)
            {
                showing.Theatre = Theatre.Theatre2;
            }

            //if code gets to this point, we know the model is valid (except for the showing time) and
            //we can add the showing to the database once we check showing
            Movie dbMovie = _context.Movies.Find(SelectedMovie);
            showing.Movie = dbMovie;
            showing.Status = "Unpublished";
            showing.StartTime = new DateTime(showing.ShowingDate.Year, showing.ShowingDate.Month, showing.ShowingDate.Day,
                showing.StartTime.Hour, showing.StartTime.Minute, showing.StartTime.Millisecond);
            showing.EndTime = showing.StartTime.AddMinutes(showing.Movie.RunTime);

            //Compare showing you want to add to the other showings on the same date
            List<Showing> showingsToCompare = _context.Showings
                                            .Where(s => s.ShowingDate == showing.ShowingDate)
                                            .Where(s => s.Theatre == showing.Theatre).ToList();

            foreach(Showing s in showingsToCompare)
            {
                if(showing.StartTime > s.StartTime)
                {
                    if (showing.StartTime > s.EndTime.AddMinutes(25))
                    {
                        //good
                    }
                    else
                    {
                        return View("Error", new string[] { "Showing is too close to the end of another movie." });
                    }
                }
                else
                {
                    if(s.StartTime > showing.EndTime.AddMinutes(25))
                    {
                        //good
                    }
                    else
                    {
                        return View("Error", new string[] { "Showing is too close to the start of another movie." });
                    }
                }
            }

            List<Showing> showingsToCompareForOtherTheatre = _context.Showings
                                            .Where(s => s.ShowingDate == showing.ShowingDate)
                                            .Where(s => s.Theatre != showing.Theatre).ToList();

            foreach(Showing s in showingsToCompareForOtherTheatre)
            {
                if(s.Movie == showing.Movie)
                {
                    if (s.StartTime == showing.StartTime)
                    {
                        return View("Error", new string[] { "This is being shown at the same time at another theatre." });
                    }
                }
            }

            //add the showing to the database and save changes
            _context.Add(showing);
            await _context.SaveChangesAsync();

            //Send the user to the page with all the showings
            return RedirectToAction(nameof(Index));
        }


        public IActionResult CopySchedule()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CopySchedule(DateTime originalDate, int originalTheatre, DateTime newDate, int copyTheater)
        {
            Theatre ogTheatre = Theatre.Theatre1;
            Theatre newTheatreEnum = Theatre.Theatre1;

            if (originalTheatre == 1)
            {
                ogTheatre = Theatre.Theatre2;
            }

            if (copyTheater == 1)
            {
                newTheatreEnum = Theatre.Theatre2;
            }

            List<Showing> originalShowings = _context.Showings
                                            .Include(s => s.Movie)
                                            .Where(s => s.ShowingDate == originalDate)
                                            .Where(s => s.Theatre == ogTheatre).ToList();

            List<Showing> showingsToCompareForOtherTheatre = _context.Showings
                                .Where(s => s.ShowingDate == newDate)
                                .Where(s => s.Theatre != newTheatreEnum).ToList();

            foreach (Showing s in originalShowings)
            {
                Showing showing = new Showing();
                Movie dbMovie = _context.Movies.Find(s.Movie.MovieID);
                showing.Movie = dbMovie;
                showing.ShowingDate = newDate;
                showing.Status = "Unpublished";
                showing.StartTime = new DateTime(showing.ShowingDate.Year, showing.ShowingDate.Month, showing.ShowingDate.Day,
                    s.StartTime.Hour, s.StartTime.Minute, s.StartTime.Millisecond);
                showing.EndTime = showing.StartTime.AddMinutes(showing.Movie.RunTime);
                showing.Theatre = newTheatreEnum;
                showing.SeatsAvailable = s.SeatsAvailable;
                showing.SpecialEvent = s.SpecialEvent;

                foreach (Showing theaterShowing in showingsToCompareForOtherTheatre)
                {
                    if (theaterShowing.Movie == showing.Movie)
                    {
                        if (theaterShowing.StartTime == showing.StartTime)
                        {
                            return View("Error", new string[]
                            { showing.Movie.Title + " is being shown at the same time at another theatre." });
                        }
                    }
                }

                //add the showing to the database and save changes
                _context.Add(showing);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index","Showing", new { theatre = copyTheater, ShowingDate = newDate} );
        }

        public IActionResult GetUnpublishedShowings()
        {
            List<Showing> showings = _context.Showings.Include(s => s.Movie).Where(s => s.Status == "Unpublished").ToList();

            return RedirectToAction("Publish", "Showing", new { showings });
        }

        public IActionResult Publish()
        {
            List<Showing> showings = _context.Showings.Include(s => s.Movie).Where(s => s.Status == "Unpublished").ToList();

            showings.OrderBy(s => s.ShowingDate);

            //Use this to check if movie runs past 9:30 PM
            DateTime compareTime;

            //Use this as a counter to ensure at least one movie ends past 9:30 PM
            Int32 movieEndPastNine = 0;

            //Orders showing by showing date
            showings = showings.OrderBy(s => s.StartTime).ToList();

            //Use this to check if the start time of the current movie
            //is no more than 45 minutes past the end time of previous movie
            DateTime goodEndTime = showings.Select(s => s.EndTime).First();

            foreach (Showing s in showings)
            {
                //Checks if a movie runs past 9:30 PM
                compareTime = new DateTime(s.EndTime.Year, s.EndTime.Month, s.EndTime.Day, 21, 30,00);
                if (s.EndTime > compareTime)
                {
                    movieEndPastNine += 1;
                }

                //Checks if start time is no more than 45 minutes after previous movie's end time, enters if bad
                if(s.StartTime > goodEndTime.AddMinutes(45))
                {
                    return View("Error", new string[]
                    {  s.Movie.Title + " (ID: "+ s.ShowingID + ") " + "showing at " + s.StartTime + " is more than 45 minutes after the previous showing." });
                }

                goodEndTime = s.EndTime;
            }

            if (movieEndPastNine < 1)
            {
                return View("Error", new string[] { "There is no movie that runs past 9:30 PM. Please add one." });
            } else
            {
                foreach (Showing s in showings)
                {
                    s.Status = "Published";
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
                Showing dbShowing = _context.Showings
                    .Include(cd => cd.Movie)
                    .FirstOrDefault(c => c.ShowingID == showing.ShowingID);

                Movie dbMovie = _context.Movies.Find(SelectedMovie);

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
                dbShowing.EndTime = dbShowing.StartTime.AddMinutes(dbShowing.Movie.RunTime);
                dbShowing.SeatsAvailable = showing.SeatsAvailable;
                dbShowing.SpecialEvent = showing.SpecialEvent;
                dbShowing.Status = showing.Status;

                //save the changes
                _context.Showings.Update(dbShowing);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this product.", ex.Message });
            }

            //if code gets this far, everything is okay
            //send the user back to the page with all the courses
            return RedirectToAction(nameof(Index));
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
            return RedirectToAction(nameof(Index));
        }

        private bool ShowingExists(int id)
        {
            return _context.Showings.Any(e => e.ShowingID == id);
        }
    }
}
