using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
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
