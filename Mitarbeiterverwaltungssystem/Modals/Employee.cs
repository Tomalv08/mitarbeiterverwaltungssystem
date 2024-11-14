namespace Mitarbeiterverwaltungssystem.Modals
{
    public class Employee
    {
        public int Id { get; set; }  // Added Id property
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; } // Add Department field

        public Employee(int id, string name, string position)
        {
            Id = id;  // Initialize Id property
            Name = name;
            Position = position;
        }

        // Manager property to link back to the manager
        public Manager Manager { get; set; }
    }
}
