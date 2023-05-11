using System;

namespace Stack_Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkBrackets = "({})";
            Console.WriteLine(isBalanced(checkBrackets));
        }
        public static bool isBalanced(string brackets)
        {
            StackLinkedList br = new StackLinkedList();
            foreach (char ch in brackets.ToCharArray())
            {
                switch (ch)
                {
                    case '{':
                    case '(':
                    case '[':
                        br.push(ch);
                        break;

                    case '}':
                        if (br.pop() != '{')
                        {
                            return false;
                        }
                        break;

                    case ')':
                        if (br.pop() != '(')
                        {
                            return false;
                        }
                        break;

                    case ']':
                        if (br.pop() != '[')
                        {
                            return false;
                        }
                        break;
                }
            }
            return br.size() == 0;
        }
    }
    class Node
    {
        public Node next;
        public char data;
        public Node(char data)
        {
            this.data = data;
        }
    }
    class StackLinkedList
    {
        Node top;
        public bool isEmpty()
        {
            if (top == null)
                return true;
            else
                return false;
        }
        public int size()
        {
            int count = 0;
            Node p = top;
            while (p != null)
            {
                p = p.next;
                count++;
            }
            return count;
        }
        public void push(char data)
        {
            Node temp = new Node(data);
            temp.next = top;
            top = temp;
        }
        public int pop()
        {
            if (isEmpty())
            {
                return int.MinValue;
            }
            char temp = top.data;
            top = top.next;
            return temp;
        }
    }
}