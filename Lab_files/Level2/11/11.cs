using System;

namespace LaboratoryL2N11
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write($"n: ");
            string input_n = Console.ReadLine();
            if (!int.TryParse(input_n, out var n) || (n < 0))
            {
                Console.WriteLine("Invalid n");
                return 1;
            }
            
            //Variables
            double[] array = new double[n];
            int index = -1;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Array[{i}]: ");
                string input_ai = Console.ReadLine();
                if (!double.TryParse(input_ai, out var x))
                {
                    Console.WriteLine("Invalid number");
                    return 1;
                }
                if (x > 0)
                {
                    index = i;
                }
                array[i] = x;
            }
            
            if (index == -1)
            {
                Console.WriteLine("No positive numbers");
                return 1;
            }
            
            Console.Write($"P: ");
            string input_p = Console.ReadLine();
            if (!double.TryParse(input_p, out var p))
            {
                Console.WriteLine("Invalid p");
                return 1;
            }

            for (int i = 0; i < n; i++)
            {
                if (i == index)
                {
                    Console.Write($"{array[i]} ");
                    Console.Write($"{p} ");
                }
                else
                {
                    Console.Write($"{array[i]} ");
                }
            }
            return 0;
        }
    }
}