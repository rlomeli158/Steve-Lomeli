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

        private MultiSelectList GetAllMovies()
        {
            //Get the list of suppliers from the database
            List<Movie> movieList = _context.Movies.ToList();

            /*
            //add a dummy entry so the user can select all suppliers
            Supplier SelectNone = new Supplier() { SupplierID = 0, SupplierName = "All Suppliers" };
            supplierList.Add(SelectNone);
            */

            //convert the list to a SelectList by calling SelectList constructor
            //SupplierID and SupplierName are the names of the properties on the Supplier class
            //SupplierID is the primary key
            MultiSelectList movieSelectList = new MultiSelectList(movieList.OrderBy(s => s.MovieID), "MovieID", "Title");

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
        public async Task<IActionResult> Create([Bind("ShowingID,ShowingDate,StartTime,EndTime,Theatre,SeatsAvailable,SpecialEvent")] Showing showing, int[] SelectedMovies)
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

            //add the showing to the database and save changes
            _context.Add(showing);
            await _context.SaveChangesAsync();

            //add the associated departments to the course
            //loop through the list of deparment ids selected by the user
            foreach (int movieID in SelectedMovies)
            {
                /*TODO: Figure out what to do about all this here
                //find the department associated with that id
                Movie dbMovie = _context.Movies.Find(movieID);

                //create a new ProductSuppliers object to make the association
                ProductSupplier ps = new ProductSupplier();

                //set the properties of the ProductSuppliers object
                ps.Product = product; //this is the course object that was passed into
                                      //the method as part of the HTTP reqest

                ps.Supplier = dbSupplier; //this is the supplier we found above

                //add the ProductSuppliers to the database and save changes
                _context.ProductSuppliers.Add(ps);
                _context.SaveChanges();
                */
            }

            //Send the user to the page with all the departments
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
        private MultiSelectList GetAllMovies(int showingID)
        {
            //Create a new list of departments and get the list of the departments
            //from the database
            List<Movie> allMovies = _context.Movies.ToList();

            
            //Find all of the course departments currently associated with this course
            List<Movie> movies = _context.Movies
                                         .Include(p => p.Showings)
                                         .Where(p => p.Showings == showingID)
                                         .ToList();

            //loop through the list of course departments to find a list of department ids
            //create a list to store the department ids
            List<Int32> selectedMoviesID = new List<Int32>();

            //Loop through the list to find the DepartmentIDs
            foreach (MovieShowing p in movieShowing)
            {
                selectedMoviesID.Add(p.Movie.MovieID);
            }

            //use the MultiSelectList constructor method to get a new MultiSelectList
            MultiSelectList mslAllMovies = new MultiSelectList(allMovies.OrderBy(d => d.Title), "MovieID", "Title", selectedMoviesID);
            

            //return the MultiSelectList
            return mslAllMovies;
            
        }

        
        // POST: Showing/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShowingID,ShowingDate,StartTime,EndTime,Theatre,SeatsAvailable,SpecialEvent")] Showing showing, int[] SelectedMovies)
        {
            //this is a security check to see if the user is trying to modify
            //a different record.  Show an error message
            if (id != showing.ShowingID)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            if (ModelState.IsValid == false) //there is something wrong
            {
                ViewBag.AllMovies = GetAllMovies(showing.ShowingID);
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

                //create a list of departments that need to be removed
                List<Movie> MoviesToRemove = new List<Movie>();

                //find the departments that should no longer be selected because the
                //user removed them
                //remember, SelectedDepartments = the list from the HTTP request (listbox)
                foreach (Movie cd in dbShowing.Movie)
                {
                    //see if the new list contains the department id from the old list
                    if (SelectedMovies.Contains(cd.MovieID) == false)//this department is not on the new list
                    {
                        MoviesToRemove.Add(cd);
                    }
                }

                //remove the departments you found in the list above
                //this has to be 2 separate steps because you can't iterate (loop)
                //over a list that you are removing things from
                foreach (ProductSupplier cd in SuppliersToRemove)
                {
                    //remove this course department from the database
                    _context.ProductSuppliers.Remove(cd);
                    _context.SaveChanges();
                }

                //add the departments that aren't already there
                foreach (int supplierID in SelectedSuppliers)
                {
                    if (dbProduct.ProductSuppliers.Any(d => d.Supplier.SupplierID == supplierID) == false)//this department is NOT already associated with this course
                    {
                        //create a new instance of the bridge table class
                        ProductSupplier cd = new ProductSupplier();
                        cd.Supplier = _context.Suppliers.Find(supplierID);
                        cd.Product = dbProduct;

                        //add the new instance to the database
                        _context.ProductSuppliers.Add(cd);
                        _context.SaveChanges();
                    }
                }

                //update the course's scalar properties
                dbProduct.Price = product.Price;
                dbProduct.Name = product.Name;
                dbProduct.Description = product.Description;

                //save the changes
                _context.Products.Update(dbProduct);
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
        */

        private bool ShowingExists(int id)
        {
            return _context.Showings.Any(e => e.ShowingID == id);
        }
    }
}
