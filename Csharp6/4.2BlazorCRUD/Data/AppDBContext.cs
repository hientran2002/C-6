using Microsoft.EntityFrameworkCore;

namespace _4._2BlazorCRUD.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
        {

        }
        public DbSet<Employee> Employees { get; set; }  

    }
}
