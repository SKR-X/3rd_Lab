using System;

namespace Laboratory_A1
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] array = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 10, 10};
            int start = 0;
            int end = array.Length - 1; 
            int key = 10;
            while (start <= end)  
            {  
                int mid = (start + end) / 2;  
                if (key == array[mid])  
                {  
                    Console.WriteLine($"Ans: {mid}");
                    return 0;  
                }  
                else if (key < array[mid])  
                {  
                    end = mid - 1;  
                }  
                else  
                {  
                    start = mid + 1;  
                }  
            }
            Console.WriteLine($"There's no {key}");
            return 1;  
        }
    }
}