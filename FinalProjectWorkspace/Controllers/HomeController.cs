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
        public IActionResult Index()
        {
            return View();
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

            //return View(SelectedMovies.OrderByDescending(jp => jp.Showings.ShowingDate)); // This line of code doesn't work because of the showing date ***********

            return View(SelectedMovies);

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

        public IActionResult DetailedSearch()
        {

            //Populate view bag with list of categories
            ViewBag.AllGenres = GetAllGenres();

            //Set default properties
            SearchViewModel svm = new SearchViewModel();
            //svm.SelectedCategories = AllCategories.Computer;
            //svm.SelectedSearchType = AllSearchTypes.GreaterThan;

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

        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            //Initial query LINQ
            var query = from jp in _context.Movies select jp;

            //If statements corresponding to each input form control

            if (svm.SelectedTitle != null && svm.SelectedTitle != "") //For title
            {
                query = query.Where(jp => jp.Title.Contains(svm.SelectedTitle));
            }

            if (svm.SelectedOverview != null && svm.SelectedOverview != "") //For overview/description
            {
                query = query.Where(jp => jp.Overview.Contains(svm.SelectedOverview));
            }

            if (svm.SelectedGenreID != 0) //For genre
            {
                Genre GenreToDisplay = _context.Genres.Find(svm.SelectedGenreID);
                query = query.Where(jp => jp.Genre == GenreToDisplay);
            }

            /*
            if (svm.SelectedCustomerRating != null) For rating ********
            {
                switch (svm.SelectedSearchType)
                {
                    case AllSearchTypes.GreaterThan:
                        query = query.Where(jp => jp.MovieReviews.Rating >= Convert.ToDecimal(svm.SelectedCustomerRating)); //Troubleshoot these lines, same as above
                        break;
                    case AllSearchTypes.LessThan:
                        query = query.Where(jp => jp.MovieReviews.Rating <= Convert.ToDecimal(svm.SelectedCustomerRating)); //Troubleshoot these lines, same as above
                        break;
                    default:
                        break;
                }
            }
            */

            if (svm.SelectedYear != null) //For release year
            {
                DateTime datSelectedDate = svm.SelectedYear ?? new DateTime(1900, 1, 1); 
                query = query.Where(jp => jp.Year >= datSelectedDate);
            }

            if (svm.SelectedShowingDate != null) //For showing date ********
            {
                DateTime datSelectedDate = svm.SelectedShowingDate ?? new DateTime(1900, 1, 1);
                //query = query.Where(jp => jp.Showings.ShowingDate >= datSelectedDate); //Same issue as above, get showing date from showings or rating from movie review
            }

            if (query != null) //they searched for something
            {
                TryValidateModel(svm);
                if (ModelState.IsValid == false)
                {
                    //re-populate ViewBag to have list of all categories
                    ViewBag.AllCategories = GetAllGenres();

                    //View is returned with error messages
                    return View("DetailedSearch", svm);
                }

                //Execute query, include category with it

                List<Movie> SelectedMovies = query.Include(jp => jp.Genre).ToList();

                //Populate the view bag with a count of all job postings
                ViewBag.AllMovies = _context.Movies.Count();
                //Populate the view bag with a count of selected job postings
                ViewBag.SelectedMovies = SelectedMovies.Count();


                return View("Index", SelectedMovies.OrderByDescending(jp => jp.Year)); //Put year in here right now, but it should be showtime, right? **********


            }

            return View("DetailedSearch");
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
    }
}
