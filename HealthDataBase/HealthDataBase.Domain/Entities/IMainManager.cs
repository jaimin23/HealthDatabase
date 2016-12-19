using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
   public interface IMainManager
    {
        IEnumerable<Symptom> symptom(string prefix);
        IEnumerable<illness> Search(string symptom);
    }
}
