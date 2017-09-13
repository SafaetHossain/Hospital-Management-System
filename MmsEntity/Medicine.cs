using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmsEntity
{
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }
        [Required(ErrorMessage ="Medicine Name is Required")]
        public string MedicineName { get; set; }
        public IEnumerable<Medicine> Medicines { get; set; }
    }
}
