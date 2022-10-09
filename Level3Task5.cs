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
        var B = new List<double>();
        double sum = 0;
        double sred = 0;
        int k = 0;
        Console.WriteLine("Enter the array: ");
        for (int i=0; i<n; i++)
        {
            A.Add(Convert.ToInt32(Console.ReadLine()));
        }
        double max = A.Max() + 1;
        for (int i=0; i<n; i++)
        {
            if (i%2==0) { B.Add(A[i]);}
            else { B.Add(max);}
        }
        B.Sort();
        for (int i=0; i<n; i++)
        {
            if (i%2==0) { A[i] = B[k]; k++; }
            
        }
        Console.WriteLine("New array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(A[i] + " ");
        }


        return 0;
    }
}