using System;

namespace LaboratoryL1N11
{
    class Program
    {
        static int Main(string[] args)
        {
            List<double> ans = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"x{i}: ");
                string input_x = Console.ReadLine();
                if (!double.TryParse(input_x, out var x))
                {
                    Console.WriteLine("Invalid data");
                    return 1;
                }
                
                if (x > 0)
                {
                    ans.Add(x);
                }
            }

            for (int i = 0; i < ans.Count; i++)
            {
                Console.WriteLine($"{ans[i]} ");
            }
            return 0;
        }
    }
}