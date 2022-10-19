using System;

namespace LaboratoryL3N1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write($"n: ");
            string input_n = Console.ReadLine();
            if (!int.TryParse(input_n, out var n) || (n < 1))
            {
                Console.WriteLine("Invalid n");
                return 1;
            }
            
            List<double> array_ans = new List<double>();
            double max = -100000000;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Array_A[{i}]: ");
                string input_ai = Console.ReadLine();
                if (!double.TryParse(input_ai, out var a))
                {
                    Console.WriteLine("Invalid number");
                    return 1;
                }
                
                if (a > max)
                {
                    array_ans.Clear(); //Doesn't change capacity ->
                    array_ans.TrimExcess(); //-> This method does
                    max = a;
                    array_ans.Add(i);
                }
                else if (a == max)
                {
                    array_ans.Add(i);
                }
            }
            
            int count = array_ans.Count();
            
            /* Wondering why this method doesnt work at all
            foreach (int i in array_ans)
            {
                Console.Write($"{array_ans[i]} ");
            }
            Unhandled exception. System.ArgumentOutOfRangeException: 
            Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')
            */

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array_ans[i]} ");
            }
            return 0;
        }
    }
}