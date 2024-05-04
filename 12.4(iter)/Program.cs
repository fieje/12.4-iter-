using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class CircularLinkedList
{
    private Node head;

    public CircularLinkedList()
    {
        head = null;
    }

    public void AddNode(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
        }
        else
        {
            Node temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Next = head;
        }
    }

    public void DeleteNodesAfter(int targetData)
    {
        if (head == null)
        {
            Console.WriteLine("The list is empty");
            return;
        }

        Node current = head;

        do
        {
            if (current.Data == targetData)
            {
                Node nodeToDelete = current.Next;
                current.Next = head; 
                while (nodeToDelete != null && nodeToDelete != head)
                {
                    Node nextNode = nodeToDelete.Next;
                    Console.WriteLine("Deleted the element with value {0}", nodeToDelete.Data);
                    nodeToDelete = nextNode;
                }
                return;
            }
            current = current.Next;
        } while (current != head);

        Console.WriteLine("Element with value {0} not found", targetData);
    }

    public void DisplayList()
    {
        if (head == null)
        {
            Console.WriteLine("The list is empty");
            return;
        }

        Node current = head;

        do
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        } while (current != head);

        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList myList = new CircularLinkedList();

        myList.AddNode(1);
        myList.AddNode(2);
        myList.AddNode(3);
        myList.AddNode(4);
        myList.AddNode(5);

        Console.WriteLine("Initial list:");
        myList.DisplayList();

        Console.Write("Enter the value to delete the elements after: ");
        int targetValue = int.Parse(Console.ReadLine());
        myList.DeleteNodesAfter(targetValue);

        Console.WriteLine("List after deletion:");
        myList.DisplayList();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
