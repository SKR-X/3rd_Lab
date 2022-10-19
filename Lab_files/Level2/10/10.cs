using System;

namespace LaboratoryL2N10
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
            double min = 100000000000000;
            int index_min = -1;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Array[{i}]: ");
                string input_ai = Console.ReadLine();
                if (!double.TryParse(input_ai, out var x))
                {
                    Console.WriteLine("Invalid number");
                    return 1;
                }
                if (x > 0 && x < min)
                {
                    index_min = i;
                    min = x;
                }
                array[i] = x;
            }
            
            for (int i = 0; i < n; i++)
            {
                if (i != index_min)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            return 0;
        }
    }
}