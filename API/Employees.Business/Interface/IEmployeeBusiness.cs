using Employees.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Business.Interface
{
    public interface IEmployeeBusiness
    {
        Task<List<Employee>> GetEmployees();
        Employee GetEmployeeById(int id);
    }
}
