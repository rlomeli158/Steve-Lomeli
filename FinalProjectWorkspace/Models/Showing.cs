using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public enum Theatre
    {
        [Display(Name = "Theatre 1")]
        Theatre1,
        [Display(Name = "Theatre 2")]
        Theatre2
    }

    public class Showing
    {
        public Int32 ShowingID { get; set; }

        [Display(Name = "Showing Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ShowingDate { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime EndTime { get; set; }

        [Display(Name = "Theatre")]
        public Theatre Theatre { get; set; }

        List<string> allSeats = new List<string>()
             {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5"
             };

        [NotMapped]
        public List<string> SeatsAvailable { get; set; }

        //[Display(Name = "Seats Available")]
        //public Int32 SeatsAvailable { get; set; } // You take the difference of all seats and seats purchased

        public Boolean SpecialEvent { get; set; }

        public String Status { get; set; }

        public Movie Movie { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Showing()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }

        }
    }

}
