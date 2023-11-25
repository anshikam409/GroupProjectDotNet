using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class ProjectDetails
    {
        [Key][Column(Order =0)]
        public int ProjectID { get; set; }
        [Key][Column(Order =1)]
        public string ProjectName { get; set; }
    }
}