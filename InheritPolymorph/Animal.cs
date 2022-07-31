using System;

namespace polyinherit
{
  public class Animal  // Base class (parent)
  {
    public virtual void animalSound()
    {
      Console.WriteLine("What sound does the animal make?");
    }

    public virtual void animalLimbs()
    {
      Console.WriteLine("How many limbs does the animal have?");
    }
  }
}//EoN
