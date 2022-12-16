// Create/Get/Remove Nodes From Linked List
// Construct Single Node
// Insert first node
// Insert last node
// Insert at index
// Get at index
// Remove at index
// Clear list

using System;

namespace LinkedListApp{

  public class LinkedList
  {

    LinkedList head;

    public class LinkedLostNode
    {

      public int data;
      public LinkedListNode next;

      public LinkedListNode(int data)
      {
        this.data = data;
        next = null;
      }

      public void push(LinkedListNode Node)
      {
        LinkedListNode temp = Node;

        head = Node;
        head.next = temp;
      }

      public void insert(LinkedListNode Node)
      {
        (if head == null)
        {
          head = Node;
          return;
        }

        //Insert node at the end of the list
        LinkedListNode temp = head;

        while(temp.next != null)
        {
          temp = temp.next;
        }

        temp.next = Node;
        Node.next = null;
      }

      static void Main(String[] args)
      {
        LinkedList list = new LinkedList();
        list.head = new LinkedListNode(10);

        LinkedListNode second = new LinkedListNode(20);
        list.head.next = second;

        LinkedListNode third = new LinkedListNode(30);
        list.head.next = third;
      }

    } //EoLLN
  } //EoLL
} //EoNS
