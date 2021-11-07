using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 8, 4, 6, 5, 7, 9, 3 };
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine("\nSorted array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(BubbleSort(arr)[i]); //niezoptymalizowane
            }

        }
        public static int[] BubbleSort(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
