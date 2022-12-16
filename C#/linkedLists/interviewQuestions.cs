 using System;
 using System.Collections.Generic;
 using System.Linq;

namespace interviewQuestions
{
  // Create/Get/Remove Nodes From Linked List
  public class Node
  {
    public object value;
    public Node next;

    public Node(object value, Node nextNode)
    {
      value = value;
      next = nextNode;
    }
  }

  // Construct Single Node
  public Node ConstructNode(object value, Node nextNode = null)
  {
    return new Node(value, nextNode);
  }

  // Insert first node
  public Node AddFirst(object value)
  {
    return ConstructNode(value);
  }

  // Insert last node
  public Node AddLast(Node objNode, object value)
  {
    Node tempNode=ConstructNode(value);
    objNode.Next = tempNode;

    return objNode;
  }

  // Insert at index
  public Node InsertNode(Node objNode, int index, object value){

    int i = 0;

    while(i < index - 1)
    {
      objNode = objNode.Next;
      i++;
    }

    Node tempNode=ConstructNode(value, objNode.Next);
    objNode.Next = tempNode;

    return objNode;
  }

  // Get at index
  public Node GetNode(Node objNode, int index)
  {
    int i=0;

    while(i < index){

      if(objNode.Next == null)
      {
        throw New ArrayIndexOutOfBoundException();
      }

      objNode = objNode.Next;
      i++;
    }

    return objNode;
  }

  // Remove at index
  public Node RemoveNode(Node objNode, int index)
  {
    int i = 0;

    while(i < index - 1)
    {
      objNode = objNode.Next;
    }

    objNode.Next = objNode.Next.Next;

    return objNode;
  }

  // Clear list
  public Node ClearList(Node objNode)
  {
    while(objNode.Next != null)
    {
      objNode = objNode.Next;
    }

    return objNode.Next;
  }

} //ENS
