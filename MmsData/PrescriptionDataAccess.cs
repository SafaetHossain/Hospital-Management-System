
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmsEntity;

namespace MmsData
{
    class PrescriptionDataAccess:IPrescriptionDataAccess
    {
        private MmsDBContext context;
        public PrescriptionDataAccess(MmsDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Prescription> GetAll( bool IncludeDoctor = false)
        {
            if (IncludeDoctor)
            {
                return this.context.Prescriptions.Include("Doctor").Include("Medicine").ToList();
            }else
            {
                return this.context.Prescriptions.ToList();
            }
        }

        public int Insert(Prescription prescription)
        {
            this.context.Prescriptions.Add(prescription);

            return this.context.SaveChanges();
        }

        public int Update(Prescription prescription)
        {
            Prescription pre = this.context.Prescriptions.SingleOrDefault(x => x.MedicineId == prescription.PrescriptionId);
            pre.PrescriptionDetails = prescription.PrescriptionDetails;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Prescription pre = this.context.Prescriptions.SingleOrDefault(x => x.MedicineId == id);
            this.context.Prescriptions.Remove(pre);

            return this.context.SaveChanges();
        }
    }
}
