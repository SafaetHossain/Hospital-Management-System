using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class PatientProfileModel
    {
        [Required(ErrorMessage = "This field cannot be empty")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Address { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string DOB { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Height { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Weight { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public int Age { get; set; }
        public string Email { get; set; }
        [Key, Required(ErrorMessage = "This field cannot be empty")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(6)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password required")]
        [CompareAttribute("Password", ErrorMessage = "Password doesn't match.")]
        public string ConfirmPassowrd { get; set; }
        [Required(ErrorMessage = "Image is required")]
        public string ImagePath { get; set; }
    }
}