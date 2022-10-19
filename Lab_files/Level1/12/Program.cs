using System;

namespace LaboratoryL1N12
{
    class Program
    {
        static int Main(string[] args)
        {
            double[] ans = new double[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"x{i}: ");
                string input_x = Console.ReadLine();
                if (!double.TryParse(input_x, out var x))
                {
                    Console.WriteLine("Invalid data");
                    return 1;
                }
                ans[i] = x;
            }

            for (int i = 7; i >= 0; i--)
            {
                if (ans[i] < 0)
                {
                    Console.WriteLine($"Last negative number: {ans[i]}, index: {i}");
                    return 0;
                }
            }
            
            Console.WriteLine("Didnt find any negative numbers");
            return 0;
        }
    }
}