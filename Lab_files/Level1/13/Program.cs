using System;

namespace LaboratoryL1N13
{
    class Program
    {
        static int Main(string[] args)
        {
            double[,] arrays = new double[2,5];
            int l = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"x{i}: ");
                string input_x = Console.ReadLine();
                if (!double.TryParse(input_x, out var x))
                {
                    Console.WriteLine("Invalid data");
                    return 1;
                }
                arrays[(i % 2), l] = x;
                l += (i % 2);
            }

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"{i+1} array: ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{arrays[i, j]} ");
                }
                Console.Write("\n");
            }
            return 0;
        }
    }
}