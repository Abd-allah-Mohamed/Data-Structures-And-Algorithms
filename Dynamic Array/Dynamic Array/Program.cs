using System;

namespace Dynamic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray d1 = new DynamicArray(1);
            d1.Add(1); //size of array = 1
            d1.Add(1); //size of array = 2
            d1.Add(1); //size of array = 4
            d1.Add(1); //size of array = 4
            d1.Add(1); //size of array = 8
            d1.Print(); //print array elements
            d1.Find(2); // "2" not found
            Console.WriteLine();
            d1.Insert(2, 3); //put "2" in index 3
            d1.Print(); //print array elements
            d1.Find(2); //"2" found
        }
    }
    class DynamicArray
    {
        public int[] dynamic;
        public int last_index;
        public DynamicArray(int size)
        {
            if (size <= 0)
            {
                size = 1;
            }
            dynamic = new int[size];
            last_index = -1;
        }
        public void Add(int item)
        {
            if (last_index == dynamic.Length - 1)
            {
                Expand_Storage();
            }
            last_index++;
            dynamic[last_index] = item;
        }
        private void Expand_Storage()
        {
            int[] new_dynamic = new int[dynamic.Length * 2];
            Array.Copy(dynamic, new_dynamic, dynamic.Length);
            dynamic = new_dynamic;
        }
        public void Insert(int item, int index)
        {
            if (index >= 0 && index < dynamic.Length)
            {
                if (last_index == dynamic.Length - 1)
                {
                    Expand_Storage();
                }
                int segment_length = last_index - index + 1;
                Array.Copy(dynamic, index, dynamic, index + 1, segment_length);
                dynamic[index] = item;
                last_index++;
            }
            else
                Console.WriteLine("Invalid Index");
        }
        public void Print()
        {
            for (int i = 0; i <= last_index; i++)
            {
                Console.Write(dynamic[i] + " ");
            }
        }
        public void Find(int search)
        {
            for (int i = 0; i <= last_index; i++)
            {
                if (dynamic[i] == search)
                {
                    Console.WriteLine("found in index : {0}", i);
                    return;
                }
            }
            Console.WriteLine("not found");
        }
    }
}