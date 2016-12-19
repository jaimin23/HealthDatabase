using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthDataBase.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepo;
        private users user;
        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
            user = new users();
        }
        // GET: User
        public ActionResult UserHome()
        {
            return View();
        }

        public ActionResult ChangeEmail(string Email)
        {
            user = Session["User"] as users;
            user.EmailAddress = Email;
            _userRepo.SaveUser(user);
            return View("UserHome");
        }

        public ActionResult ChangePassword(string Password)
        {
            user = Session["User"] as users;
            user.UserPassword = Password;
            _userRepo.SaveUser(user);
            return View("UserHome");
        }
        public ActionResult ChangePhone(string PhoneNumber)
        {
            user = Session["User"] as users;
                user.PhoneNumber = PhoneNumber;
            _userRepo.SaveUser(user);
            return View("UserHome");
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index","Home");
        }
    }
}