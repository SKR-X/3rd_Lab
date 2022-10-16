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
        int x = 0;
        Console.WriteLine("Enter the desired value: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the array: ");
        for (int i=0; i<n; i++)
        {
            A.Add(Convert.ToInt32(Console.ReadLine()));
        }
        k = n / 2 - 1;
        for (int i=0; i<n; i++)
        {
            if (A[k] == x) { Console.WriteLine("The index of desired value: " + k); t++; break; }
            if (A[k] > x) k = (n - k) / 2;
            if (A[k] < x) k = k / 2;

        }
        if (t == 0) { Console.WriteLine("There is no desired value."); }



        return 0;
    }
}