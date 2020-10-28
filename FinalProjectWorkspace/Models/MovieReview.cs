using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public class MovieReview
    {
        public Int32 MovieReviewID { get; set; }
        public DateTime ReviewDate { get; set; }
        public Boolean ApprovalStatus { get; set; }
        public Int32 Rating { get; set; }
        public String ReviewDescription { get; set; }

        public Movie Movie { get; set; }
        public AppUser User { get; set; }
    }
}
