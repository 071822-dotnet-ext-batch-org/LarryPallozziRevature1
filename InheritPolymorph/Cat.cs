using System;

namespace polyinherit
{
  class Cat : Animal  // Derived class (child). Use the ":" in order to inherit from the class "Animal"
  {
    public override void animalSound()
    {
      Console.WriteLine("The cat says: meow");
    }

    public override void animalLimbs() //"Derived_Class.animalLimbs() hides the inherited memeber Animal.animalLimbs(). To make the current member override that implementation, add the override keyword. Otherwise add a new keyword.
    {
      Console.WriteLine("The cat has 4 legs");
    }
  }
}//EoN
