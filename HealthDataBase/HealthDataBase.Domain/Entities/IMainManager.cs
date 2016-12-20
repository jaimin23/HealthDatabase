using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    /// <summary>
    /// Fahad Mirza
    /// searches for illness by symptom
    /// gets the symptom from symptom table for ajax
    /// </summary>
   public interface IMainManager
    {
        IEnumerable<Symptom> symptom(string prefix);
        IEnumerable<illness> Search(string symptom);
    }
}
