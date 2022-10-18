using System;

namespace LaboratoryL3N12
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = 12;

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

            List<double> ans = new List<double>();
            
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= 0)
                {
                    ans.Add(array[i]);
                }
            }
             
            int size = ans.Count();
            
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{ans[i]} ");
            }
            return 0;
        }
    }
}