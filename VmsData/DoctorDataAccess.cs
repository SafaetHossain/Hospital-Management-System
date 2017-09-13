using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VmsEntity;

namespace VmsData
{
    class DoctorDataAccess : IDoctorDataAccess
    {
        private VmsDBContext context;
        public DoctorDataAccess(VmsDBContext context)
        {
            this.context = context;
        }
        public IEnumerable<Doctor> GetAll(bool includeUser = false)
        {
            if (includeUser)
            {
                return this.context.Doctors.Include("User").ToList();
            }else
            {
                return this.context.Doctors.ToList();
            }
        }

        public Doctor GetByContact(string contact, bool includeUser = false)
        {
            if (includeUser)
            {
                return this.context.Doctors.Include("User").SingleOrDefault(x => x.Contact == contact);
            }else{
                return this.context.Doctors.SingleOrDefault(x => x.Contact == contact);
            }
        }

        public Doctor GetByExpartArea(string expartArea, bool includeUser = false)
        {
            if (includeUser)
            {
                return this.context.Doctors.Include("User").SingleOrDefault(x => x.ExpartArea == expartArea);
            }else
            {
                return this.context.Doctors.SingleOrDefault(x => x.ExpartArea == expartArea);
            }
        }

        public Doctor GetByName(string name, bool includeUser = false)
        {
            if (includeUser)
            {
                return this.context.Doctors.Include("User").SingleOrDefault(x => x.FirstName == name);
            }else
            {
                return this.context.Doctors.SingleOrDefault(x => x.FirstName == name);
            }
        }

        public int Insert(Doctor doctor)
        {
            this.context.Doctors.Add(doctor);

            return this.context.SaveChanges();
        }

        public int Update(Doctor doctor)
        {
            Doctor doc = this.context.Doctors.SingleOrDefault(x => x.Contact == doctor.Contact);
            doc.FirstName = doctor.FirstName;
            doc.LastName = doctor.LastName;
            doc.Qulification = doctor.Qulification;
            doc.ExpartArea = doctor.ExpartArea;
            doc.Address = doctor.Address;
            doc.Email = doctor.Email;

            return this.context.SaveChanges();
        }

        public int UpdatePassword(Doctor doctor)
        {
            Doctor doc = this.context.Doctors.SingleOrDefault(x => x.Contact == doctor.Contact);
            doc.Password = doctor.Password;

            return this.context.SaveChanges();
        }

        public int Delete(string contact)
        {
            Doctor doc = this.context.Doctors.SingleOrDefault(x => x.Contact == contact);
            this.context.Doctors.Remove(doc);

            return this.context.SaveChanges();
        }
    }
}
