using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;

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
        public async Task<IActionResult> Index()
        {
            return View(await _context.Showings.Include(s => s.Movie).ToListAsync());
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

        // GET: Showing/Create
        public IActionResult Create()
        {
            ViewBag.AllMovies = GetAllMovies();
            return View();
        }

        // POST: Showing/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShowingID,ShowingDate,StartTime,EndTime,Theatre,SeatsAvailable,SpecialEvent")] Showing showing, int SelectedMovies)
        {
            //This code has been modified so that if the model state is not valid
            //we immediately go to the "sad path" and give the user a chance to try again
            if (ModelState.IsValid == false)
            {
                //re-populate the view bag with the departments
                ViewBag.AllMovies = GetAllMovies();
                //go back to the Create view to try again
                return View(showing);
            }

            //if code gets to this point, we know the model is valid and
            //we can add the showing to the database

            Movie dbMovie = _context.Movies.Find(SelectedMovies);
            showing.Movie = dbMovie;

            //add the showing to the database and save changes
            _context.Add(showing);
            await _context.SaveChangesAsync();

            //Send the user to the page with all the showings
            return RedirectToAction(nameof(Index));
        }

        // GET: Showing/Edit/5
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

            //ViewBag.AllMovies = GetAllMovies(showing.ShowingID);
            return View(showing);
        }

        /*
        private SelectList GetAllMovies(int showingID)
        {
            //Create a new list of departments and get the list of the departments
            //from the database
            List<Movie> allMovies = _context.Movies.ToList();


            //Find all of the course departments currently associated with this course
            List<Showing> movies = _context.Showings
                                         .Include(p => p.Movie)
                                         .ToList();

            List<Movie> movies2 = _context.Movies
                                         .Include(p => p.Showings)
                                         .ToList();

            Int32 selectedMovieID = movies2.Where(r => r.Showings.Min(rp => rp.ShowingID) == showingID);


            //use the MultiSelectList constructor method to get a new MultiSelectList
            SelectList slAllMovies = new SelectList(allMovies.OrderBy(d => d.Title), "MovieID", "Title", selectedMovieID);


            //return the MultiSelectList
            return slAllMovies;

        }
        */

        // POST: Showing/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ShowingID,ShowingDate,StartTime,EndTime,Theatre,SeatsAvailable,SpecialEvent")] Showing showing, int[] SelectedMovies)
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

                //update the course's scalar properties
                dbShowing.ShowingDate = showing.ShowingDate;
                dbShowing.StartTime = showing.StartTime;
                dbShowing.EndTime = showing.StartTime.AddMinutes(showing.Movie.RunTime);
                dbShowing.Theatre = showing.Theatre;
                dbShowing.SeatsAvailable = showing.SeatsAvailable;
                dbShowing.SpecialEvent = showing.SpecialEvent;

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
