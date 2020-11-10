using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProjectWorkspace.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index(String SearchString)
        {
            //Initial query LINQ
            var query = from m in _context.Showings select m;
            var CurrentDate = System.DateTime.Now;

            if (SearchString != null && SearchString != "")
            {
                query = query.Where(m => m.Movie.Title.Contains(SearchString) || m.Movie.Overview.Contains(SearchString));
            }

            else
            {
                query = query.Where(m => m.ShowingDate >= CurrentDate);
            }

            List<Showing> TodayShowing = query.Include(m => m.Movie).ToList();

            ViewBag.AllShowings = _context.Showings.Count();
            ViewBag.SelectedShowings = TodayShowing.Count();

            return View(TodayShowing.OrderBy(m => m.ShowingDate));


            //return View(await _context.Showings.ToListAsync());

        }

        // GET: /<controller>/
        public IActionResult SearchResults(String SearchString)
        {
            //LINQ to query movies
            var query = from jp in _context.Movies select jp;

            //If they searched for something
            if (SearchString != null)
            {
                query = query.Where(jp => jp.Title.Contains(SearchString) || jp.Overview.Contains(SearchString));

            }

            //Execute query
            List<Movie> SelectedMovies = query.Include(jp => jp.Showings).ToList();

            //Populate the view bag with a count of all job postings
            ViewBag.AllMovies = _context.Movies.Count();
            //Populate the view bag with a count of selected job postings
            ViewBag.SelectedMovies = SelectedMovies.Count();

            return View(SelectedMovies.OrderByDescending(jp => jp.Showings.Min(s => s.ShowingDate))); // This line of code doesn't work because of the showing date ***********

            //return View(SelectedMovies);

        }

        public IActionResult Details(int? id)
        {
            if (id == null) //MovieID not specified
            {
                return View("Error", new String[] { "MovieID not specified - which movie do you want to view?" });
            }

            //Execute query
            Movie movie = _context.Movies.Include(j => j.Genre).FirstOrDefault(j => j.MovieID == id);

            if (movie == null) //Movie does not exist in database
            {
                return View("Error", new String[] { "Movie not found in database" });
            }

            //if code gets this far, all is well
            return View(movie);
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
            //Add svm.SelectedMPAARatings = 0 although it may not work

            return View(svm);
        }

        private SelectList GetAllGenres()
        {

            //Get the list of categories from the database
            List<Genre> genreList = _context.Genres.ToList();

            //add a dummy entry so the user can select all categories
            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All Genres" };
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
                string MPAARatingToDisplay = Enum.GetName(typeof(AllMPAARatings), svm.SelectedMPAARating);
                query = query.Where(m => m.MPAARating.ToString() == MPAARatingToDisplay);
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
                query = query.Where(m => m.Showings.Min(r => r.ShowingDate) >= datSelectedDate); //Same issue as above, get showing date from showings or rating from movie review.
                                                                                                 //Should it even be min?
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
                    return View("DetailedSearch", svm);
                }

                //Execute query, include category with it

                List<Movie> SelectedMovies = query.Include(m => m.Genre).ToList();

                //Populate the view bag with a count of all job postings
                ViewBag.AllMovies = _context.Movies.Count();
                //Populate the view bag with a count of selected job postings
                ViewBag.SelectedMovies = SelectedMovies.Count();


                return View("SearchResults", SelectedMovies.OrderByDescending(m => m.Year)); //Put year in here right now, but it should be showtime, right? **********


            }

            return View("DetailedSearch");
        }

        public async Task<IActionResult> MovieDetails(int? id)
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


        // Views Employee Home After Login
        public IActionResult EmployeeHomeView()
        {
            return View();
        }

        // Views Manager Home After Login
        public IActionResult ManagerHomeView()
        {
            return View();
        }

        // this action displays the OrderCheckout view
        public IActionResult OrderCheckout()
        {
            return View();
        }

        // GET: /<controller>/
        [HttpGet]
        //this method makes sure the grade follows our business rules
        public IActionResult OrderTotals(Order order)
        {
            //Validate the model
            TryValidateModel(order);

            //something is wrong
            if (ModelState.IsValid == false)
            {
                //send user back to inputs page
                return View("OrderCheckout");
            }


            //send user to results page
            return View("OrderTotals", order);

        }

        // Views Order Confirmed
        public IActionResult OrderConfirmed()
        {
            return View();
        }


        // Views Cancelled Order Confirmed
        public IActionResult CancelledOrderConfirmed()
        {
            return View();
        }

        public IActionResult Seats()
        {
            return View();
        }
    }
}
