using System.ComponentModel.DataAnnotations;

namespace _4._2BlazorCRUD.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeName { get; set; }

        public int Gender { get; set; }
        public int City { get; set; }
        public int Defignation { get; set; }
    }
}
