using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Security.Cryptography;
using System.Xml.Schema;

class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the P: ");
        int P = Convert.ToInt32(Console.ReadLine());
        var mas = new List<int>();
        double sum = 0;
        double sred = 0;
        double znach;
        int k = 0;
        Console.WriteLine("Enter the array: ");
        for (int i=0; i<n; i++)
        {
            mas.Add(Convert.ToInt32(Console.ReadLine()));
        }
        for (int i = 0; i < n; i++)
        {
            if (mas[i] > 0) k = i;
        }
        mas.Insert(k+1, P);
        Console.WriteLine("New array: ");
        for (int i = 0; i < n+1; i++)
        {
            Console.Write(mas[i] + " ");
        }


        return 0;
    }
}