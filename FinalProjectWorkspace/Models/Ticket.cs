using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public class Ticket
    {
        public Int32 TicketID { get; set; }
        public Int32 NumberOfTickets { get; set; }

        public Decimal TicketPrice { get; set; }
        public Decimal? DiscountAmount { get; set; } //This is how you set a field as nullable, right? Because
                                                     //some people won't have discounts?
        public Decimal TotalCost { get; set; }

        //Seats purchased
        public List<String> Seats { get; set; } //Take in a list of strings (seat row & numbers)

        public Decimal TransactionPopcornPoints { get; set; }

        //These two are nullable because some people won't gift tickets, they'll just buy for themselves
        public Boolean? Gifted { get; set; }
        public String GiftRecipient { get; set; } //why does it give that green mark?


        public Order Order { get; set; }
        public Showing Showing { get; set; }


    }
}
