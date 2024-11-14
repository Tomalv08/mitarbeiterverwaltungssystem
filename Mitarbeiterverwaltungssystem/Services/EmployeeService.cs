using Mitarbeiterverwaltungssystem.Interfaces;
using Mitarbeiterverwaltungssystem.Modals;
using System.Collections.Generic;
using System.Linq;

namespace Mitarbeiterverwaltungssystem.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void EditEmployee(Employee employee)
        {
            var existingEmployee = employees.FirstOrDefault(e => e.Id == employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Position = employee.Position;
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }
    }
}
