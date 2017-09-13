using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmsEntity
{
    public class Patient
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
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Password { get; set; }
        [Key, Required(ErrorMessage = "This field cannot be empty")]
        public string Contact { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
