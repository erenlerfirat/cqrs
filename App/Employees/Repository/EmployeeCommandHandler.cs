using App.Employees.Data;
using App.Employees.Model;

namespace App.Employees.Repository
{
    internal class EmployeeCommandHandler : IEmployeeCommandHandler
    {
        private readonly List<Employee> employees;
        public EmployeeCommandHandler(EmployeeData data)
        {
            employees = data.Employees;
        }
        public Employee Add(string name)
        {
            var rnd = new Random(2);
            var emp = new Employee() { Id = rnd.Next(1, 200), Name = name };
            employees.Add(emp);
            return emp;
        }
        public bool Remove(int id) 
        {
            employees.RemoveAll(e => e.Id == id);
            return true;
        }
    }
}
