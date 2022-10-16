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
        var A = new List<double>();
        var B = new List<int>();
        double sum = 0;
        double sred = 0;
        double k = 0;
        Console.WriteLine("Enter the first array: ");
        for (int i=0; i<n; i++)
        {
            A.Add(Convert.ToInt32(Console.ReadLine()));
        }
        double max = A.Max();
        for (int i=0; i<n; i++)
        {
            if (A[i] == max) { B.Add(i); k++; }
        }
        Console.WriteLine("Array of index maximum values: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(B[i] + " ");
        }


        return 0;
    }
}