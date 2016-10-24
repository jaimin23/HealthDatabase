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
        MainManager MManger;
       public HomeController()
        {
            MManger = new MainManager();
            _list = MManger.populateList();
        }
       
        // GET: Home
        public ActionResult Index()
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
        public ViewResult SignUp(users user)
        {
            
            return View(user);
        }
    }
}