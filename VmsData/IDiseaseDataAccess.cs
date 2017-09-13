using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VmsEntity;

namespace VmsData
{
    public interface IDiseaseDataAccess
    {
        IEnumerable<Disease> GetAll(bool IncludeMedicine = false);
        Disease GetByName(string name, bool IncludeMedicine = false);
        int Insert(Disease disease);
        int Update(Disease disease);
        int Delete(int id);
    }
}
