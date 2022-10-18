using System;

namespace Laboratory_A5
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] array_old = new int[]{1, 2, 3, 4, 5, 6};
            int[] array_ans = new int[array_old.Length];
            int m = 2;

            for (int i = 0; i < array_old.Length; i++)
            {
                array_ans[(i+m)%(array_old.Length)] = array_old[i];
            }

            for (int i = 0; i < array_ans.Length; i++)
            {
                Console.Write($"{array_ans[i]} ");
            }
            return 0;
            //yay, its done
        }
    }
}