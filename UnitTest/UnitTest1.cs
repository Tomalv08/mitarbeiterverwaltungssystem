using NUnit.Framework;
using Mitarbeiterverwaltungssystem.Services; 
using Mitarbeiterverwaltungssystem.Modals;  
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    public class EmployeeServiceTests
    {
        private EmployeeService _employeeService;

        [SetUp]
        public void Setup()
        {
            _employeeService = new EmployeeService();
        }

        [Test]
        public void AddEmployee_ShouldAddEmployee()
        {
            // Arrange
            var employee = new Employee(1, "John Doe", "Developer");

            // Act
            _employeeService.AddEmployee(employee);

            // Assert
            var employees = _employeeService.GetEmployees();
            Assert.AreEqual(1, employees.Count);
            Assert.AreEqual("John Doe", employees.First().Name);
        }

        [Test]
        public void EditEmployee_ShouldEditEmployee()
        {
            // Arrange
            var employee = new Employee(1, "John Doe", "Developer");
            _employeeService.AddEmployee(employee);
            var updatedEmployee = new Employee(1, "John Smith", "Tester");

            // Act
            _employeeService.EditEmployee(updatedEmployee);

            // Assert
            var employees = _employeeService.GetEmployees();
            Assert.AreEqual(1, employees.Count);
            Assert.AreEqual("John Smith", employees.First().Name);
            Assert.AreEqual("Tester", employees.First().Position);
        }

        [Test]
        public void DeleteEmployee_ShouldRemoveEmployee()
        {
            // Arrange
            var employee = new Employee(1, "John Doe", "Developer");
            _employeeService.AddEmployee(employee);

            // Act
            _employeeService.DeleteEmployee(1);

            // Assert
            var employees = _employeeService.GetEmployees();
            Assert.AreEqual(0, employees.Count);
        }
    }
}
