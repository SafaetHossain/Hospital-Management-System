using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmsData
{
    public abstract class DataAccessFactory
    {
        public static IDoctorDataAccess GetDoctorDataAccess()
        {
            return new DoctorDataAccess(new MmsDBContext());
        }

        public static IPatientDataAccess GetPatientDataAccess()
        {
            return new PatientDataAccess(new MmsDBContext());
        }

        public static IUserDataAccess GetUserDataAccess()
        {
            return new UserDataAccess(new MmsDBContext());
        }

        public static IMedicineDataAccess GetMedicineDataAccess()
        {
            return new MedicineDataAccess(new MmsDBContext());
        }
    }
}
