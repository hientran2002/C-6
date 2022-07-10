using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApp.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasData
                (
                 new Employee
                 {
                     Id = Guid.NewGuid(),
                     Name = "Thepv",
                     AccountNumber = "123-3452134543-32",
                     Age = 30
                 },
                 new Employee
                 {
                     Id = Guid.NewGuid(),
                     Name = "Fpoly",
                     AccountNumber = "123-9384613085-55",
                     Age = 28
                 }
                );
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
