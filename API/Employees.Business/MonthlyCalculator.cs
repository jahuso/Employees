using Employees.Business.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Business
{
    public class MonthlyCalculator : ICalculator
    {
        private double BaseSalary { get; set; }
        public MonthlyCalculator(double basesalary)
        {
            BaseSalary = basesalary;
        }
        public double CalculateSalary()
        {
            return BaseSalary * 12;
        }
    }
}
