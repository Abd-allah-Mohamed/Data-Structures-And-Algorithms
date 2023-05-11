using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t1 = new Tree();
            t1.Add(10);
            t1.Add(9);
            t1.Add(11);
            t1.InOrder();
            Console.WriteLine(t1.maxRecursive());
            t1.searchRecursive(13);
        }
    }
    class Node
    {
        public int data;
        public Node left, right;
        public Node(int data)
        {
            this.data = data;
        }
    }
    class Tree
    {
        Node root;
        public Tree()
        {
            root = null;
        }
        public void Add(int value)
        {
            if (root == null)
                root = new Node(value);
            else
                AddTo(root, value);
        }
        public void AddTo(Node node, int value)
        {
            if (value < node.data)
            {
                if (node.left == null)
                    node.left = new Node(value);
                else
                    AddTo(node.left, value);
            }
            else
            {
                if (node.right == null)
                    node.right = new Node(value);
                else
                    AddTo(node.right, value);
            }
        }
        public void PreOrder()
        {
            PreOrder(root);
        }
        public void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.data);
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }
        public void InOrder()
        {
            InOrder(root);
        }
        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.left);
                Console.WriteLine(node.data);
                InOrder(node.right);
            }
        }
        public void PostOrder()
        {
            PostOrder(root);
        }
        public void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                Console.WriteLine(node.data);
            }
        }
        public void search(int val)
        {
            search(root, val);
        }
        public void search(Node p, int val)
        {
            while (p != null)
            {
                if (val < p.data)
                    p = p.left;
                else if (val > p.data)
                    p = p.right;
                else
                {
                    Console.WriteLine("Found");
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }
        public void searchRecursive(int val)
        {
            searchRecursive(root, val);
        }
        public void searchRecursive(Node p, int val)
        {
            if (p == null)
            {
                Console.WriteLine("Not Found");
                return;
            }
            if (val < p.data)
            {
                searchRecursive(p.left, val);
                return;
            }
            if (val > p.data)
            {
                searchRecursive(p.right, val);
                return;
            }
            Console.WriteLine("Found");
        }
        public int min()
        {
            return min(root);
        }
        public int min(Node p)
        {
            if (p == null)
                return int.MinValue;
            while (p.left != null)
                p = p.left;
            return p.data;
        }
        public int max()
        {
            return max(root);
        }
        public int max(Node p)
        {
            if (p == null)
                return int.MaxValue;
            while (p.right != null)
                p = p.right;
            return p.data;
        }
        public int minRecursive()
        {
            return minRecursive(root);
        }
        public int minRecursive(Node p)
        {
            if (p == null)
                return int.MinValue;
            if (p.left == null)
                return p.data;
            return minRecursive(p.left);
        }
        public int maxRecursive()
        {
            return maxRecursive(root);
        }
        public int maxRecursive(Node p)
        {
            if (p == null)
                return int.MaxValue;
            if (p.right == null)
                return p.data;
            return maxRecursive(p.right);
        }
    }
}