using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HmsEntity;

namespace HmsData
{
    public interface IMedicineDataAccess
    {
        IEnumerable<Medicine> GetAll();
        Medicine GetByName(string name);
        int Insert(Medicine medicine);
        int Update(Medicine medicine);
        int Delete(int id);
    }
}
