using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Persistence
{
    public class MainManager
    {
        private List<illness> _illList;
        private List<users> _users;
        public MainManager()
        {
            _illList = new List<illness>();
            _users = new List<users>();
        }

        public List<illness> populateList()
        {
            //this method will get data from sql database to popluate the list dynamically
           

            illness item = new illness();
            item.Name = "flu";
            item.treatment = "drink warm soup/ use tynol";
            item.priority = "4";
            item.symptomArray = new List<string>();
            item.symptomArray.Add("Headache");
            item.symptomArray.Add("coughs");
            _illList.Add(item);

            return _illList;
        }
        public List<users> populateUser()
        {
            users newUser = new users();
            newUser.FirstName = "Fahad";
            newUser.LastName = "Mirza";
            newUser.EmailAddress = "mizra.fahad@gmail.com";
            newUser.PhoneNumber = "9075996059";
            newUser.username = "mirza1";
            newUser.password = "mirza1";
            _users.Add(newUser);

            return _users;
        }

        public illness Search(string _txtSearch)
        {
            
            foreach (illness item in _illList)
            {
                foreach (string i in item.symptomArray)
                {
                    if (_txtSearch == i)
                    {
                        return item; 
                    }
                }
            }
            return null;
        }
    }
}
