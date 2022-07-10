using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp5.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees = new List<Employee>
        {
            new Employee
            {
                Id =Guid.NewGuid(),
                Name = "1"
            }, new Employee
            {
                Id =Guid.NewGuid(),
                Name = "2"
            }
        };

        public void addEmployee(Employee employee)
        {
            var id = Guid.NewGuid();
            employee.Id = id;
            _employees.Add(employee);
        }

        public void deleteEmployess(Guid id)
        {
            var employee = GetEmployee(id);
            _employees.Remove(employee);
        }

        public Employee GetEmployee(Guid id)
        {
            return _employees.SingleOrDefault(c => c.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public void updateEmployee(Employee employee)
        {
            var getOldEmployee = GetEmployee(employee.Id);
            getOldEmployee.Name = employee.Name;

        }
    }
}
