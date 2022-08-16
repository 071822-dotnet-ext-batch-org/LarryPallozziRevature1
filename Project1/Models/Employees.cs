using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
  public class Employees
  {
    //Getting data for employees
    public int EmployeeId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string IsManager { get; set; } = "No";
    public string? Email{ get; set; }
    public string? Password { get; set; }

    /// <summary>
    /// This method will return the information on a current employee
    /// </summary>
    /// <param name="employeeId"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="isManager"></param>
    /// <param name="email"></param>
    /// <param name="password"></param>
    public void CurrentEmployee(int employeeId, string firstName, string lastName, string isManager, string email, string password)
    {
      this.EmployeeId = employeeId;
      this.FirstName = firstName;
      this.LastName = lastName;
      this.IsManager = isManager;
      this.Email = email;
      this.Password = password;
    }

    /// <summary>
    /// Creating a new employee.
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="isManager"></param>
    /// <param name="email"></param>
    /// <param name="password"></param>
    public void NewEmployee(string firstName, string lastName, string isManager, string email, string password)
    {
      this.FirstName = firstName;
      this.LastName = lastName;
      this.IsManager = isManager;
      this.Email = email;
      this.Password = password;
    }

  } //End class
} //End namespace
