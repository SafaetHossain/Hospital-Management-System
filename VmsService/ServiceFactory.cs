using VmsEntity;
using VmsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VmsService
{
    public abstract class ServiceFactory
    {
        public static IDoctorService GetDoctorService()
        {
            return new DoctorService(DataAccessFactory.GetDoctorDataAccess());
        }

        public static IPatientService GetPatientService()
        {
            return new PatientService(DataAccessFactory.GetPatientDataAccess());
        }

        public static IUserService GetUserService()
        {
            return new UserService(DataAccessFactory.GetUserDataAccess());
        }

        public static IMedicineService GetMedicineService()
        {
            return new MedicineService(DataAccessFactory.GetMedicineDataAccess());
        }
    }
}
