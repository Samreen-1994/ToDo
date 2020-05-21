using Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Employees
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        bool CreateEmployee(Employee e);
        bool DeleteEmployee(Employee e);
        bool UpdateEmployee(Employee e);

    }
}
