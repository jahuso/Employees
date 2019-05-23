using Employees.Business.Interface;
using Employees.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Employees.Business
{
    public class FactoryCalculator
    {
        public ICalculator GetInstance(Employee employee)
        {
            ICalculator instance = null;
            switch (employee.contractTypeName)
            {
                case "HourlySalaryEmployee":
                    instance = new HourlyCalculator(employee.hourlySalary);
                    break;
                case "MonthlySalaryEmployee":
                    instance = new MonthlyCalculator(employee.monthlySalary);
                    break;
                default:
                    throw new InvalidEnumArgumentException($"The type of contractType {employee.contractTypeName} does not exists.");
                    break;
            }

            return instance;

        }
    }
}
