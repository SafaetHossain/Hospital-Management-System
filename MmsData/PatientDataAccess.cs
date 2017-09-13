using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmsEntity;

namespace MmsData
{
    class PatientDataAccess : IPatientDataAccess
    {
        private MmsDBContext context;
        public PatientDataAccess(MmsDBContext context)
        {
            this.context = context;
        }
        public IEnumerable<Patient> GetAll(bool includeUser = false)
        {
            if (includeUser)
            {
                return this.context.Patients.Include("User").ToList();
            }else
            {
                return this.context.Patients.ToList();
            }
        }

        public Patient GetByContact(string contact, bool includeUser = false)
        {
            if (includeUser)
            {
                return this.context.Patients.Include("User").SingleOrDefault(x => x.Contact == contact);
            }else
            {
                return this.context.Patients.SingleOrDefault(x => x.Contact == contact);
            }
        }

        public Patient GetByName(string name, bool includeUser = false)
        {
            if (includeUser)
            {
                return this.context.Patients.Include("User").SingleOrDefault(x => x.FirstName == name);
            }else
            {
                return this.context.Patients.SingleOrDefault(x => x.FirstName == name);
            }
        }

        public int Insert(Patient patient)
        { 
            this.context.Patients.Add(patient);

            return this.context.SaveChanges();
        }

        public int Update(Patient patient)
        {
            Patient pat = this.context.Patients.SingleOrDefault(x => x.Contact == patient.Contact);
            pat.Address = patient.Address;
            pat.Height = patient.Height;
            pat.Weight = patient.Weight;

            return this.context.SaveChanges();
        }

        public int UpdatePassword(Patient patient)
        {
            Patient pat = this.context.Patients.SingleOrDefault(x => x.Contact == patient.Contact);
            pat.Password = patient.Password;

            return this.context.SaveChanges();
        }
        public int Delete(string contact)
        {
            Patient pat = this.context.Patients.SingleOrDefault(x => x.Contact == contact);
            this.context.Patients.Remove(pat);

            return this.context.SaveChanges();
        }
    }
}
