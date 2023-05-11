using System;

namespace Circular_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList C1 = new CircularLinkedList();
            C1.AddFirst(1);
            C1.AddFirst(3);
            C1.PrintCircularList();
            CircularLinkedList C2 = new CircularLinkedList();
            C2.AddFirst(6);
            C2.AddFirst(7);
            C2.PrintCircularList();
            Concatenation(ref C1 , ref C2);
            C1.PrintCircularList();
        }
        static void Concatenation(ref CircularLinkedList C1, ref CircularLinkedList C2)
        {
            Node p = C1.last.next;
            C1.last.next = C2.last.next;
            C2.last.next = p;
            C1.last = C2.last;
        }
    }
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    class CircularLinkedList
    {
        public Node last;
        public CircularLinkedList()
        {
            last = null;
        }
        public void AddFirst(int data)
        {
            Node temp = new Node(data);
            if(last == null)
            {
                last = temp;
                last.next = last;
            }
            else
            {
                temp.next = last.next;
                last.next = temp;
            }
        }
        public void AddEnd(int data)
        {
            Node temp = new Node(data);
            if (last == null)
            {
                last = temp;
                last.next = last;
            }
            else
            {
                temp.next = last.next;
                last.next = temp;
                last = temp;
            }
        }
        public void DeleteFirst()
        {
            if (last == last.next)
                last = null;
            else
                last.next = last.next.next;
        }
        public void DeleteEnd()
        {
            if (last == last.next)
                last = null;
            else
            {
                Node p = last.next;
                while(p.next != last)
                {
                    p = p.next;
                }
                p.next = last.next;
                last = p;
            }
        }
        public void PrintCircularList()
        {
            if(last == null)
            {
                Console.WriteLine("Empty Circular Linked List");
                return;
            }
            Node p = last.next;
            do {
                Console.Write(p.data + " ");
                p = p.next;
            }while (p.next != last);
            Console.WriteLine();
        }
    }
}