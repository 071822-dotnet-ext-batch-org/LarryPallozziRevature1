using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models;
public class Employees
{
  public string FirstName { get; set; }
  private string LastName { get; set; }
  private string Email{ get; set; }
  private string Password { get; set; }
  private int ManagerID{ get; set; }
  private string Date { get; set; }
  private string Details { get; set; }
  private float Amount{ get; set; }
  private string Approved{ get; set; }

  //public Employee() {} // Parameterized constructor for employee information

  /// <summary>
  /// This method will return the information on a current employee
  /// </summary>
  /// <param name="firstName"></param>
  /// <param name="lastName"></param>
  /// <param name="email"></param>
  /// <param name="password"></param>
  /// <param name="managerID"></param>
  public void Employee(string firstName, string lastName, string email, string password, int managerID)
  {

    this.FirstName = firstName;
    this.LastName = lastName;
    this.Email = email;
    this.Password = password;
    this.ManagerID = managerID;
  }
  //public Expenses() {} // Parameterized constructor for the Expenses

  /// <summary>
  /// Returns the expenses for a current employee
  /// </summary>
  /// <param name="date"></param>
  /// <param name="details"></param>
  /// <param name="amount"></param>
  /// <param name="approved"></param>
  public void Expenses(string date, string details, float amount, string approved)
  {
    this.Date = date;
    this.details = Details;
    this.amount = Amount;
    this.approved = Approved;
  }

} //End class
