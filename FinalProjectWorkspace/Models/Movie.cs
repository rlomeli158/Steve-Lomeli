using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        Unrated
    }

    public class Movie
    {
        //Scalar properties

        public Int32 MovieID { get; set; } //from 3001!

        public int MovieNumber { get; set; }
        public String Title { get; set; }
        public String Overview { get; set; }
        public String Tagline { get; set; }
        public Double RunTime { get; set; }
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

            if (MovieReviews == null)
            {
                MovieReviews = new List<MovieReview>();
            }

        }

    }
}
