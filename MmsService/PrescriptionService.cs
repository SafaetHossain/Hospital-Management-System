using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmsEntity;
using MmsData;

namespace MmsService
{
    class PrescriptionService : IPrescriptionService
    {
        private IPrescriptionDataAccess data;
        public PrescriptionService(IPrescriptionDataAccess data)
        {
            this.data = data;
        }
        public IEnumerable<Prescription> GetAll(bool IncludeDoctor = false)
        {
            return this.data.GetAll(IncludeDoctor);
        }

        public int Insert(Prescription prescription)
        {
            return this.data.Insert(prescription);
        }

        public int Update(Prescription prescription)
        {
            return this.data.Update(prescription);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
