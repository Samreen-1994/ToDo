using Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ToDos
{
    public interface IToDoService
    {
        List<ToDo> GetEmployeeTasks(int employeeId);
        bool CreateTodo(ToDo t);
        bool UpdateTodo(ToDo t);
        bool DeleteTodo(ToDo t);
    }
}
