using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthDataBase.Controllers
{
    public class AdminController : Controller
    {
        private IUserRepository _userRepo;
        public AdminController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        // GET: Admin
        public ActionResult AdminHome()
        {
            Session["adminName"] = ViewBag.adminName;
            return View();
        }
        [HttpGet]
        public ActionResult AddNewUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewUser(users user)
        {
            return RedirectToAction("AdminHome");
        }
        public ActionResult ViewUsers()
        {
            return View(_userRepo.UserList);
        }
        [HttpGet]
        public ActionResult UpdateUserInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateUserInfo(users user)
        {
            return View();
        }
    }
}