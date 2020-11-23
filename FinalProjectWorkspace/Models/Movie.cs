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
        Unrated,
        NC17
    }

    public class Movie
    {
        //Scalar properties

        public Int32 MovieID { get; set; } 

        public int MovieNumber { get; set; } //from 3001!

        [Required(ErrorMessage = "Movie Title is required!")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Movie Overview is required!")]
        public String Overview { get; set; }
        public String Tagline { get; set; }

       
        [Display(Name = "Run Time")]
        [Required(ErrorMessage = "Movie Run Time is required!")]
        public Double RunTime { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Movie Release Date is required!")]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Year { get; set; } //reflect this change on Balsamiq model
        public Decimal Revenue { get; set; } //Add this to model

        [Required(ErrorMessage = "At least one actor is required!")]
        public String Actors { get; set; }

        [Display(Name = "MPAA Rating")]
        [Required(ErrorMessage = "MPAA Rating is required!")]
        public MPAARatings MPAARating { get; set; } //As enum above

        [NotMapped]
        public DateTime ShowingSortOrder
        {
            get
            {
                if (Showings.Count() == 0)
                {
                    return new DateTime(2100, 1, 1);
                } else
                {
                    if (Showings.Max(s => s.StartTime).Date < DateTime.Now)
                    {
                        return new DateTime(2100, 1, 1);
                    } 
                    return Showings.Min(s => s.StartTime).Date;
                }
            }
        }

        //TODO: Uncomment this when you work on ratings/reviews
        //[Display(Name = "Average Review Rating")]
        //[DisplayFormat(DataFormatString = "{0:C",NullDisplayText = "No Ratings Yet")]
        //public Double? AverageReviewRating
        //{
          //  get { return MovieReviews.Average(mr => mr.Rating); }
        //}

        //Navigational properties
        [Display(Name = "Genre")]
        //[Required(ErrorMessage = "Genre is required!")]
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
