using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Attendence_Leave.Models
{
    public class LeavesClass
    {
        [Required]
        public List<String> Typeofleave = new List<string>
        {
            "Previledge leave","Meternity Leave","Sick leave"
        };

        [Required]
        [DataType(DataType.Date)]
        public DateTime From_date { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime To_date { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employeeclass EmployeeID { get; set; }


    }
}