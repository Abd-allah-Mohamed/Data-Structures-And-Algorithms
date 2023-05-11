using System;

namespace Quick_Sort
{
    class QuickSort
    {
        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Quick Sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            quickSort(arr, 0, n - 1);

            Console.Write("\nSorted Array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}