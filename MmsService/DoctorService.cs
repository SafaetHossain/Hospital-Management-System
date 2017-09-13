using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmsEntity;
using MmsData;

namespace MmsService
{
    class DoctorService: IDoctorService
    {
        private IDoctorDataAccess data;
        public DoctorService(IDoctorDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Doctor>GetAll(bool includeUser = false)
        {
            return this.data.GetAll(includeUser);
            
        }

        public Doctor GetByContact(string contact, bool includeUser = false)
        {
            return this.data.GetByContact(contact, includeUser);
        }

        public Doctor GetByName(string name, bool includeUser = false)
        {
            return this.data.GetByName(name, includeUser);
        }

        public Doctor GetByExpartArea(string expartArea, bool includeUser = false)
        {
            return this.data.GetByExpartArea(expartArea,includeUser);
        }

        public int Insert(Doctor doctor)
        {
            return this.data.Insert(doctor);
        }

        public int Update(Doctor doctor)
        {
            return this.data.Update(doctor);
        }
        public int UpdatePassword(Doctor doctor)
        {
            return this.data.UpdatePassword(doctor);
        }
        public int Delete(string contact)
        {
            return this.data.Delete(contact);
        }
    }
}
