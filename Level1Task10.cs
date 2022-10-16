using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        double[] mas = new double[10];
        double n = 10;
        double lenght = 0;
        Console.WriteLine("Enter the lower limit of the check: ");
        double P = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the upper bound of the check: ");
        double Q = Convert.ToDouble(Console.ReadLine());
        double count = 0;
        //n = Convert.ToDouble(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a member of the array: ");
            mas[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (mas[i] > P && mas[i] < Q) count++;
        }
        Console.WriteLine("The number of sequence elements enclosed between P and Q: " + count);
        return 0;
    }
}