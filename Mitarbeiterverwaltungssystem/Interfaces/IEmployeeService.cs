using Mitarbeiterverwaltungssystem.Modals;
using Mitarbeiterverwaltungssystem.Modals;
using System.Collections.Generic;

namespace Mitarbeiterverwaltungssystem.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        void AddEmployee(Employee employee);
        void EditEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
