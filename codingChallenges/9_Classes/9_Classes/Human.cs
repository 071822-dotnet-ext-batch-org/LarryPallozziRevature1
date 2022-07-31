using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human
    {
      private string lastName = "Smyth";
      private string firstName = "Pat";

      public Human(string firstName, string lastName)
      {
        this.firstName = firstName;
        this.lastName = lastName;
      }

      public Human() {}

      internal string AboutMe()
      {
        return $"My name is {this.firstName} {this.lastName}!"!;
      }


      /*
      private string FirstName2 = "Dick";
      private string LastName2 = "Butkis";

      private Human(string FirstName2, string LastName2)
      {
        this.FirstName2 = FirstName2;
        this.LastName2 = LastName2;
      }

      private Human() {}

      private string AboutMe2()
      {
        return $"My name is {this.FirstName2} {this.LastName2} and My name is {this.FirstName2} {this.LastName2}";
      }
      */


    }//end of class
}//end of namespace
