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
        public Int32 SeatsAvailable { get; set; }
        public Movie Movie { get; set; }

    }
}
