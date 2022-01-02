using System;

namespace InsertionSort
{
    class Program
    {     //Reads in strings and prints them in sorted order using insertion sort.
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 23, 9, 85, 12, 99 };
            int n = 5, i, j, val, flag;
            Console.WriteLine("Insertion Sort");
            Console.WriteLine("Intial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
