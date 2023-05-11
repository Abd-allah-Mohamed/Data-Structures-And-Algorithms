using System;

namespace Queue_With_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QueueArray q = new QueueArray(3);
            q.enqueue(2); //2
            q.enqueue(3); //2 3
            q.enqueue(6); //2 3 6
            q.enqueue(5); //Queue OverFlow
            q.display();
            q.dequeue(); //3 6
            q.display();
        }
    }
    class QueueArray
    {
        int[] dataArray;
        int front, rear;
        public QueueArray(int size)
        {
            dataArray = new int[size];
            front = rear = -1;
        }
        public bool isEmpty()
        {
            if (rear == -1 || rear == front - 1)
                return true;
            else
                return false;
        }
        public bool isFull()
        {
            if (rear == dataArray.Length - 1)
                return true;
            else
                return false;
        }
        public void enqueue(int data)
        {
            if (isFull())
                Console.WriteLine("Queue OverFlow");
            else
            {
                if (front == -1)
                    front = 0;
                dataArray[++rear] = data;
            }
        }
        public void dequeue()
        {
            if (isEmpty())
                Console.WriteLine("Queue UnderFlow");
            else
                Console.WriteLine("Value dequeued is : " + dataArray[front++]);
        }
        public void peek()
        {
            if (isEmpty())
                Console.WriteLine("Queue UnderFlow");
            else
                Console.WriteLine("The peek value is : " + dataArray[front]);
        }
        public void display()
        {
            if (isEmpty())
                Console.WriteLine("Queue is empty");
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(dataArray[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}