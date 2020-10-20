using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{

    public class Movie
    {
        //General Characteristics which will be on database, should be able to be searched by
        public Int32 MovieID { get; set; }
        public String Title { get; set; }
        public String Tagline { get; set; }
        public Genre Genre { get; set; }
        public Int32 Year { get; set; }
        public MPAARating MPAARating { get; set; }
        public Decimal RunTime { get; set; } //Shouldn't be able to search by Run Time, I think?

        //Will be edited on database
        public Decimal CustomerRating { get; set; }
        public Int32 SeatsAvailable { get; set; }
        public DateTime ShowingDate { get; set; }

    }
}
