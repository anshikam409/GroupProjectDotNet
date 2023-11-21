using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Attendence_Leave.Models;

namespace Attendence_Leave.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmployeeLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeLogin(EmployeeLogin model)
        {
            if (ModelState.IsValid)
            {
                // Validate employee credentials against the database
                if (IsValidEmployee(model.Username, model.Password))
                {
                    // Redirect to the employee dashboard or another page
                    return RedirectToAction("EmployeeDashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }

            return View(model);
        }

        // Employee dashboard or landing page after login

        public ActionResult EmployeeDashboard()
        {
            return View();
           
        }



        // Helper method to validate employee credentials
        private bool IsValidEmployee(string username, string password)
        {
            using (LoginEnity db = new LoginEnity())
            {
                // Assuming you have a table named Employee with columns Username and Password
                var employee = db.EmployeeLogins.FirstOrDefault(e => e.Username == username && e.Password == password);
                return employee != null;
            }
        }

        public ActionResult ManagerLogin()
        {
            return View();
        }
    }
}

  
