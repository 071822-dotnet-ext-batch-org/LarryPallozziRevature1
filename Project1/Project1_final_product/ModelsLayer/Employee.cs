namespace ModelsLayer
{
    public class Employee
    {
        /// <summary>
        /// Data transfer object that is needed to create a new person in the the Employees database
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="isManager"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public Employee(Guid employeeID, string firstName, string lastName, bool isManager, string email, string password)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            IsManager = isManager;
            Email = email;
            Password = password;
        }

        public Guid EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsManager { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}