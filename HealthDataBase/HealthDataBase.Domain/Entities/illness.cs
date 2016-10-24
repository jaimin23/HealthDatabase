using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
   public class illness
    {
        public string Name { get; set; }
        public string treatment { get; set; }
        public List<String> symptomArray { get; set; }
        public string priority { get; set; }
    }
}
