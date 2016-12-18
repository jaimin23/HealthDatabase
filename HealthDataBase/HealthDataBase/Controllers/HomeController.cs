using HealthDataBase.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HealthDataBase.Controllers
{
    public class HomeController : Controller
    {
        private List<illness> _list;
        private IUserRepository _user;
        MainManager MManger;
       public HomeController(IUserRepository user)
        {
            MManger = new MainManager();
            _list = MManger.populateList();
            _user = user;

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
                return View("Result",MManger.Search(i=>i.Symptoms.Contains(_txtSearch)));
            }

            
        }
        [HttpPost]
        public ActionResult SignUp(users user)
        {
            if(user != null)
            {
                user.UserType = TypeOfUsers.User;
                _user.SaveUser(user);

            }
            return View("SignUp",user);
        }
        [HttpPost]
        public ActionResult LogIn(string username, string password)
        {
            foreach(users user in _user.UserList)
            {
                if(user.UserName == username)
                {
                    if(user.UserPassword == password)
                    {
                        if (user.UserType == TypeOfUsers.User)
                        {
                            Session["User"] = user;
                            Session["UserName"] = user.FirstName;
                            Session["LoginState"] = true;
                            return RedirectToAction("UserHome", "User");
                        }
                        else if (user.UserType == TypeOfUsers.Doctor)
                        {
                            Session["User"] = user;
                            Session["DocName"] = user.FirstName;
                            Session["LoginState"] = true;
                            return RedirectToAction("DoctorHome", "Doctor");
                        }
                        else if (user.UserType == TypeOfUsers.Admin)
                        {
                            Session["User"] = user;
                            Session["AdminName"] = user.FirstName;
                            Session["LoginState"] = true;
                            return RedirectToAction("AdminHome", "Admin");
                        }
                    }
                    else
                    {
                        ViewBag.error = "Password is incorrect or not found";
                    }
                }
                ViewBag.error = "User name is incorrect or not found";
            }
            return View();
        }
    }
}