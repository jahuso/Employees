using Employees.DAL;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.GetById(1);
        }
    }
}
