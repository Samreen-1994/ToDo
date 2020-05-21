using Database.Entities;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private IGenericRepository<Employee> employeeRepo;
        public EmployeeService(IGenericRepository<Employee> _employeeRepo)
        {
            this.employeeRepo = _employeeRepo;
        }

        public bool CreateEmployee(Employee e)
        {
            this.employeeRepo.Insert(e);
            this.employeeRepo.Save();
            return true;
        }

        public bool DeleteEmployee(Employee e)
        {
            this.employeeRepo.Delete(e.employee_id);
            this.employeeRepo.Save();
            return true;
        }

        public List<Employee> GetEmployees()
        {
            return this.employeeRepo.GetAll().OrderBy(x => x.first_name).ToList();
        }

        public bool UpdateEmployee(Employee e)
        {
            this.employeeRepo.Update(e);
            this.employeeRepo.Save();
            return true;
        }
    }
}
