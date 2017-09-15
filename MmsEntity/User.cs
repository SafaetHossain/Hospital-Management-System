using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmsEntity
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Contact is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required]
        public string UserType { get; set; }
        public string ImagePath { get; set; }

        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
    }
}
