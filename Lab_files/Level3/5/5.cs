using System;

namespace LaboratoryL3N5
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write($"n: ");
            string input_n = Console.ReadLine();
            if (!int.TryParse(input_n, out var n) || (n < 2))
            {
                Console.WriteLine("Invalid n");
                return 1;
            }

            double[] array = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Array_A[{i}]: ");
                string input_ai = Console.ReadLine();
                if (!double.TryParse(input_ai, out var a))
                {
                    Console.WriteLine("Invalid number");
                    return 1;
                }
                array[i] = a;
            }
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    double min = array[i];
                    for (int j = i + 1; j < n; j++)
                    {
                        if ((array[j] < min) && (j % 2 == 0))
                        {
                            min = array[j];
                            array[j] = array[i];
                            array[i] = min;
                        }
                    }
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]} ");
            }
            return 0;
        }
    }
}