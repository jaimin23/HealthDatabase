using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthDataBase.Domain.Entities;

namespace HealthDataBase.Domain.Persistence
{

    /// <summary>
    /// Fahad Mirza
    /// </summary>
    class SymptomRepository : ISymptoms
    {
        private HealthDbContext _dbContext;

        public SymptomRepository()
        {
            _dbContext = new HealthDbContext();
        }
        public IEnumerable<Symptom> SymptomTable
        {
            get
            {
                return _dbContext.symptoms;
            }
        }

        public void SaveSymptom(Symptom sym)
        {
            if(sym.IllnessSymptoms!=null)
            {
                _dbContext.symptoms.Add(sym);
            }
            else
            {
                Symptom symEntity = _dbContext.symptoms.Find(sym.IllnessSymptoms);
                sym.Change(sym);
            }
            _dbContext.SaveChanges();
        }
    }
}
