﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.DTO
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public double hourlySalary { get; set; }
        public double monthlySalary { get; set; }
        public double annualsalary { get; set; }
    }
}
