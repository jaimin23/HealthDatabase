using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthDataBase.Controllers
{
    public class HomeController : Controller
    {
       
        List<illness> illnessList;
        public HomeController()
        {
            illnessList = new List<illness>();
            illness item = new illness();
            item.Name = "flu";
            item.treatment = "drink warm soup/ use tynol";
            item.priority = "4";
            item.symptomArray = new List<string>();
            item.symptomArray.Add("Heahache");
            item.symptomArray.Add("coughs");
            illnessList.Add(item);
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Search(string _txtSearch)
        {
            string work = "";
            foreach( illness item in illnessList){
                foreach (string i in item.symptomArray){
                    if(_txtSearch == i)
                    {
                        work= "works";
                    }
                }
            }
            return View(work);
        }
        public ViewResult SignUp(users user)
        {
            
            return View(user);
        }
    }
}