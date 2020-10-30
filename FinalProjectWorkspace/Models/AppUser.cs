using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FinalProjectWorkspace.Models
{
    public class AppUser : IdentityUser
    {
        //User ID is inherited

        [Display(Name = "Enter user first name")]
        [Required(ErrorMessage ="Please enter your first name!")]
        public String FirstName { get; set; }

        [Display(Name = "Enter user a middle initial")]
        [Required(ErrorMessage = "Please enter your middle initial!")]
        public String MiddleInitial { get; set; }

        [Display(Name = "Enter user last name")]
        [Required(ErrorMessage = "Please enter your last name!")]
        public String LastName { get; set; }

        //phone numebr is inherited

        [Display(Name = "Enter user address")]
        [Required(ErrorMessage = "Please enter your address!")]
        public String Address { get; set; }

        [Display(Name = "Enter user city")]
        [Required(ErrorMessage = "Please enter your city!")]
        public String City { get; set; }

        [Display(Name = "Enter user state")]
        [Required(ErrorMessage = "Please enter your state!")]
        public String State { get; set; }

        [Display(Name = "Enter user Zip")]
        [Required(ErrorMessage = "Please enter your Zip!")]
        public String Zip { get; set; }

        [Display(Name = "Enter user birthday")]
        [Required(ErrorMessage = "Please enter your birthday!")]
        public DateTime Birthday { get; set; }

        //do not store password since it is inherited

        [Display(Name = "Popcorn Point Balance")]
        public Int32 PCPBalance { get; set; }

        [Display(Name = "Enter user SSN")]
        [Required(ErrorMessage = "Please enter your SSN!")]
        public String SSN { get; set; }

        [Display(Name = "Enter user employee type")]
        [Required(ErrorMessage = "Please select the employee type!")]
        public String EmpType { get; set; }

        public List<Order> Orders { get; set; }
        public List<MovieReview> MovieReviews { get; set; }
        public List<Ticket> Tickets { get; set; }


    }
    
}
