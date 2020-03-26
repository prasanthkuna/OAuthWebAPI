﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }
        public string WebSite { get; set; }
        public int? Salary { get; set; }
        public DateTime? HireDate { get; set; }
    }
}