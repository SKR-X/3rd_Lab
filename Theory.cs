using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1.5

            Console.WriteLine("Task 1.5");
            int n = 5;
            double sum = 0;
            double answer = 0;
            double[] mas = new double[n];
            Console.WriteLine("Write 5 numbers");
            for (int i = 0; i < n; i++)
            {
                mas[i] = double.Parse(Console.ReadLine());
                sum += mas[i] * mas[i];
            }
            answer = Math.Sqrt(sum);
            Console.WriteLine("answer {0:f4}", answer);

            #endregion
            #region task 1.10
            Console.WriteLine("task 1.10");
            Console.WriteLine("Write P and Q");
            double P, Q;
            P = double.Parse(Console.ReadLine());
            Q = double.Parse(Console.ReadLine());
            double swap = 0;
            if (P > Q)
            {
                swap = Q;
                Q = P;
                P = swap;
            }
            int kol = 0;
            n = 10;
            double[] mas2 = new double[n];
            Console.WriteLine("Write 10 numbers in mas");
            for (int i = 0; i < n; i++)
            {
                mas2[i] = double.Parse(Console.ReadLine());
                if (P < mas2[i] && mas2[i] < Q)
                {
                    kol += 1;
                }
            }
            Console.WriteLine("answer - {0:f4}", kol);
            #endregion
            #region task 1.11
            Console.WriteLine("task 1.11");
            Console.WriteLine("Write 10 numbers of mas");
            mas = new double[n];
            mas2 = new double[n];
            kol = 0;
            for (int i = 0; i < n; i++)
            {
                mas[i] = double.Parse(Console.ReadLine());
                if (mas[i] > 0)
                {
                    mas2[kol] = mas[i];
                    kol += 1;
                }
            }
            Console.WriteLine("mas with only positive numbers");
            for (int i = 0; i < kol; i++)
            {
                Console.WriteLine(mas2[i]);
            }
            #endregion
            #region task 1.12
            Console.WriteLine("task 1.12");
            n = 8;
            int nomer = -1;
            double znach = 0;
            Console.WriteLine("Write numbers of mas");
            mas = new double[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = double.Parse(Console.ReadLine());
                if (mas[i] < 0)
                {
                    znach = mas[i];
                    nomer = i;
                }
            }
                if (nomer == -1)
                {
                    Console.WriteLine("No numbers");
                }
                else
                {
                    Console.WriteLine($"answer, value - {znach} , index - {nomer}");
                }

            #endregion
            #region task 1.13
            Console.WriteLine("task 1.13");
            Console.WriteLine("Write 10 numbers of mas");
            n = 10;
            mas = new double[n];
            int b = 5;
            int j = 0;
            int z = 0;
            mas2 = new double[b];
            double[] mas3 = new double[b];
            for (int i=0; i<n;i++)
            {
                mas[i] = double.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    mas2[j] = mas[i];
                    j += 1;
                }
                else
                {
                    mas3[z] = mas[i];
                    z += 1;
                }
            }
            Console.WriteLine("Mas with even index");
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(mas2[i]);
            }
            Console.WriteLine("Mas with odd index");
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(mas3[i]);
            }
            #endregion
            #region task 2.5
            Console.WriteLine("task 2.5");
            Console.WriteLine("Write size of mas");
            int N = int.Parse(Console.ReadLine());
            mas = new double[N];
            double[] masotr = new double[N];
            kol = 0;
            double max=0;
            int a = 0;
            b = 0;
            double min=0;
            Console.WriteLine("Write numbers in mas");
            for (int i=0;i<N;i++)
            {
                mas[i] = double.Parse(Console.ReadLine());
                if (i==0)
                {
                    max = mas[i];
                    min = mas[i];
                    a = i;
                    b = i;
                }
                if (mas[i]>max)
                {
                    max = mas[i];
                    a = i;
                }
                if (mas[i] < min)
                {
                    min = mas[i];
                    b = i;
                }
            }
            Console.WriteLine("Mas with negative numbers");
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    if (mas[i] < 0)
                    {
                        masotr[kol] = mas[i];
                        Console.WriteLine(masotr[kol]);
                        kol += 1;
                    }
                }

            }
            else if (a > b)
            {
                for (int i = b + 1; i < a; i++)
                {
                    if (mas[i] < 0)
                    {
                        masotr[kol] = mas[i];
                        Console.WriteLine(masotr[kol]);
                        kol += 1;
                    }
                }
            }
            else
            {
                Console.WriteLine("No answer");
            }
            #endregion
            #region task 2.6
            Console.WriteLine("Task 2.6");
            Console.WriteLine("Write P and amount of numbers in mas");
            P = double.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            mas = new double[n];
            sum = 0;
            double sred = 0;
            for(int i=0;i<n;i++)
            {
                mas[i] = double.Parse(Console.ReadLine());
                sum += mas[i];
            }
            sred = sum / n;
            min = Math.Abs(sred-mas[0]);
            for (int i=1;i<n;i++)
            {
                if (Math.Abs(sred - mas[i]) < min) ;
                {
                    a = i;
                    min = (Math.Abs(sred - mas[i]));
                }
            }
            for(int i=n-1;i>a;i--)
            {
                mas[i] = mas[i - 1];
            }
            mas[a + 1] = P;
            Console.WriteLine("mas with P");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(mas[i]);
            }
            #endregion
        }
    }
}
