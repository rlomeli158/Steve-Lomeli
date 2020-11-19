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
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Order
        [Authorize]
        public IActionResult Index()
        {
            List<Order> Orders = new List<Order>();
            if (User.IsInRole("Manager"))
            {
                Orders = _context.Order.Include(o => o.Tickets).ToList();
            }
            else //user is a customer
            {
                Orders = _context.Order.Where(o => o.Recipient.UserName == User.Identity.Name
                                                || o.Purchaser.UserName == User.Identity.Name).Include(ord => ord.Tickets).ToList();
            }

            return View(Orders);
        }

        // GET: Order/Details/5
        public IActionResult Details(int? id)
        {
            //if no registration was specifieds
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order to view!" });
            }

            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets.OrderBy(t => t.Showing.StartTime)).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == id);

            //if registration wasn't found
            if (order == null)
            {
                return View("Error", new String[] { "This order was not found!" });
            }

            //make sure a customer isn't trying to look at someone else's order
            if (User.IsInRole("Manager") == false && order.Purchaser.UserName != User.Identity.Name && order.Recipient.UserName != User.Identity.Name)
            {
                return View("Error", new string[] { "You are not authorized to edit this order!" });
            }

            return View(order);
        }

        // GET: Order/Details/5
        public IActionResult ActiveOrder(int? id)
        {
            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets.OrderBy(t => t.Showing.StartTime)).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .Where(ord => ord.OrderStatus == "Active")
                .FirstOrDefault(o => o.Purchaser.UserName == User.Identity.Name);

            //if registration wasn't found
            if (order == null)
            {
                return View("Error", new String[] { "There is no active order!" });
            }

            //make sure a customer isn't trying to look at someone else's order
            if (User.IsInRole("Manager") == false && order.Purchaser.UserName != User.Identity.Name && order.Recipient.UserName != User.Identity.Name)
            {
                return View("Error", new string[] { "You are not authorized to edit this order!" });
            }

            return View("Details",order);
        }


        // GET: Order/Create
        [Authorize(Roles = "Customer")]
        public IActionResult Create(int? showingID)
        {
            //Find order in database that corresponds to user
            Order orderInDB = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .Where(ord => ord.OrderStatus == "Active")
                .FirstOrDefault(o => o.Purchaser.UserName == User.Identity.Name);

            if (orderInDB != null)
            {
                return RedirectToAction("Details", "Order", new { id = orderInDB.OrderID });
                //return View("Error", new string[] { "You already have an active cart! Click the cart in the upper right corner to add tickets or view our showings now." });
            }

            return View(showingID);
        }

        // POST: Order/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Customer")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,TransactionNumber,OrderDate,OrderStatus")] Order order, int? showingID)
        {
            //Find order in database that corresponds to user

            //Checks if there's an active order
            Order orderInDB = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .Where(ord => ord.OrderStatus == "Active")
                .FirstOrDefault(o => o.Purchaser.UserName == User.Identity.Name);

            if (orderInDB != null)
            {
                order = orderInDB;

                //make sure all properties are valid
                if (ModelState.IsValid == false)
                {
                    return View(order);
                }
            }
            else
            {
                //TODO: Set order number automatically
                order.TransactionNumber = Utilities.GenerateNextTransactionNumber.GetNextTransactionNumber(_context);

                //Set order date to right now
                order.OrderDate = DateTime.Now;

                //Associate order with the logged in customer TODO: add logic here for gifting?
                order.Purchaser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

                order.OrderStatus = "Active";

                //make sure all properties are valid
                if (ModelState.IsValid == false)
                {
                    return View(order);
                }

                //if code gets this far, add the registration to the database
                _context.Add(order);
                await _context.SaveChangesAsync();

            }
            
            //send the user on to the action that will allow them to 
            //create a registration detail.  Be sure to pass along the RegistrationID
            //that you created when you added the registration to the database above
            if (showingID == null)
            {
                return RedirectToAction("Create", "Ticket", new { orderID = order.OrderID});

            } else
            {
                return RedirectToAction("Create", "Ticket", new { orderID = order.OrderID, showingID });
            }

        }

        // GET: Order/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets.OrderBy(t => t.Showing.StartTime)).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == id);

            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Order/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,TransactionNumber,OrderDate,OrderStatus")] Order order)
        {
            if (id != order.OrderID)
            {
                return View("Error", new String[] { "There was a problem editing this order. Try again!" });
            }

            //if there is something wrong with this order, try again
            if (ModelState.IsValid == false)
            {
                return View(order);
            }

            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Order dbOrder = _context.Order.Find(order.OrderID);

                //update the notes
                //TODO: What would they even update?
                //dbOrder.OrderNotes = order.OrderNotes;

                _context.Update(dbOrder);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Orders Index page.
            return RedirectToAction(nameof(Index));
        }

        // GET: Order/Edit/5
        [HttpGet, ActionName("CompleteOrder")]
        public async Task<IActionResult> CompleteOrderAsync(Order orderIn)
        {
            if (orderIn.OrderID == 0)
            {
                return NotFound();
            }

            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == orderIn.OrderID);

            order.PaidWithPopcornPoints = orderIn.PaidWithPopcornPoints;

            if (order.PaidWithPopcornPoints == true)
            {
                foreach (Ticket t in order.Tickets)
                {
                    t.TotalCost = 0;
                    t.TransactionPopcornPoints = -100.00m;
                }
                order.PopcornPoints = order.Tickets.Count() * -100;
                order.Purchaser.PCPBalance -= Math.Abs(order.PopcornPoints);
            }
            else
            {
                order.PopcornPoints = (int)order.Tickets.Sum(t => t.TransactionPopcornPoints);
                order.Purchaser.PCPBalance = order.Purchaser.PCPBalance + order.PopcornPoints;
            }

            if (orderIn.Recipient.UserName != null)
            {
                AppUser user = _context.Users.Where(u => u.UserName == orderIn.Recipient.UserName).FirstOrDefault();
                if (user != null)
                {
                    order.Recipient = user;
                } else
                {
                    return View("Error", new String[] { "This user doesn't have a Main Street Movies account! Please have them create one before gifting them tickets."});
                }
            }

            //TODO: If we uncomment this, then popcorn points get deducted successfully. We would have to remove "Return To Index" on the confirmation page.s
            _context.Update(order);
            await _context.SaveChangesAsync();

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompleteOrder(Order orderIn)
        {
            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == orderIn.OrderID);

            order.OrderStatus = "Paid";

            _context.Update(order);
            await _context.SaveChangesAsync();

            //send the user to the Orders Index page.
            return RedirectToAction(nameof(Confirmed),order);
        }

        // GET: Order/Edit/5
        public IActionResult Confirmed(Order order)
        { 
            return View(order);
        }

        public async Task<IActionResult> Cancelled(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == id);

            //if code gets this far, update the record
            try
            {
                //find the record in the database
                //Order dbOrder = _context.Order.Find(order.OrderID);

                //update the order status to cancelled
                order.OrderStatus = "Cancelled";

                _context.Update(order);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Orders Index page.
            return View(order);
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderID == id);
        }
    }
}
