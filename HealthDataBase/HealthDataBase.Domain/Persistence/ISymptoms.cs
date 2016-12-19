using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Persistence
{
    public interface ISymptoms
    {
        IEnumerable<Symptom> SymptomTable { get; }

        void SaveSymptom(Symptom sym);
    }
}
