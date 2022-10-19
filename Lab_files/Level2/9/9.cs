using System;

namespace LaboratoryL2N9
{
    class Program
    {
        static int Main(string[] args)
        {
            //Absurd solution for this task (Probably)
            //Length of the array
            Console.Write($"n: ");
            string input_n = Console.ReadLine();
            if (!int.TryParse(input_n, out var n) || (n < 3))
            {
                Console.WriteLine("Invalid n");
                return 1;
            }
            
            double ans = 0;
            double[] p_sums = new double[n+1];
            //Prefix sum for the first(0) element is always zero
            p_sums[0] = 0;

            //First element of the array
            Console.Write("Array[0]: ");
            string input_x = Console.ReadLine();
            if (!double.TryParse(input_x, out var one))
            {
                Console.WriteLine("Invalid number");
                return 1;
            }
            
            //Prefix sum for second element is 0 + array[0]
            p_sums[1] = one;
            double min = one, max = one;
            int index_min = 0, index_max = 0;

            for (int i = 1; i < n; i++)
            {
                //Array[i] input
                Console.Write($"Array[{i}]: ");
                string input_ai = Console.ReadLine();
                if (!double.TryParse(input_ai, out var x))
                {
                    Console.WriteLine("Invalid number");
                    return 1;
                }
                
                //Prefix sum for i+1
                p_sums[i+1] = p_sums[i] + x;
                
                //If the entered x is greater than current max
                if (x > max)
                {
                    //Change max
                    max = x;
                    //Change index for this element
                    index_max = i;
                }
                if (x < min)
                {
                    min = x;
                    index_min = i;
                }
                //Ans is sum between index_max and index_min / amount
                ans = (p_sums[i+1] - min - max) / (Math.Abs(index_max - index_min) - 1);
            }
            Console.WriteLine($"Ans: {ans}, min {min}, max {max}, index_first {index_min}, index_last {index_max}");
            return 0;
        }
    }
}