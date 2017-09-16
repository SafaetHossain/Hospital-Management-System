using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmsEntity
{
    public class Disease
    {
        public int DiseaseId { get; set; }
        [Required(ErrorMessage = "Disease Name is Required")]
        public string DiseaseName { get; set; }
        public int MedicineId { get; set; }
        [ForeignKey("MedicineId")]
        public Medicine Medicine { get; set; }
    }
}