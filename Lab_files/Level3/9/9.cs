using System;

namespace LaboratoryL3N9
{
    class Program
    {
        static double max(double max, double x)
        {
            if (max > x)
            {
                return max;
            }
            else
            {
                return x;
            }
        }
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
            
            int length = 1;
            double ans = 1;
            double number = array[0];
            bool flag = true;
            for (int i = 1; i < n; i++)
            {
                if (array[i] > number)
                {
                    if (flag == true)
                    {
                        length += 1;
                        ans = max(ans, length);
                        number = array[i];
                    }
                    else
                    {
                        flag = true;
                        length = 1;
                        number = array[i];
                    }
                }
                if (array[i] < number)
                {
                    if (flag == false)
                    {
                        length += 1;
                        ans = max(ans, length);
                        number = array[i];
                    }
                    else
                    {
                        flag = false;
                        length = 1;
                        number = array[i];
                    }
                }
            }
            
            Console.Write($"Ans: {ans}");
            return 0;
        }
    }
}