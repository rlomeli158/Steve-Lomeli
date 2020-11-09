using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using System.Collections;

namespace FinalProjectWorkspace.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Browse()
        {

            //Populate view bag with list of categories
            ViewBag.AllGenres = GetAllGenres();
            ViewBag.AllMPAARatings = GetAllRatings();

            //Set default properties
            SearchViewModel svm = new SearchViewModel();
            //Are these here necessary?
            svm.SelectedGenreID = (int)AllGenres.Action;
            svm.SelectedSearchType = AllSearchTypes.GreaterThan;
            //svm.SelectedMPAARating = 2; //although it may not work

            return View(svm);
        }

        private SelectList GetAllGenres()
        {

            //Get the list of categories from the database
            List<Genre> genreList = _context.Genres.ToList();

            //add a dummy entry so the user can select all categories
            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All" };
            genreList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //CategoryID and CategoryName are the names of the properties on the Category class
            //CategoryID is the primary key
            SelectList genreSelectList = new SelectList(genreList.OrderBy(m => m.GenreID),
           "GenreID", "GenreName");

            //return the SelectList
            return genreSelectList;
        }

        public SelectList GetAllRatings()
        {

            var MPAASelectList = new SelectList(Enum.GetValues(typeof(AllMPAARatings)).Cast<AllMPAARatings>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(), "Value", "Text");

            return MPAASelectList;
        }

        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            //Initial query LINQ
            var query = from m in _context.Movies select m;

            //If statements corresponding to each input form control

            if (svm.SelectedTitle != null && svm.SelectedTitle != "") //For title
            {
                query = query.Where(m => m.Title.Contains(svm.SelectedTitle));
            }

            if (svm.SelectedOverview != null && svm.SelectedOverview != "") //For overview/description
            {
                query = query.Where(m => m.Overview.Contains(svm.SelectedOverview));
            }

            if (svm.SelectedGenreID != 0) //For genre
            {
                Genre GenreToDisplay = _context.Genres.Find(svm.SelectedGenreID);
                query = query.Where(m => m.Genre == GenreToDisplay);
            }

            if (svm.SelectedMPAARating != 0) //For MPAARating
            {
                string MPAAStringToDisplay = Enum.GetName(typeof(AllMPAARatings), svm.SelectedMPAARating);
                MPAARatings MPAARatingsToDisplay = (MPAARatings)Enum.Parse(typeof(MPAARatings), MPAAStringToDisplay);
                //query = query.Where(m => m.MPAARating.ToString() == MPAARatingToDisplay.ToString());
                query = query.Where(m => m.MPAARating == MPAARatingsToDisplay);
            }

            if (svm.SelectedCustomerRating != null) //For rating 
            {
                switch (svm.SelectedSearchType)
                {
                    case AllSearchTypes.GreaterThan:
                        query = query.Where(m => m.MovieReviews.Average(r => r.Rating) >= Convert.ToDouble(svm.SelectedCustomerRating));
                        break;
                    case AllSearchTypes.LessThan:
                        query = query.Where(m => m.MovieReviews.Average(r => r.Rating) <= Convert.ToDouble(svm.SelectedCustomerRating));
                        break;
                    default:
                        break;
                }
            }


            if (svm.SelectedYear != null) //For release year
            {
                DateTime datSelectedDate = svm.SelectedYear ?? new DateTime(1900, 1, 1);
                query = query.Where(m => m.Year >= datSelectedDate);
            }

            if (svm.SelectedShowingDate != null) //For showing date ********
            {
                DateTime datSelectedDate = svm.SelectedShowingDate ?? new DateTime(1900, 1, 1);
                query = query.Where(m => m.Showings.Max(r => r.ShowingDate) >= datSelectedDate); //TODO: Verify if Max is correct here or if something else should be used
            }

            if (query != null) //they searched for something
            {
                TryValidateModel(svm);
                if (ModelState.IsValid == false)
                {
                    //re-populate ViewBag to have list of all categories & MPAA Ratings
                    ViewBag.AllCategories = GetAllGenres();
                    ViewBag.AllMPAARatings = GetAllRatings();

                    //View is returned with error messages
                    return View("Browse", svm);
                }

                //Execute query, include category with it

                List<Movie> SelectedMovies = query.Include(m => m.Genre).ToList();

                //Populate the view bag with a count of all job postings
                ViewBag.AllMovies = _context.Movies.Count();
                //Populate the view bag with a count of selected job postings
                ViewBag.SelectedMovies = SelectedMovies.Count();


                return View("SearchResults", SelectedMovies.OrderByDescending(m => m.Year)); //Put year in here right now, but it should be showtime, right? **********


            }

            return View("Browse");

        }

        // GET: Movie
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

        // GET: Movie/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .Include(p => p.Showings)
                .FirstOrDefaultAsync(m => m.MovieID == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movie/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieID,MovieNumber,Title,Overview,Tagline,RunTime,Year,Revenue,Actors,MPAARating")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieID,MovieNumber,Title,Overview,Tagline,RunTime,Year,Revenue,Actors,MPAARating")] Movie movie)
        {
            if (id != movie.MovieID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.MovieID))
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
            return View(movie);
        }

        // GET: Movie/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.MovieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.MovieID == id);
        }
    }
}
