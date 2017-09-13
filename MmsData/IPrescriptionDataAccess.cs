using MmsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmsData
{
    public interface IPrescriptionDataAccess
    {
        IEnumerable<Prescription> GetAll(bool IncludeDoctor = false);
        int Insert(Prescription prescription);
        int Update(Prescription prescription);
        int Delete(int id);
    }
}
