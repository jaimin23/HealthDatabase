using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
   public interface ISymptomR
    {
       IEnumerable<Symptom> SymptomTable { get;}
        void saveSymptom(Symptom sym);
    }
}
