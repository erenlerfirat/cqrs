using App.Employees.Model;

namespace App.Employees.Repository
{
    internal interface IEmployeeCommandHandler
    {
        public Employee Add(string name);
        bool Remove(int id);
    }
}
