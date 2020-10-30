using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public enum AllGenres
    {
        Comedy,
        Horror,
        Documentary
    }

    public enum AllMPAARatings
    {
        G,
        PG,
        PG13,
        R,
        NR,
    }

    public enum AllSearchTypes
    {
        [Display(Name = "Greater Than")]
        GreaterThan,
        [Display(Name = "Less Than")]
        LessThan
    }

    public class SearchViewModel
    {
        [Display(Name = "Search by Title:")]
        public String SelectedTitle { get; set; } //Textbox

        [Display(Name = "Search by Tagline:")]
        public String SelectedTagline { get; set; } //Textbox

        [Display(Name = "Search by Genre:")]
        public Int32 SelectedGenre { get; set; } //Dropdown

        [Display(Name = "Search by Year:")]
        public Int32 SelectedYear { get; set; } //Textbox, verify it's a year (similar to salary) Should we use Int32 or String?

        [Display(Name = "Search by MPAA Rating:")]
        public Int32 SelectedMPAARating { get; set; } //Dropdown

        [Display(Name = "Search by Customer Rating:")]
        public Decimal SelectedCustomerRating { get; set; } //Number Input

        [Display(Name = "Search Type:")]
        public AllSearchTypes SelectedSearchType { get; set; } //Radio Button

        [Display(Name = "Search by Showing Date:")]
        public DateTime SelectedShowingDate { get; set; } //Date selector

    }
}
