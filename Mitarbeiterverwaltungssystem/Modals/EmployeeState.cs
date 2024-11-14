using System.Collections.Generic;
using System.Linq;

namespace Mitarbeiterverwaltungssystem.Modals
{
    public class EmployeeState
    {
        public List<Employee> Employees { get; private set; } = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void EditEmployee(Employee updatedEmployee)
        {
            var employee = Employees.Find(e => e.Id == updatedEmployee.Id);
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Position = updatedEmployee.Position;
                if (employee is Manager manager && updatedEmployee is Manager updatedManager)
                {
                    manager.Department = updatedManager.Department; 
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = Employees.Find(e => e.Id == id);
            if (employee != null)
            {
                Employees.Remove(employee);
            }
        }
    }
}
