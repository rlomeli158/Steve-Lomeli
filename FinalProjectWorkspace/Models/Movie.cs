using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public enum MPAARatings
    {
        G,
        PG,
        PG13,
        R,
        NR
    }

    public class Movie
    {
        public Int32 MovieID { get; set; } //from 3001!
        public String Title { get; set; }
        public String Overview { get; set; }
        public String Tagline { get; set; }
        public Decimal RunTime { get; set; }
        public Int32 Year { get; set; }
        public Decimal CustomerRating { get; set; } //This will have to come from another model class, so it won't be decimal
        public Decimal Revenue { get; set; } //Add this to model
        public String Actors { get; set; }
        public MPAARatings MPAARating { get; set; } //As enum above

        public Genre Genre { get; set; }
        public List<Showing> Showings { get; set; }

        public Movie()
        {
            if (Showings == null)
            {
                Showings = new List<Showing>();
            }

        }

    }
}
