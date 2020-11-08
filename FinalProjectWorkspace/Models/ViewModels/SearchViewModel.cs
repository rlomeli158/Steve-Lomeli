using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public enum AllGenres
    {
        Action,
        Adventure,
        Animation,
        Comedy,
        Crime,
        Drama,
        Family,
        Fantasy,
        Horror,
        Musical,
        Romance,
        [Display(Name = "Science Fiction")]
        ScienceFiction,
        Thriller,
        War,
        Western
        
    }

    public enum AllMPAARatings
    {
        G,
        PG,
        [Display(Name = "PG-13")]
        PG13,
        R,
        Unrated
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

        [Display(Name = "Search by Overview:")]
        public String SelectedOverview { get; set; } //Textbox

        [Display(Name = "Search by Genre:")]
        public Int32 SelectedGenreID { get; set; } //Dropdown

        [Display(Name = "Search by Year:")]
        public DateTime? SelectedYear { get; set; } //Textbox, verify it's a year (similar to salary) Should we use Int32 or String?

        [Display(Name = "Search by MPAA Rating:")]
        public Int32 SelectedMPAARating { get; set; } //Dropdown

        [Display(Name = "Search by Customer Rating:")]
        public String SelectedCustomerRating { get; set; } //Number Input

        [Display(Name = "Search Type:")]
        public AllSearchTypes SelectedSearchType { get; set; } //Radio Button

        [Display(Name = "Search by Showing Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedShowingDate { get; set; } //Date selector

    }
}
