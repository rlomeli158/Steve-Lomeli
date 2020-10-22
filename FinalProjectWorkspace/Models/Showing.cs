using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public class Showing
    {
        public Int32 ShowingID { get; set; }
        public DateTime ShowingDate { get; set; }

        public List<String> SeatsAvailable { get; set; } // You take the difference of all seats and seats purchased

        public Movie Movie { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
