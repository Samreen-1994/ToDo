using Database.Entities;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.ToDos
{
    public class ToDoService : IToDoService
    {
        private IGenericRepository<ToDo> toDoRepo;

        public ToDoService(IGenericRepository<ToDo> _toDoRepo)
        {
            this.toDoRepo = _toDoRepo;
        }

        public bool CreateTodo(ToDo t)
        {
            this.toDoRepo.Insert(t);
            this.toDoRepo.Save();
            return true;
        }

        public bool DeleteTodo(ToDo t)
        {
            this.toDoRepo.Delete(t.employeeid);
            this.toDoRepo.Save();
            return true;
        }

        public List<ToDo> GetEmployeeTasks(int employeeId)
        {
            return this.toDoRepo.GetItems(t => t.employeeid == employeeId).OrderBy(x => int.Parse(x.prioritylevel.ToString())).ToList();
        }

        public bool UpdateTodo(ToDo t)
        {
            this.toDoRepo.Update(t);
            this.toDoRepo.Save();
            return true;
        }
    }
}
