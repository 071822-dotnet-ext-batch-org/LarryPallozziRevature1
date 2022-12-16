using System;
using System.Collections.Generic;

namespace LinkedListPractice
{
  public class Program
  {
    static void Main(string[] args)
    {
      LinkedList listed = LinkedList();

      Console.WriteLine("Is the list empty? " + listed.Empty);
      Console.WriteLine("Count is " + listed.Count);
      Console.ReadLine();
    }
  }

}
