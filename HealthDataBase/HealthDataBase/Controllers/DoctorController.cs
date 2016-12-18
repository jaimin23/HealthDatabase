using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthDataBase.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult DoctorHome()
        {
            ViewBag.docName = Session["DocName"];
            return View();
        }
    }
}