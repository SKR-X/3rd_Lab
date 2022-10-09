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
        double max = 0;
        for (int i=0; i<n-1; i++)
        {
            if (A[i] > A[i+1]) { k++; }
            else
            {
                if (k > max) { max = k; k = 1; }
                k = 1;
            }
        }
        if (k > max) max = k;
        k = 1;
        for (int i = 0; i < n-1; i++)
        {
            if (A[i] < A[i + 1]) { k++; }
            else
            {
                if (k > max) { max = k; k = 1; }
                k = 1;
            }
        }
        if (k > max) max = k;
        Console.WriteLine("Longest sequence: " + max);


        return 0;
    }
}