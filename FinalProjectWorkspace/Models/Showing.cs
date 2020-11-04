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

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public String Theatre { get; set; }

        public Int32 SeatsAvailable { get; set; } // You take the difference of all seats and seats purchased
        public Boolean SpecialEvent { get; set; }

        public Movie Movie { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
