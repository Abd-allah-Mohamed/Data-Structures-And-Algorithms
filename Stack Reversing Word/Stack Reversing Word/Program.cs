using System;

namespace Stack_Reversing_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to reverse : ");
            string word = Console.ReadLine();
            reverseWord(word);
        }
        static void reverseWord(string word)
        {
            StackArray s = new StackArray(word.Length);
            char [] ch = word.ToCharArray();
            for(int i = 0; i < word.Length; i++)
            {
                s.push(ch[i]);
            }
            while(!s.isEmpty())
            {
                Console.Write(s.pop());
            }
        }
    }
    class StackArray
    {
        int top;
        char[] dataArray;
        public StackArray(int size)
        {
            dataArray = new char[size];
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
        public void push(char data)
        {
            if (isFull())
                Console.WriteLine("Stack OverFlow");
            else
                dataArray[++top] = data;
        }
        public char pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack UnderFlow");
                return char.MinValue;
            }
            else
                return dataArray[top--];
        }
    }
}