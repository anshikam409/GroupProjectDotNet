using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendence_Leave.Models
{
    public class AttedenceClass
    {
        [ForeignKey("EmplyoeeID")]
        public virtual Employeeclass EmplyoeeID { get; set; }
        [ForeignKey("ProjectID")]
        public virtual ProjectClass ProjectID { get; set; }
        
    }
}