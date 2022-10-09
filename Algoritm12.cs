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
        Console.WriteLine("Enter the size of first array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the size of second array: ");
        int m = Convert.ToInt32(Console.ReadLine());
        var A = new List<double>();
        var B = new List<double>();
        var C = new List<double>();
        double sum = 0;
        double sred = 0;
        int k = 0;
        bool b = false;
        int t = 0;
        int x = 0;
        int LB = 0;
        int LA = 0;
        Console.WriteLine("Enter the first array: ");
        for (int i=0; i<n; i++)
        {
            A.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.WriteLine("Enter the second array: ");
        for (int i = 0; i < m; i++)
        {
            B.Add(Convert.ToInt32(Console.ReadLine()));
        }
        LB = B.Count();
        LA = A.Count();
        if (LB > LA)
        {
            for (int i = 0; i < LA; i++)
            {
                C.Add(A[i]);
                C.Add(B[i]);
            }
            t = 1;
        }
        else
        {
            for (int i = 0; i < LB; i++)
            {
                C.Add(A[i]);
                C.Add(B[i]);
            }
            t = 2;
        }
        if (t == 1)
        {
            for (int i = 0; i < LB-LA; i++)
            {
                C.Add(B[i]);
            }
        }
        if (t == 2)
        {
            for (int i = 0; i < LA - LB; i++)
            {
                C.Add(A[i]);
            }
        }
        Console.WriteLine("The new array: ");
        for (int i=0; i<n+m; i++)
        {
            Console.WriteLine(C[i]);
        }
        return 0;
    }
}