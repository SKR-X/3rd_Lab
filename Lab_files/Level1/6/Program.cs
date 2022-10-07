using System;

namespace LaboratoryL1N6
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 5;
            double L = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"x{i}: ");
                string input_x = Console.ReadLine();
                if (!double.TryParse(input_x, out var x))
                {
                    Console.WriteLine("Invalid data");
                    return 1;
                }
                L += x*x;
            }
            L = Math.Sqrt(L);
            Console.WriteLine($"Answer: {L}");
            return 0;
        }
    }
}