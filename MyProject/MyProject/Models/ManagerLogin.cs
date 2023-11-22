﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class ManagerLogin
    {
        [Key]
        public int ManagerID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}