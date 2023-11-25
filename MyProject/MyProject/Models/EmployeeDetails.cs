using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class EmployeeDetails
    {
        
        public int EmpID { get; set; }
        [Key]
        public string Employeename { get; set; }
        public string Grade { get; set; }
        public string Designation { get; set; }
        public String Password { get; set; }
    }
}