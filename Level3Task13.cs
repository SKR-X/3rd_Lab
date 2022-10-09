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
        var C = new List<int>();
        double sum = 0;
        double sred = 0;
        int k = 0;
        bool b = false;
        int t = 0;
        Console.WriteLine("Enter the array: ");
        for (int i=0; i<n; i++)
        {
            A.Add(Convert.ToInt32(Console.ReadLine()));
        }
        for (int i=0; i<n; i++)
        {
            if (B.Contains(A[i]) == true)
            {
                C.Add(i);
            }
            if (B.Contains(A[i]) == false)
            {
                B.Add( A[i]);
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (C.Contains(i+t) == true) {A.RemoveAt(i); n--;  t++; i--; }
        }
        for (int i=0; i<n; i++)
        {
            Console.Write(A[i] + " ");
        }



        return 0;
    }
}