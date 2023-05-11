using System;

namespace Double_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList D1 = new DoubleLinkedList();
            D1.AddFirst(1); //1
            D1.AddEnd(2); //1 2
            D1.AddEnd(3); //1 2 3
            D1.AddEnd(4); //1 2 3 4
            D1.AddEnd(5); //1 2 3 4 5
            D1.InsertBefore(6, 2); //1 6 2 3 4 5
            D1.InsertAfter(7, 4); //1 6 2 3 4 7 5
            D1.InsertAtPosition(9, 3); //1 6 9 2 3 4 7 5
            D1.PrintList();
            D1.search(3); //found in position 5
            D1.PrintList();
            D1.ReverseList(); //5 7 4 3 2 9 6 1
            D1.InsertAfter(9, 1);
            D1.PrintList();
        }
    }
    class Node
    {
        public int data;
        public Node next;
        public Node prev;
        public Node(int data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
    }
    class DoubleLinkedList
    {
        Node start;
        public void AddFirst(int data)
        {
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;
                return;
            }
            temp.prev = null;
            temp.next = start;
            start.prev = temp;
            start = temp;
        }
        public void AddEnd(int data)
        {
            Node temp = new Node(data);
            Node q = start;
            while (q.next != null)
            {
                q = q.next;
            }
            q.next = temp;
            temp.prev = q;
            temp.next = null;
        }
        public void InsertAfter(int data, int item)
        {
            Node temp = new Node(data);
            Node q = start;
            while (q != null)
            {
                if (q.data == item)
                {
                    temp.next = q.next;
                    temp.prev = q;
                    q.next.prev = temp;
                    q.next = temp;
                    return;
                }
                q = q.next;
            }
        }
        public void InsertBefore(int data, int item)
        {
            Node temp = new Node(data);
            Node q = start;
            while (q != null)
            {
                if (q.next.data == item)
                {
                    temp.next = q.next;
                    temp.prev = q;
                    q.next.prev = temp;
                    q.next = temp;
                    return;
                }
                q = q.next;
            }
        }
        public void InsertAtPosition(int data, int pos)
        {
            if (pos == 1)
            {
                AddFirst(data);
                return;
            }
            Node temp = new Node(data);
            Node q = start;
            for (int i = 2; i < pos && q != null; i++)
            {
                q = q.next;
            }
            temp.next = q.next;
            temp.prev = q;
            q.next.prev = temp;
            q.next = temp;
        }
        public void DeleteNode(int data)
        {
            //Deleting First Node
            if (start.data == data)
            {
                start = start.next;
                start.prev = null;
                return;
            }
            Node q = start.next;
            //Deleting A Node In Middle
            while (q.next != null)
            {
                if (q.data == data)
                {
                    q.next.prev = q.prev;
                    q.prev.next = q.next;
                    return;
                }
                q = q.next;
            }
            //Deleting Last Node
            if (q.next == null)
            {
                q.prev.next = null;
                return;
            }
        }
        public void ReverseList()
        {
            Node q1 = start;
            Node q2 = q1.next;
            q1.next = null;
            q1.prev = q2;
            while (q2 != null)
            {
                q2.prev = q2.next;
                q2.next = q1;
                q1 = q2;
                q2 = q2.prev;
            }
            start = q1;
        }
        public void PrintList()
        {
            Node q = start;
            while (q != null)
            {
                Console.Write(q.data + " ");
                q = q.next;
            }
            Console.WriteLine();
        }
        public void search(int data)
        {
            int pos = 1;
            Node q = start;
            while (q != null)
            {
                if (q.data == data)
                {
                    Console.WriteLine("Found at position {0}", pos);
                    return;
                }
                q = q.next;
                pos++;
            }
            Console.WriteLine("Element {0} not found", data);

        }
    }
}