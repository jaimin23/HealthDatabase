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
            ViewBag.isAdmin = true;
            return View();
        }
        [HttpGet]
        public ActionResult AddNewUser()
        {
            ViewBag.isAdmin = true;
            return View();
        }
        [HttpPost]
        public ActionResult AddNewUser(users user)
        {
            if (ModelState.IsValid)
            {
                _userRepo.SaveUser(user);
            }
            return RedirectToAction("AdminHome");
        }
        public ActionResult ViewUsers()
        {
            ViewBag.isAdmin = true;
            return View(_userRepo.UserList);
        }
        [HttpGet]
        public ActionResult UpdateUserInfo()
        {
            ViewBag.isAdmin = true;
            return View();
        }
        [HttpPost]
        public ActionResult UpdateUserInfo(users user)
        {
            return RedirectToAction("AdminHome");
        }
    }
}