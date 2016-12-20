using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    /// <summary>
    /// Fahad Mirza
    /// This class creates the illnessese with 
    /// the following properties
    /// IllnessId, Name, treatment, Symptoms, Priority and a change method which will be used for updating the illness information
    /// </summary>
    public enum TypeOfPriority: byte
    {
        
        Low = 1,
        High
    }
   public class illness
    {
        public int IllnessId { get; set; }
        public string Name { get; set; }
        public string treatment { get; set; }
        public string Symptoms { get; set; }
        public TypeOfPriority Priority { get; set; }

        public void Change(illness ill)
        {
            this.Name = ill.Name;
            this.treatment = ill.treatment;
            this.Symptoms = ill.Symptoms;
            this.Priority = ill.Priority;
        }
    }
}
