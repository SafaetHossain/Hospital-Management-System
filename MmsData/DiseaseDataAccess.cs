using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmsEntity;

namespace MmsData
{
    class DiseaseDataAccess : IDiseaseDataAccess
    {
        private MmsDBContext context;
        public DiseaseDataAccess(MmsDBContext context)
        {
            this.context = context;
        }
        public IEnumerable<Disease> GetAll(bool IncludeMedicine = false)
        {
            if (IncludeMedicine)
            {
                return this.context.Diseases.Include("Medicine").ToList();
            }else
            {
                return this.context.Diseases.ToList();
            }
        }

        public Disease GetByName(string name, bool IncludeMedicine = false)
        {
            if (IncludeMedicine)
            {
                return this.context.Diseases.Include("Medicine").SingleOrDefault(x => x.DiseaseName == name);
            }else
            {
                return this.context.Diseases.SingleOrDefault(x => x.DiseaseName == name);
            }
        }

        public int Insert(Disease disease)
        {
            throw new NotImplementedException();
        }

        public int Update(Disease disease)
        {
            throw new NotImplementedException();
        }
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
