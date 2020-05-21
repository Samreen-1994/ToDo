using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Employees;
using Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ToDoEmployee.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService employeeService;
        public EmployeeController(IEmployeeService _employeeService)
        {
            this.employeeService = _employeeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                return Ok(this.employeeService.GetEmployees());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public IActionResult CreateEmployee([FromBody]Employee employee)
        {
            return Ok(this.employeeService.CreateEmployee(employee));
        }

        [HttpPost("Update")]
        public IActionResult UpdateEmployee([FromBody]Employee employee)
        {
            return Ok(this.employeeService.UpdateEmployee(employee));
        }

        [HttpPost("Delete")]
        public IActionResult DeleteEmployee([FromBody]Employee employee)
        {
            return Ok(this.employeeService.DeleteEmployee(employee));
        }
    }
}
