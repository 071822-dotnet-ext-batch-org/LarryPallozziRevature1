using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repo;
using Models;

namespace Business
{
  public class BusinessClass : IBusinessClass
  {

    public static void StartPromt()
    {
      string emailUserName, password;

      Console.Write("Welcome to the company expense reimbursement system!\n");

        Console.Write("Input a username: ");
        emailUserName = Console.ReadLine();

        Console.Write("Input a password: ");
        password = Console.ReadLine();

        if (emailUserName == Repo && password == Repo)
        {
          Console.WriteLine("Access granted");
        }
        else
        {
          Console.WriteLine("Either you are not in the system, or the email or password were entered wrong.");
        };

    }//EO Main

  }//EOC
}//EON
