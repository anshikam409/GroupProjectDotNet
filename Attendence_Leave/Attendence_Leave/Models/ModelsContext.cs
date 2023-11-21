using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Attendence_Leave.Models
{
    public class ModelsContext:DbSet
    {
        public ModelsContext():base()
        {

        }
        public DbSet<Employeeclass> Emplyoeeobject { get; set; }
        public DbSet<ProjectClass> ProjectObject { get; set; }
        public DbSet<LeavesClass> leaveObjects { get; set; }
        public DbSet<LeavesCredit> leavesCredits { get; set; }
        public DbSet<AttedenceClass> Attendenceobject { get; set; }
        public DbSet<Worksonclass> workobject { get; set; }
    }
}