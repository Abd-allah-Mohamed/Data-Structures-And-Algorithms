using System;

namespace Queue_Using_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueLinkedList q1 = new QueueLinkedList();
            q1.enqueue(1); //1
            q1.enqueue(2); //1 2
            q1.enqueue(3); //1 2 3
            q1.enqueue(4); //1 2 3 4
            q1.enqueue(5); //1 2 3 4 5
            q1.dequeue(); //2 3 4 5
            q1.display();
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
    class QueueLinkedList
    {
        Node front;
        Node rear;
        public bool isEmpty()
        {
            if (front == null)
                return true;
            else
                return false;
        }
        public void enqueue(int data)
        {
            Node temp = new Node(data);
            if (front == null)
            {
                front = temp;
                rear = temp;
            }
            else
            {
                rear.next = temp;
                rear = temp;
            }
        }
        public void dequeue()
        {
            if (isEmpty())
                Console.WriteLine("Queue UnderFlow");
            else
            {
                Console.WriteLine("Value dequeued is : " + front.data);
                front = front.next;
            }
        }
        public void peek()
        {
            if (isEmpty())
                Console.WriteLine("Queue UnderFlow");
            else
                Console.WriteLine("The peek value is : " + front.data);
        }
        public void display()
        {
            Node p = front;
            if (isEmpty())
                Console.WriteLine("Queue is empty");
            else
            {
                while (p != null)
                {
                    Console.Write(p.data + " ");
                    p = p.next;
                }
                Console.WriteLine();
            }
        }
    }
}