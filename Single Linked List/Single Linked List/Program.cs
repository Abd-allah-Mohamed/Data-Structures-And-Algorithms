using System;

namespace Single_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList L1 = new SingleLinkedList();
            L1.insertAtFront(1); //1
            L1.insertAtEnd(2); //1 2
            L1.insertAtEnd(3); //1 2 3
            L1.insertAtEnd(4); //1 2 3 4
            L1.printList(); //print list
            L1.insertAfter(5, 3); //1 2 3 5 4
            L1.insertBefore(6, 2); //1 6 2 3 5 4
            L1.printList(); //print list
            L1.insertAtPosition(9, 3); //1 6 9 2 3 5 4
            L1.printList(); //print list
            L1.search(9); //search for "9"
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
    class SingleLinkedList
    {
        Node head;
        public SingleLinkedList()
        {
            head = null;
        }
        public int count()
        {
            int count = 0;
            Node p = head;
            while (p != null)
            {
                count++;
                p = p.next;
            }
            return count;
        }
        public void printList()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
        public void insertAtFront(int data)
        {
            Node temp = new Node(data);
            temp.next = head;
            head = temp;
        }
        public void insertAtEnd(int data)
        {
            Node temp = new Node(data);
            if (head == null)
            {
                head = temp;
                return;
            }
            Node p = head;
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = temp;
            temp.next = null;
        }
        public void insertAfter(int data, int item)
        {
            Node temp = new Node(data);
            Node p = head;
            while (p != null)
            {
                if (p.data == item)
                {
                    temp.next = p.next;
                    p.next = temp;
                    return;
                }
                p = p.next;
            }
            Console.WriteLine("{0} is not in the linked list", item);
        }
        public void insertBefore(int data, int item)
        {
            Node temp = new Node(data);
            Node p = head;
            while (p != null)
            {
                if (p.next.data == item)
                {
                    temp.next = p.next;
                    p.next = temp;
                    return;
                }
                p = p.next;
            }
            Console.WriteLine("{0} is not in the linked list", item);
        }
        public void insertAtPosition(int data, int pos)
        {
            if (pos == 1)
            {
                insertAtFront(data);
                return;
            }
            Node temp = new Node(data);
            Node p = head;
            for (int i = 2; i < pos; i++)
            {
                if (p != null)
                {
                    p = p.next;
                }
            }
            temp.next = p.next;
            p.next = temp;
        }
        public void search(int data)
        {
            Node p = head;
            int pos = 1;
            while (p != null)
            {
                if (p.data == data)
                {
                    Console.WriteLine("Item {0} found at position {1}", data, pos);
                    return;
                }
                p = p.next;
                pos++;
            }
            Console.WriteLine("Item {0} not found", data);
        }
        public void ReverseList()
        {
            Node prev, curr, next;
            prev = null;
            curr = head;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }
        public void DeleteNode(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.data == data)
            {
                head = head.next;
                return;
            }
            Node p = head;
            while (p.next != null)
            {
                if (p.next.data == data)
                {
                    p.next = p.next.next;
                    return;
                }
                p = p.next;
            }
            Console.WriteLine("Element {0} not found", data);
        }
    }
}