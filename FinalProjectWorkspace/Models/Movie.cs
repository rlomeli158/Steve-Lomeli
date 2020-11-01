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
        //Scalar properties
        public Int32 MovieID { get; set; } //from 3001!
        public String Title { get; set; }
        public String Overview { get; set; }
        public String Tagline { get; set; }
        public Decimal RunTime { get; set; }
        public DateTime Year { get; set; } //reflect this change on Balsamiq model
        public Decimal Revenue { get; set; } //Add this to model
        public String Actors { get; set; }
        public MPAARatings MPAARating { get; set; } //As enum above

        //Navigational properties
        public Genre Genre { get; set; }
        public List<Showing> Showings { get; set; }
        public List<MovieReview> MovieReviews { get; set; }

        public Movie()
        {
            if (Showings == null)
            {
                Showings = new List<Showing>();
            }

            /*
             * Do we have to add a similar thing as above but for movie review?
             */

        }

    }
}
