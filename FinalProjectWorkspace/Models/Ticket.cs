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
        public Decimal TotalCost { get; set; }

        //Seats purchased
        public List<String> Seats { get; set; } //Take in a list of strings (seat row & numbers)

        public Order Order { get; set; }
        public Showing Showing { get; set; }


    }
}
