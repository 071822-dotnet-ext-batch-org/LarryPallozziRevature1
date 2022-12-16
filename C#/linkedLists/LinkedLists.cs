using System;
using System.Collections.Generic;

namespace LinkedListPractice
{
  public class LinkedList
  {
    private Node head; // first node
    private int size; // length of list

    //constructor, head starts at null due to not yet having been used
    public LinkedList()
    {
      this.head = null;
      this.size = 0;
    }

    // property to confirm if size is = to 0
    public bool Empty
    {
      get { return this.size == 0; }

    }

    // property that tells current list size
    public int Count
    {
      get { return this.size; }
    }

  }
}
