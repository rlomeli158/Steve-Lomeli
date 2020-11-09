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

        public Int32 MovieID { get; set; } 

        public int MovieNumber { get; set; } //from 3001!
        public String Title { get; set; }
        public String Overview { get; set; }
        public String Tagline { get; set; }

        [Display(Name = "Run Time")]
        public Double RunTime { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}")]
        public DateTime Year { get; set; } //reflect this change on Balsamiq model
        public Decimal Revenue { get; set; } //Add this to model
        public String Actors { get; set; }

        [Display(Name = "MPAA Rating")]
        public MPAARatings MPAARating { get; set; } //As enum above

        //Navigational properties
        [Display(Name = "Genre")]
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
