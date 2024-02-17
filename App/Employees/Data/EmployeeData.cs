using App.Employees.Model;

namespace App.Employees.Data
{
    public class EmployeeData
    {
        public List<Employee> Employees = new List<Employee>()
            { new Employee { Id = 1 ,Name = "Anna Haskar" },
              new Employee { Id = 2 ,Name = "Annahita" }
            };
    }
}
