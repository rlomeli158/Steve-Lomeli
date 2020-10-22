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

        public Order Order { get; set; }
        public Movie Movie { get; set; }


    }
}
