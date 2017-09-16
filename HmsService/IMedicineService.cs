using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HmsEntity;

namespace HmsService
{
    public interface IMedicineService
    {
        IEnumerable<Medicine> GetAll();
        Medicine GetByName(string name);
        int Insert(Medicine medicine);
        int Update(Medicine medicine);
        int Delete(int id);
    }
}
