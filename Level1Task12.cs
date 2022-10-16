using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        int n = 8;
        double[] mas = new double[n];
        double[] polo = new double[10];
        int k = 0;
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
            if (mas[i] < 0) { znach = mas[i]; nomer = i; }
        }
        Console.WriteLine("The number of the last negative element of the array = " + nomer + ", its value = " + znach);

        return 0;
    }
}