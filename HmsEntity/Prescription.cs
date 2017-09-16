using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmsEntity
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        [Required(ErrorMessage = "PrescriptionDetails is required")]
        public string PrescriptionDetails { get; set; }

        public int PatientContact { get; set; }
        [ForeignKey("PatientContact")]
        public Patient Patient { get; set; }
        public int DoctorContact { get; set; }
        [ForeignKey("DoctorContact")]
        public Doctor Doctor { get; set; }
        public int MedicineId { get; set; }
        [ForeignKey("MedicineId")]
        public Medicine Medicine { get; set; }
    }
}
