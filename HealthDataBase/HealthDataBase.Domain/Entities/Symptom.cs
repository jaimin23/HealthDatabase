using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    /// <summary>
    /// Fahad Mirza
    /// Gets symptoms from symptom table
    /// </summary>
    public class Symptom
    {
       [Key]
        public string IllnessSymptoms { get; set; }

        public void Change(Symptom sym)
        {
            this.IllnessSymptoms = sym.IllnessSymptoms;
        }
    }
}
