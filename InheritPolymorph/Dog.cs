using System;

namespace polyinherit
{
  class Dog : Animal  // Derived class (child). Use the ":" in order to inherit from the class "Animal"
  {
    public override void animalSound()
    {
      Console.WriteLine("The dog says: woof");
    }

    public override void animalLimbs() //"Derived_Class.animalLimbs() hides the inherited memeber Animal.animalLimbs(). To make the current member override that implementation, add the override keyword. Otherwise add a new keyword.
    {
      Console.WriteLine("The dog has 4 legs");
    }
  }
}//EoN
