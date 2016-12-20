using HealthDataBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/// <summary>
/// Fahad Mirza
/// adds illness
/// shows illness 
/// edits illness
/// </summary>
namespace HealthDataBase.Controllers
{
    public class DoctorController : Controller
    {
        private IillnessInterface _illRepo;

        public DoctorController(IillnessInterface illRepo)
        {
            _illRepo = illRepo;
        }
        // GET: Doctor
        public ActionResult DoctorHome()
        {
            ViewBag.docName = Session["DocName"];
            return View();
        }

        public ActionResult IllnessView()
        {
            Session["illAuth"] = true;
            Session["illnessList"] = _illRepo.illnessTable;
            return View("IllnessView");
        }

        public ActionResult EditIllnessInfo(int IllnessId)
        {
            illness ill = _illRepo.illnessTable.FirstOrDefault(u => u.IllnessId == IllnessId);
            if (ill != null)
            {
                return View(ill);
            }
            return RedirectToAction("IllnessView");
        }
        [HttpGet]
        public ActionResult AddNewIllness()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewIllness(illness illness)
        {
            if (ModelState.IsValid)
            {
                _illRepo.saveIllness(illness);
            }
            return RedirectToAction("DoctorHome");
        }

        public ActionResult SaveIllness(illness illness)
        {
            if (ModelState.IsValid)
            {
                if (Request.Form["_btnSubmit"] == "Save Info")
                {
                    _illRepo.saveIllness(illness);
                }
                else if (Request.Form["_btnSubmit"] == "Delete Illness")
                {

                    _illRepo.DeleteIllness(illness.IllnessId);
                }
            }
            return RedirectToAction("IllnessView");
        }
    }
}