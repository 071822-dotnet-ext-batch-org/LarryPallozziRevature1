using System;
using System.Collections.Generic;

namespace LinkedListPractice
{
  public class Node
  {
    private object data; // list being passed
    private Node next; // reference to next node in list

    // constructor passing fields data and next
    public Node(object data, Node next)
    {
      this.data = data;
      this.next = next;
    }

    // property to get/set data
    public object Data
    {
      get { return this.data; }
      set { this.data = value; }
    }

    // property to get/set next
    public Node next
    {
      get { return this.next; }
      set { this.next = value; }
    }

  }
}
