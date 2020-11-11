using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    //Should be individual tickets
    public class Ticket
    {
        public Int32 TicketID { get; set; }

        public Decimal TicketPrice { get; set; }
        public Decimal DiscountAmount { get; set; } //This is how you set a field as nullable, right? Because
                                                     //some people won't have discounts?
        public Decimal TotalCost { get; set; }

        //Seats purchased
        public String SeatNumber { get; set; } //The strings (seat row & numbers)

        public Decimal TransactionPopcornPoints { get; set; }

        public Order Order { get; set; }
        public Showing Showing { get; set; }


    }
}
