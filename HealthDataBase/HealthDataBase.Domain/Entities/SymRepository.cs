using HealthDataBase.Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    class SymRepository : ISymptomR
    {
        private ISymptoms _symRepo;

        public SymRepository(ISymptoms symRepo)
        {
            _symRepo = symRepo;
        }
        public IEnumerable<Symptom> SymptomTable
        {
            get
            {
                return _symRepo.SymptomTable;
            }
        }

        public void saveSymptom(Symptom sym)
        {
            _symRepo.SaveSymptom(sym);
        }
    }
}
