using System;

namespace sda_csharp_exercises
{
    class Program
    {
        //Napisz funkcję tworzącą ciąg arytmetyczny o podanych:
        //długości, pierwszym elemencie, różnicy ciągu.
        //np: 4, 0, 3 -> 0 3 6 9
        static void Main(string[] args)
        {
            Console.Write("Ciąg {4, 0, 3}\n");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(ArithmeticSequence(4, 0, 3)[i] + " "); //result 0 3 6 9
            }

            Console.Write("Ciąg {3, 5, -3}\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ArithmeticSequence(3, 5, -3)[i] + " "); //result 5 2 -1
            }

            Console.Write("Ciąg {10, -20, 5}\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ArithmeticSequence(10, -20, 5)[i] + " "); //result -20 -15 -10 -5 0 5 10 15 20 25
            }

        }
        public static int[] ArithmeticSequence(int length, int firstElement, int difference)
        {
            int[] sequence = new int[length];


            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    sequence[i] = firstElement;
                }
                else
                {
                    sequence[i] = sequence[i-1] + difference;
                }
            }
            return sequence;
        }
    }
}