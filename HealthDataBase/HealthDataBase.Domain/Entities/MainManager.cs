using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    public class MainManager
    {
        private List<illness> _illList;
        private List<string> sym;
        public MainManager()
        {
            _illList = new List<illness>();
            sym = new List<string>();
            sym.Add("Coughs");
            sym.Add("Headaches");
            sym.Add("Pain");
            sym.Add("something");
            sym.Add("Cheadache");
        }

        public List<illness> populateList()
        {
            //this method will get data from sql database to popluate the list dynamically
           

            illness item = new illness();
            item.Name = "flu";
            item.treatment = "drink warm soup/ use tynol";
            item.Priority = TypeOfPriority.High;
            //item.symptomArray = new List<string>();
            item.Symptoms = "Headache";
            item.Symptoms = "Coughs";
            _illList.Add(item);

            return _illList;
        }
       
        public IEnumerable<string> symptom(string prefix)
        {
            foreach(string i in sym )
            {
                if (i.StartsWith(prefix))
                {
                     yield return i;
                }
            }
            
            
        }
       public IEnumerable<illness> Search(Func<illness,bool>matchIllness)
        {
            foreach(illness i in _illList)
            {
                if (matchIllness(i))
                {
                    yield return i;
                }
            }
        }
       
    }
}
