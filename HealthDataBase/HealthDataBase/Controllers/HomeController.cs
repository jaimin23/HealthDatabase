using HealthDataBase.Domain.Entities;
using HealthDataBase.Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public ViewResult Search(string _txtSearch)
        {
            foreach(string i in MManger.Search(_txtSearch).symptomArray)
            {
                if(_txtSearch == i)
                {
                    return View("result",MManger.Search(_txtSearch));
                }
            }
            return View();
        }
        [HttpPost]
        public ViewResult SignUp(users user)
        {
            
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