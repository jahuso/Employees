using Employees.Business.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Business
{
    public class HourlyCalculator : ICalculator
    {
        private double BaseSalary { get; set; }
        public HourlyCalculator(double basesalary)
        {
            BaseSalary = basesalary;
        }

        public double CalculateSalary()
        {
            return 120 * BaseSalary * 12;
        }
    }
}
