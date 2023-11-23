using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Models
{
    public class Timesheet
    {
        [Key]
        public int ProjectID { get; set; }
        public string Projectname { get; set; }
        public string task { get; set; }
        public DateTime Datenow { get; set; }
        public string category { get; set; }
        public int Hours { get; set; }
        public string remarks { get; set; }
    }
}