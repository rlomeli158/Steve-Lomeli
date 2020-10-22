using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FinalProjectWorkspace.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }

        /* In case we need full name
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }
        */
    }
}
