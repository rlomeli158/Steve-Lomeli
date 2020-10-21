using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{

    public class Movie
    {
        public Int32 MovieID { get; set; }
        public String Title { get; set; }
        public String Overview { get; set; }
        public String Tagline { get; set; }
        public Decimal RunTime { get; set; }
        public Int32 Year { get; set; }
        public Decimal CustomerRating { get; set; }

        public Genre Genre { get; set; }
        public MPAARating MPAARating { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Showing> ShowingDates { get; set; } //Do we want this?

    }
}
