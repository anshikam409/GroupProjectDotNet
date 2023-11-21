using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendence_Leave.Models
{
    public class Employeeclass
    {
     
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string EmailID { get; set; }

        [Required]
        public string PhoneNo { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        [StringLength(2)]
        public string Grade { get; set; }

        [Required]
        [StringLength(20)]
        public string EmpStatus { get; set; }

        [Required]
        [StringLength(100)]
        public string WorkLocation { get; set; }

       
        [ForeignKey("EmplyoeeID")]
        public virtual Employeeclass Managerid  { get; set; }

       
    }

   
}
