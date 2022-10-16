using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        double[] mas = new double[10];
        double[] polo = new double[10];
        double n = 10;
        int k = 0;
        double lenght = 0;
        Console.WriteLine("Enter the array elements: ");
        for (int i=0; i<n; i++)
        {
            mas[i]=Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {

            if (mas[i] >= 0) {polo[k] = mas[i]; k++; }
        }
        Console.WriteLine("Positive elements of the array: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(polo[i] + " ");
        }
        return 0;
    }
}