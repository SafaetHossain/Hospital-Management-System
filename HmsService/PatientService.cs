using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HmsData;
using HmsEntity;

namespace HmsService
{
    class PatientService : IPatientService
    {
        private IPatientDataAccess data;
        public PatientService(IPatientDataAccess data)
        {
            this.data = data;
        }
        public IEnumerable<Patient> GetAll(bool includeUser = false)
        {
            return this.data.GetAll(includeUser);
        }

        public Patient GetByContact(string contact, bool includeUser = false)
        {
            return this.data.GetByContact(contact, includeUser);
        }

        public Patient GetByName(string name, bool includeUser = false)
        {
            return this.data.GetByName(name, includeUser);
        }

        public int Insert(Patient patient)
        {
            return this.data.Insert(patient);
        }

        public int Update(Patient patient)
        {
            return this.Update(patient);
        }

        public int UpdatePassword(Patient patient)
        {
            return this.data.UpdatePassword(patient);
        }

        public int Delete(string contact)
        {
            return this.data.Delete(contact);
        }
    }
}
