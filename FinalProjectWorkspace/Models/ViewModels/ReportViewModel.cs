using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectWorkspace.Models
{

    public class RevenueReportViewModel
    {
        

    }
    public class RevenueSearchViewModel
    {
        [Display(Name = "Search by Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedStartingDate { get; set; } 

        [Display(Name = "Search by Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedEndingDate { get; set; } 

        [Display(Name = "Search by Movie:")]
        public Int32 SelectedMovie { get; set; }

        [Display(Name = "Search by MPAA Rating:")]
        public Int32 SelectedMPAARating { get; set; } 

        [Display(Name = "Search by Time:")]
        [DataType(DataType.Time)]
        public DateTime? SelectedTime { get; set; }

        [Display(Name = "Search Type:")]
        public AllSearchTypes SelectedSearchType { get; set; }

    }
}
