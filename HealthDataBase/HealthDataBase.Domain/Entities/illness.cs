using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    public enum TypeOfPriority: byte
    {
        High = 1,
        Low
    }
   public class illness
    {
        public int IllnessId { get; set; }
        public string Name { get; set; }
        public string treatment { get; set; }
        public string Symptoms { get; set; }
        public TypeOfPriority Priority { get; set; }
    }
}
