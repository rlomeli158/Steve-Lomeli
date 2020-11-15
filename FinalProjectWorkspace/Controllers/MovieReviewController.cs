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
    public class MovieReviewController : Controller
    {
        private readonly AppDbContext _context;

        public MovieReviewController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MovieReview
        public IActionResult Index(int movieID)
        {
            if (movieID == 0)
            { 
                List<MovieReview> MovieReviews = new List<MovieReview>();
                if (User.IsInRole("Manager") || User.IsInRole("Employee"))
                {
                    MovieReviews = _context.MovieReview
                                    .Include(mr => mr.Movie)
                                    .ToList();
                }
                else //user is a customer
                {
                    MovieReviews = _context.MovieReview
                                    .Include(mr => mr.Movie)
                                    .Where(mr => mr.User.UserName == User.Identity.Name)
                                    .ToList();
                }
                return View(MovieReviews);
                
             
            }
            else
            {
                List<MovieReview> mrs = _context.MovieReview
                                          .Include(mr => mr.Movie)
                                          .Where(mr => mr.Movie.MovieID == movieID)
                                          .Where(mr => mr.ApprovalStatus == true)
                                          .ToList();
                return View(mrs);
            }
            return View();
            }

        // GET: MovieReview/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MovieReview movieReview = await _context.MovieReview
                                              .Include(mr => mr.Movie)
                                              .FirstOrDefaultAsync(m => m.MovieReviewID == id);
            if (movieReview == null)
            {
                return NotFound();
            }

            return View(movieReview);
        }

        // GET: MovieReview/Create
        [Authorize(Roles = "Customer")]
        public IActionResult Create()
        {
            ViewBag.AllMovies = GetAllMovies();
            return View();
        }

        // POST: MovieReview/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Customer")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieReviewID,ReviewDate,ApprovalStatus,Rating,ReviewDescription")] MovieReview movieReview, int SelectedMovie)
        {
            if (ModelState.IsValid)
            {
                Movie dbMovie = _context.Movies.Find(SelectedMovie);

                movieReview.Movie = dbMovie;

                movieReview.ReviewDate = DateTime.Now;
                movieReview.ApprovalStatus = false;

                movieReview.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

                _context.Add(movieReview);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "MovieReview", new { id = movieReview.MovieReviewID });
            }
            ViewBag.AllMovies = GetAllMovies();
            return View(movieReview);
        }

        // GET: MovieReview/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MovieReview movieReview = _context.MovieReview
                                       .Include(mr => mr.Movie)
                                       .Include(mr => mr.User)
                                       .FirstOrDefault(o => o.MovieReviewID == id);
            if (movieReview == null)
            {
                return NotFound();
            }
            ViewBag.AllMovies = GetAllMovies();
            return View(movieReview);
        }

        // POST: MovieReview/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieReviewID,ReviewDate,ApprovalStatus,Rating,ReviewDescription")] MovieReview movieReview)
        {
            if (id != movieReview.MovieReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                MovieReview dbMR;
                try
                {
                    dbMR = _context.MovieReview
                      .Include(mr => mr.Movie)
                      .Include(mr => mr.User)
                      .FirstOrDefault(mr => mr.MovieReviewID == movieReview.MovieReviewID);

                    //update the scalar properties
                    dbMR.ApprovalStatus = movieReview.ApprovalStatus;
                    dbMR.Rating = movieReview.Rating;
                    dbMR.ReviewDescription = movieReview.ReviewDescription;

                    _context.Update(dbMR);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieReviewExists(movieReview.MovieReviewID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.AllMovies = GetAllMovies();
            return View(movieReview);
        }

        // GET: MovieReview/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieReview = await _context.MovieReview
                .FirstOrDefaultAsync(m => m.MovieReviewID == id);
            if (movieReview == null)
            {
                return NotFound();
            }

            return View(movieReview);
        }

        // POST: MovieReview/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieReview = await _context.MovieReview.FindAsync(id);
            _context.MovieReview.Remove(movieReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieReviewExists(int id)
        {
            return _context.MovieReview.Any(e => e.MovieReviewID == id);
        }
        private SelectList GetAllMovies()
        {
            //create a list for all the courses
            List<Movie> allMovies = _context.Movies.ToList();

            //the user MUST select a course, so you don't need a dummy option for no course

            //use the constructor on select list to create a new select list with the options
            SelectList slAllMovies = new SelectList(allMovies, nameof(Movie.MovieID), nameof(Movie.Title));

            return slAllMovies;
        }
    }
}
