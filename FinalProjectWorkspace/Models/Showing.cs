using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public enum Theatre
    {
        Theater1,
        Theater2
    }

    public class Showing
    {
        public Int32 ShowingID { get; set; }
        public DateTime ShowingDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Theatre Theatre { get; set; }

        public Int32 SeatsAvailable { get; set; } // You take the difference of all seats and seats purchased
        public Boolean SpecialEvent { get; set; }

        public Movie Movie { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
