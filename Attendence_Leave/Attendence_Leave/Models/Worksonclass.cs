using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendence_Leave.Models
{
    public class Worksonclass
    {
        [ForeignKey("ProjectID")]
        public virtual ProjectClass ProjectID { get; set; }
        [ForeignKey("EmplyoeeID")]
        public virtual Employeeclass EmplyoeeID { get; set; }
        [ForeignKey("ManagerID")]
        public virtual Employeeclass MangerID { get; set; }
        
    }
}