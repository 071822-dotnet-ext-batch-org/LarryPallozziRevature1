using System;

namespace linkedListPractice
{
  class Program
  {
    class LinkedListNode
    {
      public int data;
      public LinkedListNode next;

      public LinkedListNode(int x)
      {
        data = x;
        next = null;
      }
    }

    class LinkedList
    {
      int conuts;
      LinkedListNode head = null; // when first created head = null

      public LinkedList()
      {
        head = null;
        count = 0;
      }

      public void AddNodeToFront(int data) // add new list node to front
      {
        LinkedListNode node = new LinkedListNode(data);
        node.next = head;
        head = node; // add new nodes to front
        counts++;
      }

      public void PrintList() // prints out list
      {
        LinkedListNode runner = head;

        while (runner != null) //need to make sure that it is not null to continue
        {
          Console.WriteLine(runner.data);
          runner = runner.next;
        }
      }

    }

    static void Main(string[] args) // returns numbers backwards 3,2,1
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddNodeToFront(1);
      linkedList.AddNodeToFront(2);
      linkedList.AddNodeToFront(3);
    }
  }
}
