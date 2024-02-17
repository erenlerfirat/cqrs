using App.Employees.Data;
using App.Employees.Repository;

namespace App
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var data = new EmployeeData();
            var employeeQueryHandler = new EmployeeQueryHandler(data);
            var employee = employeeQueryHandler.GetEmployeeById(1);
            Console.WriteLine($"{employee.Name}");

            var employeeCommandHandler = new EmployeeCommandHandler(data);
            var addedEmployee = employeeCommandHandler.Add("Jessica");
            Console.WriteLine($"{addedEmployee.Name}");

            Console.WriteLine("List all employees by name");
            employeeQueryHandler.GetAllEmployees().ForEach( employee => Console.WriteLine( employee.Name ) );
        }
    }
}
