using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyProject.Models;
using MyProject.Models.Repository;

namespace MyProject.Controllers
{
    public class ManagerController : Controller
    {
        ProjectContext db = new ProjectContext();

        //--------------------Manager Timesheet-----------------------------
        // GET: Manager
        public ActionResult ManagerTimesheetIndex()
        {
            return View();

        }

        // GET: Timesheets/Create
        public ActionResult Addattendence()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Addattendence(ManagerTimesheet mngtimesheet)
        {
            if (ModelState.IsValid)
            {
                db.ManagerTimesheet.Add(mngtimesheet);
                db.SaveChanges();
                return RedirectToAction("ManagerTimeSheetIndex");
            }
            return View(mngtimesheet);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}