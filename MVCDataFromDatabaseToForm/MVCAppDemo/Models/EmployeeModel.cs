using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAppDemo.Models
{
    public class EmployeeModel
    {
        /*
        AMYCN1 Step 1-->Added new SQL data project Step 2--> DataLibrary project, Step 3--> then add new class under Models
        For Employee to setup a new account
        goes to Controllers to create a new Action
        This is the Sign Up form on the website
        */


        [Display(Name = "Employee ID")]     //Form Display to the end user
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid EmployeeId")] //Range = Form Validation Check
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]      //Form Display to the end user
        [Required(ErrorMessage = "Please enter your first name.")]  //Range = Form Validation Check
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]       //Form Display to the end user
        [Required(ErrorMessage = "Please enter your last name.")]   //Range = Form Validation Check
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]   //validate email address format
        [Display(Name = "Email Address")]       //Form Display to the end user, not required filed
        [Required(ErrorMessage = "You need to give us your email address")]   //Range = Form Validation Check
        public string EmailAddress { get; set; }


        [Display(Name = "Confirm Email")]       //Confirm the email address are match with the required field
        [Compare("EmailAddress", ErrorMessage = "The Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]        //Dispay layout on the website
        [Required(ErrorMessage = "You must have a password")]  //required field
        [DataType((DataType.Password))]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "You need to provide a long password, minimum 10 character")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password not match, please try again.")]
        public string ConfirmPassword { get; set; }

    }
}