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
        Console.WriteLine("Enter the K: ");
        int k = Convert.ToInt32(Console.ReadLine());
        var A = new List<int>();
        var B = new List<int>();
        double sum = 0;
        double sred = 0;
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
        A.InsertRange(k, B);
        Console.WriteLine("New array: ");
        for (int i = 0; i < n+m; i++)
        {
            Console.Write(A[i] + " ");
        }


        return 0;
    }
}