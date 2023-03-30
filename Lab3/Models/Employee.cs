namespace Lab3.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public Employee() { }

        public Employee(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public Employee(int employeeID, string firstName, string lastName, string address)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
    }
}
