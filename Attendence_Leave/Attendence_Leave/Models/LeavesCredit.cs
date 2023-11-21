using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Attendence_Leave.Models
{
    public class LeavesCredit
    {
        [Key]
        public int LeaveCredit { get; set; }

        [ForeignKey("EmplyoeeID")]
        public virtual Employeeclass EmplyoeeID { get; set; }


    }
}