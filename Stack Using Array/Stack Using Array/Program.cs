using System;

namespace Stack_Using_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            StackArray S1 = new StackArray(5);
            Console.WriteLine(S1.isEmpty()); //empty returns true
            S1.push(1); //1
            S1.push(2); //2 1
            S1.push(3); //3 2 1
            S1.push(4); //4 3 2 1
            S1.push(5); //5 4 3 2 1
            S1.push(6); //Stack OverFlow
            S1.display();
            Console.WriteLine(S1.isEmpty());
        }
    }
    class StackArray
    {
        int[] dataArray;
        int top;
        public StackArray(int size)
        {
            if (size <= 0)
                size = 1;
            dataArray = new int[size];
            top = -1;
        }
        public bool isEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public bool isFull()
        {
            if (top == dataArray.Length - 1)
                return true;
            else
                return false;
        }
        public void clear()
        {
            top = -1;
            Console.WriteLine("Stack is empty");
        }
        public void push(int data)
        {
            if (isFull())
            {
                Console.WriteLine("Stack OverFlow");
                return;
            }
            else
            {
                dataArray[++top] = data;
            }
        }
        public void pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack UnderFlow");
                return;
            }
            else
            {
                Console.WriteLine("Value popped is : " + dataArray[top--]);
            }
        }
        public void peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack UnderFlow");
                return;
            }
            else
            {
                Console.WriteLine("top element is : " + dataArray[top]);
            }
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack UnderFlow");
                return;
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.Write(dataArray[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}