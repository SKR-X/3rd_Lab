using System;

namespace LaboratoryL1N10
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write($"P (P < 9): ");
            string input_p = Console.ReadLine();
            if ((!double.TryParse(input_p, out var p)) || (p < 0) || (p > 8))
            {
                Console.WriteLine("Invalid data");
                return 1;
            }

            Console.Write($"Q (Q <= 9 && Q > P): ");
            string input_q = Console.ReadLine();
            if ((!double.TryParse(input_q, out var q)) || (p > q) || (q < 0) || (q > 9))
            {
                Console.WriteLine("Invalid data");
                return 1;
            }

            int ans = 0;
            for (int i = 0; i < 10; i++)
            {
                if ((i >= p) && (i <= q))
                {
                    ans++;
                }
            }
            Console.WriteLine($"Answer: {ans}");
            return 1;
        }
    }
}