using Employees.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.DAL.Interface
{
    public interface IEmployeeRepository
    {
        Task <List<Employee>> Get();
        Employee GetById(int id);
    }
}
