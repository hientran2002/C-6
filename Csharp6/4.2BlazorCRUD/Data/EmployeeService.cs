﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _4._2BlazorCRUD.Data
{
    public class EmployeeService
    {
        private readonly AppDBContext _appDBContext;

        private EmployeeService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _appDBContext.Employees.ToListAsync();
        }
        public async Task<bool> InsertEmployeeAsync(Employee employee)
        {
            _appDBContext.Employees.AddAsync(employee);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<Employee> GetEmployeeAsync(int Id)
        {
            Employee employee = await _appDBContext.Employees.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return employee;
        }
        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
           _appDBContext.Employees.Update(employee);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DelateEmployeeAsync(Employee employee)
        {
            _appDBContext.Remove(employee);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}
