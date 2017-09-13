using MmsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmsData
{
    public interface IPatientDataAccess
    {
        IEnumerable<Patient> GetAll(bool includeUser = false);
        Patient GetByContact(string contact, bool includeUser = false);
        Patient GetByName(string name, bool includeUser = false);
        int Insert(Patient patient);
        int Update(Patient patient);
        int UpdatePassword(Patient patient);
        int Delete(string contact);
    }
}
