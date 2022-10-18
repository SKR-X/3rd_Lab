using System;

namespace LaboratoryL2N5
{
    class Program
    {
        /* Stuff i've wanted to learn on c# (but i found out that it's useless in c# in any way)
        static unsafe void swap(double *min, double *max, double x, int index, int *index_min, int *index_max)
        {
            if (x < min)
            {
                *min = x;
                *index_min = index;
            }
            if (x > max)
            {
                *max = x;
                *index_max = index;
            }
        }
        */
        static int Main(string[] args)
        {
            Console.Write($"n: ");
            string input_n = Console.ReadLine();
            if (!int.TryParse(input_n, out var n) || (n < 3))
            {
                Console.WriteLine("Invalid n");
                return 1;
            }
            
            //Variables
            double[] array = new double[n];
            double min = 100000000000000;
            double max = -100000000000000;
            int index_min = -1, index_max = -1;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Array[{i}]: ");
                string input_ai = Console.ReadLine();
                if (!double.TryParse(input_ai, out var x))
                {
                    Console.WriteLine("Invalid number");
                    return 1;
                }

                //swap(&min, &max, x, i, &index_min, &index_max);
                if (x < min)
                {
                    min = x;
                    index_min = i;
                }
                if (x > max)
                {
                    max = x;
                    index_max = i;
                }

                array[i] = x;
            }

            //min number can easily be after the max one
            //We doing it for easy iteration in the new array
            if (index_min > index_max)
            {
                int tmp = index_max;
                index_max = index_min;
                index_min = tmp;
            }
            
            //Final array with a new size
            n = (index_max - index_min + 1);
            double[] array_new = new double[n];
            
            //
            for (int i = 0; i < n; i++)
            {
                array_new[i] = array[index_min + i];
            }
            
            //Printing out new array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(-Math.Abs(array_new[i]));
            }
            return 0;
        }
   }
}