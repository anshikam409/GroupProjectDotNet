using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.Models;
using MyProject.Models.Repository;
using MyProject.Controllers;

namespace MyProject.Controllers
{
    public class LeaveController : Controller
    {
        // GET: Leave
        private IRepository<EmployeeLeaveRequest> db = null;
        public LeaveController()
        {
            db= new Repository<EmployeeLeaveRequest>();

        }

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ApplyLeave()

        {

            return View();

        }

        [HttpPost]

        public ActionResult ApplyLeave(EmployeeLeaveRequest leaveRequest)

        {

            // Additional validation and processing logic

            if (ModelState.IsValid)

            {

                leaveRequest.EmployeeId = 23; // set the current employee's id here

                leaveRequest.IsApproved = false; // Initial status

                 db.Insert(leaveRequest);

                 db.Save();

                return RedirectToAction("EmployeeDashboard", "Project");

            }

            return View(leaveRequest);

        }

        public ActionResult PendingLeaveApproval()

        {

            var pendingLeaveRequests = db.GetAll().Where(l => !l.IsApproved);

            return View(pendingLeaveRequests);

        }

        [HttpPost]

        public ActionResult ApproveLeave(int leaveRequestId)

        {

            var leaveRequest = db.GetById(leaveRequestId);

            if (leaveRequest != null)

            {

                leaveRequest.IsApproved = true;

                db.Update(leaveRequest);

                db.Save();

            }

            return RedirectToAction("PendingLeaveApproval");

        }

        [HttpPost]

        public ActionResult DeleteLeave(int leaveRequestId)

        {

            var leaveRequest = db.GetById(leaveRequestId);

            if (leaveRequest != null)

            {

                db.Delete(leaveRequestId);

                db.Save();

            }

            return RedirectToAction("PendingLeaveApproval");

        }

    }
    
}