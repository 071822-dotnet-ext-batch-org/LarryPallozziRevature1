using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{ //Begin namespace
    internal class Human2
    {// Begin class

      private string firstName = "Pat";
      private string lastName = "Smyth";
      private string eyeColor;
      private int age;
      public int Weight;
      public int weight {
        get {return Weight;}
        set
        {
          if (value > 0 && value < 400)
          {
            this.Weight = value;
          }
          else
          {
            Console.Write("We have a problem!");
          }
        }

      }

      public Human2() {}

      public Human2(string firstName, string lastName, string eyeColor, int age)
      {
        this.firstName = firstName;
        this.lastName = lastName;
        this.eyeColor = eyeColor;
        this.age = age;
      }

      public Human2(string firstName, String lastName, int age)
      {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
      }

      public Human2(string firstName, string lastName, string eyeColor)
      {
        this.firstName = firstName;
        this.lastName = lastName;
        this.eyeColor = eyeColor;
      }

      internal string AboutMe()
      {
        return $"My name is {this.firstName} {this.lastName}!"!;
      }


      internal string AboutMe2()
      {
        if (this.age == 0 && this.eyeColor == null)
        {
          return $"My name is {this.firstName} {this.lastName}.";
        }
        else if (this.age == 0)
        {
         return $"My name is {this.firstName} {this.lastName}, I'm {this.age}.";
        }
        else if (this.eyeColor == null)
        {
          return $"My name is {this.firstName} {this.lastName}, and my eyes are {this.eyeColor}.";
        }
        else
        {
        return $"My name is {this.firstName} {this.lastName}, I'm {this.age} and my eyes are {this.eyeColor}.";
        }
      }

    } //end of class
} //end of namespace
