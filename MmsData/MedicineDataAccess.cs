using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmsEntity;

namespace MmsData
{
    class MedicineDataAccess : IMedicineDataAccess
    {
        private MmsDBContext context;
        public MedicineDataAccess(MmsDBContext context)
        {
            this.context = context;
        }
        public IEnumerable<Medicine> GetAll()
        {
            return this.context.Medicines.ToList();
        }

        public Medicine GetByName(string name)
        {
            return this.context.Medicines.SingleOrDefault(x => x.MedicineName == name);
        }

        public int Insert(Medicine medicine)
        {
            this.context.Medicines.Add(medicine);

            return this.context.SaveChanges();
        }

        public int Update(Medicine medicine)
        {
            Medicine medi = this.context.Medicines.SingleOrDefault(x => x.MedicineId == medicine.MedicineId);
            medi.MedicineName = medicine.MedicineName;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Medicine medicine = this.context.Medicines.SingleOrDefault(x => x.MedicineId == id);
            this.context.Medicines.Remove(medicine);

            return this.context.SaveChanges();
        }
    }
}
