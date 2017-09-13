using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VmsData;
using VmsEntity;

namespace VmsService
{
    class MedicineService : IMedicineService
    {
        private IMedicineDataAccess data;
        public MedicineService(IMedicineDataAccess data)
        {
            this.data = data;
        }
        public IEnumerable<Medicine> GetAll()
        {
            return this.data.GetAll();
        }

        public Medicine GetByName(string name)
        {
            return this.data.GetByName(name);
        }

        public int Insert(Medicine medicine)
        {
            return this.data.Insert(medicine);
        }

        public int Update(Medicine medicine)
        {
            return this.data.Update(medicine);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
