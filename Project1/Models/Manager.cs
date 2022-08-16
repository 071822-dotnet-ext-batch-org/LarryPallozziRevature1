using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Manager
    {
      //Getting the data
      public int EmployeeId { get; set; }
      public string? FirstName { get; set; }
      public string? LastName { get; set; }
      public string IsManager { get; set; } = "Yes";
      public string? Email { get; set; }
      public string? Password { get; set; }

      /// <summary>
      /// A method to return the manager
      /// </summary>
      /// <param name="employeeId"></param>
      /// <param name="firstName"></param>
      /// <param name="lastName"></param>
      /// <param name="isManager"></param>
      /// <param name="email"></param>
      /// <param name="password"></param>
      public void CurrentManager(int employeeId, string firstName, string lastName, string isManager, string email, string password)
      {
        this.EmployeeId = employeeId;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.IsManager = isManager;
        this.Email = email;
        this.Password = password;

      }


    }//EOC
}//EON
