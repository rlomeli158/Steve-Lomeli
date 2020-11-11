using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using System.Globalization;

namespace FinalProjectWorkspace.Controllers
{
    public class TicketController : Controller
    {
        private readonly AppDbContext _context;

        public TicketController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Ticket
        public IActionResult Index(int orderID)
        {
            //limit the list to only the registration details that belong to this registration
            List<Ticket> t = _context.Ticket
                                       .Include(rd => rd.Showing)
                                       .Where(rd => rd.Order.OrderID == orderID)
                                       .ToList();

            return View(t);
        }

        private SelectList GetAllShowings()
        {
            //create a list for all the courses
            List<Showing> allShowings = _context.Showings.Include(s => s.Movie).ToList();

            //the user MUST select a course, so you don't need a dummy option for no course

            //use the constructor on select list to create a new select list with the options
            SelectList slAllShowings = new SelectList(allShowings, nameof(Showing.ShowingID), nameof(Showing.StartTime));

            return slAllShowings;
        }

        // GET: Ticket/Create
        public IActionResult Create(int orderID)
        {
            //create a new instance of the RegistrationDetail class
            Ticket t = new Ticket();

            //find the registration that should be associated with this registration
            Order dbOrder = _context.Order.Find(orderID);

            //set the new registration detail's registration equal to the registration you just found
            t.Order = dbOrder;

            //populate the ViewBag with a list of existing courses
            ViewBag.AllShowings = GetAllShowings();

            //pass the newly created registration detail to the view
            return View(t);
        }

        private Decimal GetPrice(String showingDay, DateTime showingTime)
        {
            Decimal showingPrice = 0.00m;

            var weekDays = new List<string>()
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday"
            };

            //Important Times
            DateTime compareTimeNoon = new DateTime(showingTime.Year, showingTime.Month, showingTime.Day, 12, 00, 00);

            DateTime compareTimeFive = new DateTime(showingTime.Year, showingTime.Month, showingTime.Day, 17, 00, 00);


            //set the registration detail's price equal to the course price
            //this will allow us to to store the price that the user paid
            //TODO: Get ticket price from prices table
            if (weekDays.Contains(showingDay))
            {

                if (showingTime < compareTimeNoon)
                {
                    String price = _context.Prices
                                    .Where(p => p.PriceName == "MATINEE_PRICE")
                                    .Select(p => p.PriceAmount).First().ToString();

                    showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                }
                else if (showingDay == "Tuesday" && showingTime < compareTimeFive) //WORKS
                {
                    String price = _context.Prices
                                    .Where(p => p.PriceName == "DISCOUNT_TUESDAY_PRICE")
                                    .Select(p => p.PriceAmount).First().ToString();

                    showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                }
                else if (showingDay != "Friday") //WORKS FOR WEEKDAYS AFTER 5, WORKS FOR TUESDAY AFTER 5
                {
                    String price = _context.Prices
                                    .Where(p => p.PriceName == "WEEKDAY_REGULAR_PRICE")
                                    .Select(p => p.PriceAmount).First().ToString();

                    showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                }
                else if (showingTime > compareTimeNoon) //WORKS FOR FRIDAY
                {
                    String price = _context.Prices
                                    .Where(p => p.PriceName == "WEEKEND_REGULAR_PRICE")
                                    .Select(p => p.PriceAmount).First().ToString();

                    showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                }
            }
            else
            {
                String price = _context.Prices
                                                    .Where(p => p.PriceName == "WEEKEND_REGULAR_PRICE")
                                                    .Select(p => p.PriceAmount).First().ToString();

                showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
            }

            return showingPrice;
        }

