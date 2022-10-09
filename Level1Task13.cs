using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        int n = 10;
        double[] mas = new double[n];
        double[] chet = new double[5];
        double[] nechet = new double[5];
        int k = 0;
        int p = 0;
        double znach = 0;
        double nomer = 0;
        double lenght = 0;
        Console.WriteLine("Enter the array elements: ");
        for (int i=0; i<n; i++)
        {
            mas[i]=Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0) { chet[k] = mas[i]; k++; }
            else { nechet[p] = mas[i]; p++; }
        }
        Console.WriteLine("Array of values with even numbers: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(chet[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("An array of values with odd numbers: ");
        for (int i = 0; i < p; i++)
        {
            Console.Write(nechet[i] + " ");
        }
        return 0;
    }
}