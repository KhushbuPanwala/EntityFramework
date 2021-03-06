﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAppCodeFirstMVC.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Foreign Key for the Department 
        public int DepartmentID { get; set; }

        public Department Department { get; set; }
    }
}