        // POST: Ticket/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Order, TicketID, SeatNumber")] Ticket ticket, int SelectedShowing)
        {
            //if user has not entered all fields, send them back to try again
            if (ModelState.IsValid == false)
            {
                ViewBag.AllShowings = GetAllShowings();
                return View(ticket);
            }

            //find the course to be associated with this order
            Showing dbShowing = _context.Showings.Find(SelectedShowing);

            //set the registration detail's course to be equal to the one we just found
            ticket.Showing = dbShowing;

            //find the registration on the database that has the correct registration id
            //unfortunately, the HTTP request will not contain the entire registration object, 
            //just the registration id, so we have to find the actual object in the database
            Order dbOrder = _context.Order.Find(ticket.Order.OrderID);

            //set the registration on the registration detail equal to the registration that we just found
            ticket.Order = dbOrder;

            //Get showing day and showing time
            String showingDay = dbShowing.ShowingDate.ToString("dddd");
            DateTime showingTime = dbShowing.StartTime;

            //Get prices depending on day and time
            ticket.TicketPrice = GetPrice(showingDay, showingTime);

            //calculate the extended price for the registration detail
            //TODO: Calculate total cost by number of tickets * price per ticket?
            ticket.TotalCost = ticket.TicketPrice;

            ticket.DiscountAmount = 0;

            ticket.TransactionPopcornPoints = ticket.TicketPrice;

            //add the registration detail to the database
            _context.Add(ticket);
            await _context.SaveChangesAsync();

            //send the user to the details page for this registration
            return RedirectToAction("Details", "Order", new { id = ticket.Order.OrderID });
        }

        // GET: Ticket/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //user did not specify a registration detail to edit
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a ticket to edit!" });
            }

            //find the registration detail
            Ticket ticket = await _context.Ticket
                                          .Include(rd => rd.Showing)
                                          .Include(rd => rd.Order)
                                          .FirstOrDefaultAsync(rd => rd.TicketID == id);
            if (ticket == null)
            {
                return View("Error", new String[] { "This ticket's details were not found" });
            }
            return View(ticket);
        }

        // POST: Ticket/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketID,TicketPrice,DiscountAmount,TotalCost,SeatNumber,TransactionPopcornPoints")] Ticket ticket)
        {
            //this is a security check to make sure they are editing the correct record
            if (id != ticket.TicketID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(ticket);
            }

            //create a new registration detail
            Ticket dbT;
            //if code gets this far, update the record
            try
            {
                //find the existing registration detail in the database
                //include both registration and course
                dbT = _context.Ticket
                      .Include(rd => rd.Showing)
                      .Include(rd => rd.Order)
                      .FirstOrDefault(rd => rd.TicketID == ticket.TicketID);

                //update the scalar properties

                //Get new showing day and showing time
                String showingDay = ticket.Showing.ShowingDate.ToString("dddd");
                DateTime showingTime = ticket.Showing.StartTime;

                //Apply new ticket price
                dbT.TicketPrice = GetPrice(showingDay, showingTime);

                dbT.TotalCost = ticket.TicketPrice - ticket.DiscountAmount; //Set discount amount as not null, just set to 0

                //dbT.Quantity = orderDetail.Quantity;
                dbT.SeatNumber = ticket.SeatNumber;
                //dbT.ExtendedPrice = dbT.Quantity * dbT.ProductPrice;

                dbT.TransactionPopcornPoints = dbT.TicketPrice;


                //save changes
                _context.Update(dbT);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the registration details index page
            return RedirectToAction("Details", "Order", new { id = dbT.Order.OrderID });
        }

        // GET: Ticket/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order detail to delete!" });
            }

            Ticket ticket = await _context.Ticket
                .Include(r => r.Order)
                .FirstOrDefaultAsync(r => r.TicketID == id);

            if (ticket == null)
            {
                return View("Error", new String[] { "This order detail was not in the database!" });
            }

            return View(ticket);
        }

        // POST: Ticket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Ticket ticket = await _context.Ticket
                .Include(r => r.Order)
                .FirstOrDefaultAsync(r => r.TicketID == id);

            _context.Ticket.Remove(ticket);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Orders", new { id = ticket.Order.OrderID });
        }

        private bool TicketExists(int id)
        {
            return _context.Ticket.Any(e => e.TicketID == id);
        }
    }
}
