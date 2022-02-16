using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order. ");
            int[] arr = { 50, 63, 183, 87, 90, 5, 15, 382 };

            Console.Write("This is the unsorted array: ");
            print(arr);

            Console.WriteLine("\nNow sorted: ");
            int[] sortedArray = BubbleSort(arr);

            print(sortedArray);
        }

        public static void print(int[] arr)
        {
            foreach (int x in arr)
                Console.Write(x + " ");
        }

        public static int[] BubbleSort(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j]<arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            return arr;
        }
    }
}
