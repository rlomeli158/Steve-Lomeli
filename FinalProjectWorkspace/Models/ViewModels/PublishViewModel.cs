using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public class PublishViewModel
    {
        [Display(Name = "Select Day to Publish:")]
        [Required(ErrorMessage = "Please select a date to publish.")]
        [DataType(DataType.Date)]
        public DateTime? SelectedShowingDate { get; set; } //Date selector

        [Display(Name = "Select Theatre:")]
        [Required(ErrorMessage = "Please select a theater's schedule to publish.")]
        public Theatre SelectedTheatre { get; set; } //Enum

    }
}
