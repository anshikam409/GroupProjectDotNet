using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.Models;
using MyProject.Models.Repository;

namespace MyProject.Controllers
{
    public class ManagerLeaveController : Controller
    {
        IRepository<ManagerLeave> Managerleave = null;
        public ManagerLeaveController()
        {
            Managerleave = new Repository<ManagerLeave>();
        }
        // GET: ManagerLeave
        public ActionResult ManagerLeaveIndex()
        {
            return View();
        }

        public ActionResult ManagerApplyLeave()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ManagerApplyLeave(ManagerLeave leave)
        {
            if (ModelState.IsValid)
            {
                Managerleave.Insert(leave);
                Managerleave.Save();
                return RedirectToAction("ManagerLeaveIndex");
            }
            return View(leave);
        }
    }
}