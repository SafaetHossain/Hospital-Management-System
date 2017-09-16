using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmsData
{
    public abstract class DataAccessFactory
    {
        public static IDoctorDataAccess GetDoctorDataAccess()
        {
            return new DoctorDataAccess(new HmsDBContext());
        }

        public static IPatientDataAccess GetPatientDataAccess()
        {
            return new PatientDataAccess(new HmsDBContext());
        }

        public static IUserDataAccess GetUserDataAccess()
        {
            return new UserDataAccess(new HmsDBContext());
        }

        public static IMedicineDataAccess GetMedicineDataAccess()
        {
            return new MedicineDataAccess(new HmsDBContext());
        }

        public static IDiseaseDataAccess GetDiseaseDataAccess()
        {
            return new DiseaseDataAccess(new HmsDBContext());
        }
        public static IPrescriptionDataAccess GetPrescriptionDataAccess()
        {
            return new PrescriptionDataAccess(new HmsDBContext());
        }
    }
}
