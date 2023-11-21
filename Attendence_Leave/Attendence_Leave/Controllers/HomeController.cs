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
        public ActionResult EmployeeLogin(Employee model)
        {
            if (ModelState.IsValid)
            {
                // Validate employee credentials against the database
                if (IsValidEmployee(model.FullName, model.password))
                {
                    // Redirect to the employee dashboard or another page
                    return RedirectToAction("EmployeeDashboard",model);
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }

            return View(model);
        }

        // Employee dashboard or landing page after login

        public ActionResult EmployeeDashboard(Employee model)
        {
            ProjectContext db = new ProjectContext();
            
                // Assuming you have a table named Employee with columns Username and Password
               var employee = db.Employees.Find(model.EmployeeID);
               //if (employee != null)
               //{
                return View(employee);
               //}
               //else
               //{
               // return RedirectToAction("EmployeeLogin");
               //}
          
           
        }



        // Helper method to validate employee credentials
        private bool IsValidEmployee(string username, string password)
        {
            using (ProjectContext db = new ProjectContext())
            {
                // Assuming you have a table named Employee with columns Username and Password
                var employee = db.Employees.FirstOrDefault(e => e.FullName== username && e.password == password);
                return employee != null;
            }
        }

        public ActionResult ManagerLogin()
        {
            return View();
        }
    }
}

  
