using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HmsEntity;

namespace HmsData
{
    class DiseaseDataAccess : IDiseaseDataAccess
    {
        private HmsDBContext context;
        public DiseaseDataAccess(HmsDBContext context)
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
            this.context.Diseases.Add(disease);

            return this.context.SaveChanges();
        }

        public int Update(Disease disease)
        {
            Disease dis = this.context.Diseases.SingleOrDefault(x => x.DiseaseId == disease.DiseaseId);
            dis.DiseaseName = disease.DiseaseName;

            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            Disease disease = this.context.Diseases.SingleOrDefault(x => x.DiseaseId == id);
            this.context.Diseases.Remove(disease);

            return this.context.SaveChanges();
        }
    }
}
