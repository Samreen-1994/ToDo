using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.ToDos;
using Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDoEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private IToDoService toDoService;

        public ToDoController(IToDoService _toDoService)
        {
            this.toDoService = _toDoService;
        }

        [HttpGet("GetEmployeeTasks")]
        public IActionResult GetEmployeeTasks(int employeeId)
        {
            try
            {
                return Ok(this.toDoService.GetEmployeeTasks(employeeId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public IActionResult CreateToDo(ToDo toDo)
        {
            return Ok(this.toDoService.CreateTodo(toDo));
        }

        [HttpPost("Update")]
        public IActionResult UpdateToDo(ToDo toDo)
        {
            return Ok(this.toDoService.UpdateTodo(toDo));
        }

        [HttpPost("Delete")]
        public IActionResult DeleteToDo(ToDo toDo)
        {
            return Ok(this.toDoService.DeleteTodo(toDo));
        }
    }
}