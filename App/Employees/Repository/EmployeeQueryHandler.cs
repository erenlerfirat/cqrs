using App.Employees.Data;
using App.Employees.Model;

namespace App.Employees.Repository
{
    internal class EmployeeQueryHandler : IEmployeeQueryHandler
    {
        private readonly List<Employee> employees;
        public EmployeeQueryHandler(EmployeeData data)
        {
            employees = data.Employees;
        }
        public Employee GetEmployeeById(int id)            
        {
            Employee? employee = employees.Find(x => x.Id == id);
            return employee ?? new Employee() { Id = 0, Name = "Not Found" };
        }
        public List<Employee> GetAllEmployees() 
        {
            return employees;
        }
    }
}
