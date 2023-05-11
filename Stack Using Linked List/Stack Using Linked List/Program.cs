using System;

namespace Stack_Using_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            StackLinkedList S1 = new StackLinkedList();
            S1.push(1); //1
            S1.push(2); //2 1
            S1.push(3); //3 2 1
            S1.display();
            S1.pop(); //2 1
            S1.display();
            S1.pop(); //1
            S1.pop(); //empty
            S1.pop(); //Stack UnderFlow
        }
    }
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    class StackLinkedList
    {
        Node top;
        public void push(int data)
        {
            Node temp = new Node(data);
            if (isEmpty())
            {
                top = temp;
            }
            else
            {
                temp.next = top;
                top = temp;
            }
        }
        public void pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack UnderFlow");
            }
            else
            {
                Console.WriteLine("Value popped is : " + top.data);
                top = top.next;
            }
        }
        public void peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack UnderFlow");
            }
            else
            {
                Console.WriteLine("Top node is : " + top.data);
            }
        }
        public void clear()
        {
            top = null;
            Console.WriteLine("Stack is empty");
        }
        public bool isEmpty()
        {
            if (top == null)
                return true;
            else
                return false;
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack UnderFlow");
                return;
            }
            Node p = top;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}