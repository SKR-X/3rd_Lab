using System;

namespace LaboratoryL2N15
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
            
            List<double> array_a = new List<double>(n);
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Array_A[{i}]: ");
                string input_ai = Console.ReadLine();
                if (!double.TryParse(input_ai, out var a))
                {
                    Console.WriteLine("Invalid number");
                    return 1;
                }
                array_a.Add(a);
            }

            Console.Write($"m: ");
            string input_m = Console.ReadLine();
            if (!int.TryParse(input_m, out var m) || (m < -1))
            {
                Console.WriteLine("Invalid m");
                return 1;
            }
            
            List<double> array_b = new List<double>(m);
            
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Array_B[{i}]: ");
                string input_bi = Console.ReadLine();
                if (!double.TryParse(input_bi, out var b))
                {
                    Console.WriteLine("Invalid number");
                    return 1;
                }
                array_b.Add(b);
            }
            
            Console.Write($"k: ");
            string input_k = Console.ReadLine();
            if (!int.TryParse(input_k, out var k) || (k > n-2) || (k < -1))
            {
                Console.WriteLine("Invalid k");
                return 1;
            }
            
           array_a.InsertRange(k + 1, array_b);
            
            for (int i = 0; i < n+m; i++)
            {
                Console.Write($"{array_a[i]} ");
            }
            return 0;
        }
    }
}