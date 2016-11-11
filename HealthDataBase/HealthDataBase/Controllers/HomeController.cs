using HealthDataBase.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HealthDataBase.Controllers
{
    public class HomeController : Controller
    {
        private List<illness> _list;
        private List<users> _userList;
        MainManager MManger;
       public HomeController()
        {
            MManger = new MainManager();
            _list = MManger.populateList();
            _userList = MManger.populateUser();

        }
       
        // GET: Home
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult auto(string Prefix)
       {
            var symptom = MManger.symptom(Prefix).ToList();
            return Json(symptom, JsonRequestBehavior.AllowGet);
    
        }
       
    
       
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult NearByClinics()
        {
            return View();
        }
        public ActionResult Search(string _txtSearch)
        {
           
            if (string.IsNullOrEmpty(_txtSearch))
            {
                return View("Result");
            }
            else
            {
                return View("Result",MManger.Search(i=>i.symptomArray.Contains(_txtSearch)));
            }

            
        }
        [HttpPost]
        public ViewResult SignUp(users user)
        {
            user.userType = TypeOfUsers.user;
            return View(user);
        }
        [HttpPost]
        public ViewResult LogIn(users user)
        {
            foreach(users i in _userList)
            {
                if(i.username == user.username && i.password == user.password)
                {
                    return View(i);
                }
            }
            return View();
        }
    }
}