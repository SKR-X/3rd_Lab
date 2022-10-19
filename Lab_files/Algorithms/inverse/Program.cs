using System;

namespace Laboratory_A4
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] array_even = new int[]{1, 2, 3, 4, 5, 6};
            int[] array_odd = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9};

            for (int i = 0; i < (array_even.Length / 2); i++)
            {
                int temp = array_even[i];
                array_even[i] = array_even[array_even.Length - 1 - i];
                array_even[array_even.Length - 1 - i] = temp;
            }

            for (int i = 0; i < (array_odd.Length / 2); i++)
            {
                int temp = array_odd[i];
                array_odd[i] = array_odd[array_odd.Length - 1 - i];
                array_odd[array_odd.Length - 1 - i] = temp;
            }

            for (int i = 0; i < array_even.Length; i++)
            {
                Console.Write($"{array_even[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < array_odd.Length; i++)
            {
                Console.Write($"{array_odd[i]} ");
            }
            return 0;
        }
    }
}