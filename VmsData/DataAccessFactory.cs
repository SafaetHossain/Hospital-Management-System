using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VmsData
{
    public abstract class DataAccessFactory
    {
        public static IDoctorDataAccess GetDoctorDataAccess()
        {
            return new DoctorDataAccess(new VmsDBContext());
        }

        public static IPatientDataAccess GetPatientDataAccess()
        {
            return new PatientDataAccess(new VmsDBContext());
        }

        public static IUserDataAccess GetUserDataAccess()
        {
            return new UserDataAccess(new VmsDBContext());
        }

        public static IMedicineDataAccess GetMedicineDataAccess()
        {
            return new MedicineDataAccess(new VmsDBContext());
        }
    }
}
