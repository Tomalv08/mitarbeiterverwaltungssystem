namespace Mitarbeiterverwaltungssystem.Modals
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(int id, string name, string position, string department)
            : base(id, name, position)
        {
            Department = department;
        }

        // Additional fields for Manager
        public List<Employee> Employees { get; set; }
    }
}
