using App.Employees.Model;

namespace App.Employees.Repository
{
    internal interface IEmployeeQueryHandler
    {
        public Employee GetEmployeeById(int id);
        public List<Employee> GetAllEmployees();
    }
}
