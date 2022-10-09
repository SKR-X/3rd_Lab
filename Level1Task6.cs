using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        double[] mas = new double[5];
        double n = 5;
        double lenght = 0;
        //n = Convert.ToDouble(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the coordinate number " + (i + 1) + " :");
            mas[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            mas[i] = mas[i] * mas[i];
        }
        for (int i = 0; i < n; i++)
        {
            lenght = lenght + mas[i];
        }
        lenght = Math.Sqrt(lenght);
        Console.WriteLine("The lenght of vector: " + lenght);
        return 0;
    }
}