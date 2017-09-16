using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HmsEntity;
using HmsData;

namespace HmsService
{
    class DiseaseService : IDiseaseService
    {
        private IDiseaseDataAccess data;
        public DiseaseService(IDiseaseDataAccess data)
        {
            this.data = data;
        }
        public IEnumerable<Disease> GetAll(bool IncludeMedicine = false)
        {
            return this.data.GetAll(IncludeMedicine);
        }

        public Disease GetByName(string name, bool IncludeMedicine = false)
        {
            return this.data.GetByName(name, IncludeMedicine);
        }

        public int Insert(Disease disease)
        {
            return this.data.Insert(disease);
        }

        public int Update(Disease disease)
        {
            return this.data.Update(disease);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
