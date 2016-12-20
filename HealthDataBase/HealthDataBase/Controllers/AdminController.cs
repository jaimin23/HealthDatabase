using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthDataBase.Controllers
{
    /// <summary>
    /// Jaimin Patel
    /// This contoller contains the actions an admin can perform 
    /// </summary>
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
            Session["UserName"] = ViewBag.adminName;
            ViewBag.isAdmin = true;
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
            if (ModelState.IsValid)
            {
                _userRepo.SaveUser(user);
            }
            return RedirectToAction("AdminHome");
        }
        public ActionResult ViewUsers()
        {
           Session["auth"] = true;
            Session["userList"] = _userRepo.UserList;
            return View("ViewUsers");
        }
        public ActionResult EditUserInfo(int userId)
        {
            users user = _userRepo.UserList.FirstOrDefault(u => u.UserId == userId);
            if(user != null)
            {
                return View(user);
            }
            return View("AdminHome");
        }

        public ActionResult SaveUser(users user)
        {
            if (ModelState.IsValid)
            {
                if(Request.Form["_btnSubmit"] == "Save Info")
                {
                    _userRepo.SaveUser(user);
                }
                else if(Request.Form["_btnSubmit"] == "Delete User")
                {
                    
                    _userRepo.DeleteUser(user.UserId);
                }
            }
            return RedirectToAction("ViewUsers");
        }
    }
}