using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.DAL.Interface;
using Employees.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employees.API.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/employee
        [HttpGet]
        public Task<List<Employee>> Get()
        {
            return _employeeRepository.Get();
        }

        // GET api/employee/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employee = _employeeRepository.GetById(id);



            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
    }
}
