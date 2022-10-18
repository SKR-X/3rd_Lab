using System;

namespace LaboratoryL2N6
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

            double sum = 0;
            List<double> array = new List<double>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Array[{i}]: ");
                string input_ai = Console.ReadLine();
                if (!double.TryParse(input_ai, out var x))
                {
                    Console.WriteLine("Invalid number");
                    return 1;
                }
                sum += x;
                array.Add(x);
            }

            double average = (sum / n);

            Console.Write($"P: ");
            string input_p = Console.ReadLine();
            if (!double.TryParse(input_p, out var p))
            {
                Console.WriteLine("P is invalid value");
                return 1;
            }

            double diff = 100000000000000;
            int index_avg = 0; 
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(array[i] - average) < diff)
                {
                    index_avg = i;
                    diff = Math.Abs(array[i] - average);
                }
                
            }

            array.Insert(index_avg + 1, p);
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write($"{array[i]} ");
            }
            return 0;
        }
    }
}
