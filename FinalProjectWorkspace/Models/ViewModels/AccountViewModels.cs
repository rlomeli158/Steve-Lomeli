using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

//TODO: Change this namespace to match your project
namespace FinalProjectWorkspace.Models
{ 
    //NOTE: This is the view model used to allow the user to login
    //The user only needs teh email and password to login
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    //NOTE: This is the view model used to register a user
    //When the user registers, they only need to specify the
    //properties listed in this model
    public class RegisterViewModel
    {   
        //NOTE: Here is the property for email
        [Required(ErrorMessage = "Please enter your address!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //NOTE: Here is the property for phone number
        [Required(ErrorMessage = "Please enter your phone number!")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        //TODO: Add any fields that you need for creating a new user
        //First name is provided as an example
        [Required(ErrorMessage = "Please enter your first name!")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your middle initial!")]
        [Display(Name = "Middle Initial")]
        public String MiddleInitial { get; set; }

        [Required(ErrorMessage = "Please enter your last name!")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

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

        //NOTE: Here is the logic for putting in a password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Enter user employee type")]
        [Required(ErrorMessage = "Please select the employee type!")]
        public String EmpType { get; set; }
    }

    //NOTE: This is the view model used to allow the user to 
    //change their password
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }   

    //NOTE: This is the view model used to display basic user information
    //on the index page
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String UserID { get; set; }
        public String FirstName { get; set; }
        public String MiddleInitial { get; set; }
        public String LastName { get; set; }
        public String Address { get; set;}
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
        public DateTime Birthday { get; set; }
        public Int32 PCPBalance { get; set; }
    }
}
