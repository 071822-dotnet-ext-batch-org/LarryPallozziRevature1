using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repo;

namespace Models
{
    public class LoginAccess
    {
    public Repo repoConnect = new Repo();


    public static void Login(string[] newEmployee, email, password)
    {
      Console.WriteLine("Welcome to the company ERS,if you are new please enter 'new', else if you are a current employee enter your email and password. ");
      string enteredInput = Console.ReadLine().ToUpper();
      =

      if(enteredInput == 'new')
      {
        Employees e = newEmployeeI();
      }
    }
}
