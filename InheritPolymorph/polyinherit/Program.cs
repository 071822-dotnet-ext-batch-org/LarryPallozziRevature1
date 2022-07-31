using System;

namespace polyinherit
{
  class Program
  {
    static void Main(string[] args)
    {
      Animal myAnimal = new Animal();  // Create a Animal object
      Animal myCat = new Cat();  // Create a Cat object
      Animal myDog = new Dog();  // Create a Dog object
      Animal myFish = new Fish();  // Create a Fish object

      myAnimal.animalSound();
      myCat.animalSound();
      myDog.animalSound();
      myFish.animalSound();

      myAnimal.animalLimbs();
      myCat.animalLimbs();
      myDog.animalLimbs();
      myFish.animalLimbs();
    }
  }
}
