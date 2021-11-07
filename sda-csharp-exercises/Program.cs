using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle(3);
            Console.WriteLine();
            DrawTriangle(5);
        }

        public static void DrawTriangle(int lines, char sign = '*')
        {
            string line = "";
            for (int i = 1; i <= lines; i++)
            {
                line += sign.ToString();
                Console.WriteLine(line);
            }
            for (int i = lines; i > 0; i--)
            {
                line = line.Remove(i-1, 1);
                Console.WriteLine(line);
            }
        }
    }
}
