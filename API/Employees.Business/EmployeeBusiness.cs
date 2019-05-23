using Employees.Business.Interface;
using Employees.DAL;
using Employees.DAL.Interface;
using Employees.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private IEmployeeRepository Repository { get; set; }
        private FactoryCalculator calculatorfactory = new FactoryCalculator();

        public EmployeeBusiness()
        {
            Repository = new EmployeeRepository();
        }

        public EmployeeBusiness(IEmployeeRepository repository)
        {
            if (repository != null)
            {
                Repository = repository;
            }
            else
            {
                Repository = new EmployeeRepository();
            }
        }

        public Employee GetEmployeeById(int id)
        {
            Employee result = Repository.GetById(id);
            if (result != null)
            {
                ICalculator calculator = calculatorfactory.GetInstance(result);
                result.annualsalary = calculator.CalculateSalary();
            }

            return result;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            List<Employee>result = await Repository.Get();
            if (result != null && result.Count > 0)
            {
                ICalculator calculator;
                foreach (var employee in result)
                {
                    calculator = calculatorfactory.GetInstance(employee);
                    employee.annualsalary = calculator.CalculateSalary();
                }
            }
            return result;
        }
    }
}
