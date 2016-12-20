using HealthDataBase.Domain.Entities;
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
    public class MainManager:IMainManager
    {
        private IillnessInterface _illRepo;
        private ISymptomR _symRepo;
       public MainManager(IillnessInterface illRepo, ISymptomR symRepo) 
        {
            _illRepo = illRepo;
            _symRepo = symRepo;
        }
        

       
       
        public IEnumerable<Symptom> symptom(string prefix)
        {
            foreach(Symptom i in _symRepo.SymptomTable )
            {
                if (i.IllnessSymptoms.StartsWith(prefix))
                {
                     yield return i;
                }
            }
            
            
        }
       public IEnumerable<illness> Search(string symptom)
        {
            foreach(illness i in _illRepo.illnessTable)
            {
                if (i.Symptoms.Contains(symptom))
                {
                    yield return i;
                }
               
            }
        }
       
    }
}
