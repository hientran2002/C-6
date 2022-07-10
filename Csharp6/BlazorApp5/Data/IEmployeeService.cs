using System;
using System.Collections.Generic;

namespace BlazorApp5.Data
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(Guid id);
        void updateEmployee(Employee employee);
        void addEmployee(Employee employee);
        void deleteEmployess(Guid id);
    }
}
