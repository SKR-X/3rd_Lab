using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task0_15();
        }
        static void task1_6()
        {
            double[] a = new double[6] { 2, 4, 5, 6, 10, 11};
            double L = 0;
            foreach (double i in a)
            {
                L += Math.Pow(i, 2);
            }
            Console.WriteLine(Math.Sqrt(L));
        }
        static void task1_10()
        {
            double[] a = new double[10] { 2, 4, 5, 7, 6, 3, 8, 12, 16, 14 };
            int count = 0;
            Console.WriteLine("Enter P and Q (P < Q)");
            if (double.TryParse(Console.ReadLine(), out double P) && (double.TryParse(Console.ReadLine(), out double Q)) && (P < Q))
            {
                foreach (double i in a)
                {
                    if ((i > P) && (i < Q))
                    {
                        count++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine($"{count} array elements enclosed between P and Q");
        }
        static void task1_11()
        {
            double[] a = new double[10] { 2, 4, 5, -7, 6, -3, 8, -12, 16, -14 };
            int k = 0, k1 = 0;
            foreach (double i in a)
            {
                if (i > 0)
                {
                    k1++;
                }
            }
            double[] b = new double[k1];
            foreach (double i in a)
            {
                if (i > 0)
                {
                    b[k] = i;
                    Console.Write(b[k]);
                    Console.Write(" ");
                    k++;
                }
            }
        }
        static void task1_12()
        {
            double[] a = new double[8] {-2, 5, 6, 7, -9, 10, 12, -14};
            int p = 0;
            for (int i = 0;i < 8; i++)
            {
                if (a[i] < 0)
                {
                    p = i;
                }
            }
            Console.WriteLine($"Value = {a[p]}, number = {p + 1}");
        }
        static void task1_13()
        {
            double[] a = new double[10] { 2, 4, 5, 7, 6, 3, 8, 12, 16, 14 };
            double[] b = new double[5];
            double[] c = new double[5];
            var count = 0;
            var count1 = 0;
            for (int i = 0;i < 10;i++)
            { 
                if (i % 2 == 0)
                    {
                    b[count] = a[i];
                    count++;
                    }
                else
                {
                    c[count1] = a[i];
                    count1++;
                }
            }
            for (int i = 0; i < 5; i++) 
            {
                Console.Write(b[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++) 
            {
                Console.Write(c[i]);
                Console.Write(" ");
            }
        }
        static void task2_5()
        {
            double[] a = new double[8] { -15, 5, -6, -7, -8, 9, 10, 15 };
            double p = 0, l = 0;
            int c = 0,p1 = 0 ,l1 = 0;
            for (int i = 0;i < 8; i++)
            {
                if (p > a[i])
                {
                    p = a[i];
                    p1 = i;
                }
                if (l < a[i])
                {
                    l = a[i];
                    l1 = i;
                }
                if (a[i] < 0) c++;
            }
            if (c == 0) { Console.WriteLine("There are no '-' elem in array"); return; }
            int j = 0;
            double[] b = new double[c - 1];
            for (int i = p1 + 1; i < l1;i++)
            {
                if (j == c - 1) break;
                if (a[i] < 0)
                {
                    b[j] = a[i];
                    Console.Write(b[j]);
                    Console.Write(" ");
                    j++;
                    
                }
            }
        }
        static void task2_6()
        {
            double[] a = new double[8] {-15, 5, -6, -7, -8, 9, 10, 15};
            double sr = 0;
            foreach(double x in a)
            {
                sr += x;
            }
            int number = 0;
            double margin = 1000000;
            sr = sr / a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                if (sr + Math.Abs(a[i]) < margin)
                {
                    margin = sr + Math.Abs(a[i]);
                    number = i;
                }
            }
            Console.WriteLine("Enter a number P");
            Array.Resize(ref a, 9);
            if (double.TryParse(Console.ReadLine(), out double P))
            {
                for (int i = a.Length - number; i >= number + 1; i--)
                {
                    a[i] = a[i - 1];
                }
                a[number + 1] = P;


                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i]);
                    Console.Write(" ");
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Error");
        }
        static void task2_9()
        {
            double[] a = new double[8] { -15, 5, -6, -7, -8, 9, 15, 10 };
            double sr = 0;
            int min = 0, max = 0;
            double min1 = 0, max1 = 0;
            for (int i = 0; i < 8;i++)
            {
                if (min1 > a[i])
                {
                    min1 = a[i];
                    min = i;
                }
                if (max1 < a[i])
                {
                    max1 = a[i];
                    max = i;
                }
            }
            int count = 0;
            for (int i = a.Length - (a.Length - max); i >= min + 1; i--)
            {
                sr += a[i];
                count++;
            }
            Console.WriteLine(sr / count);
        }
        static void task2_10()
        {
            double[] a = new double[8] { -15, 5, -6, -7, -8, 9, 15, 10 };
            int min = 0;
            double min1 = 1000000;
            for (int j = 0; j < 8; j++)
            {
                if (min1 > a[j] && a[j] > 0)
                {
                    min1 = a[j];
                    min = j;
                }
            }
            for (int i = min; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            for (int k = 0; k < a.Length - min; k++)
            {
                Console.Write(a[k]);
                Console.Write(" ");
            }
        }
        static void task2_11()
        {
            double[] a = new double[8] { -15, 5, -6, -7, -8, 9, -15, -10 };
            int max = 0;
            double max1 = 0;
            for (int j = 0; j < 8; j++) 
            {
                if (max < a[j] && a[j] > 0)
                {
                    max = j;
                    max1 = a[j];
                }
            }
            Array.Resize(ref a, 9);
            Console.WriteLine("Enter a number P");
            if (double.TryParse(Console.ReadLine(),out double P))
            {
                for (int i = a.Length - 1; i >= max + 1; i--)
                {
                    a[i] = a[i - 1];
                }
                a[max + 1] = P;
            }
            else
            {
                Console.WriteLine("Error");
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
                Console.WriteLine();
            }
        }
        static void task2_13()
        {
            double[] a = new double[8] { -15, 5, -6, -7, 8, 9, -15, -10 };
            double max = 0;
            int max1 = 0;
            for (int i = 0; i < 8; i++)
            {
                if (max < a[i] && i % 2 == 0)
                {
                    max = a[i];
                    max1 = i;
                }
            }
            a[max1] = max1;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
                Console.WriteLine();
            }
        }
        static void task2_15()
        {
            double[] a = new double[8] { -15, 5, -6, -7, 8, 9, -15, -10 };
            double[] b = new double[3] {2, -4, 8 };
            int l = 0;
            double[] c = new double[a.Length + b.Length];
            Console.WriteLine("Enter a number K from 0 to 7");
            //Array.Resize(ref a, a.Length + b.Length);
            if (int.TryParse(Console.ReadLine(), out int K) && K >= 0)
            {
                for (int i = 0; i < K + 1; i++)
                {
                    c[i] = a[i];
                    Console.WriteLine(c[i]);
                }
                for (int j = K + 1; j < K + 1 + b.Length;j++)
                {
                    c[j] = b[l];
                    Console.WriteLine(c[j]);
                    l++;
                }
                l = K + 1;
                for (int k = K + 1 + b.Length; k < c.Length; k++) 
                {
                    c[k] = a[l];
                    Console.WriteLine(c[k]);
                    l++;
                }
            }
            else
                Console.WriteLine("Error");
        }
        static void task3_1()
        {
            double[] a = new double[10] { 3, 12, 5, 6, 7, 12, 12, 12, 11, 12 };
            double[] b = new double[0];
            int p = 0;
            double max = 0;
            for (p = 0; p < a.Length; p++)
            {
                if (max < a[p])
                {
                    max = a[p];
                    b = new double[1];
                    b[b.Length - 1] = p;
                }
                else if (max == a[p])
                {
                    Array.Resize(ref b,b.Length + 1);
                    b[b.Length - 1] = p;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
                Console.Write(" ");
                Console.WriteLine();
            }

        }
        static void task3_5()
        {
            double amin = 100000000;
            int imin = 0;
            double[] a = new double[10] {0,1,2,3,5,6,4,7,8,9};
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    amin = a[i];
                    imin = i;
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[j] < amin)
                        {
                            amin = a[j];
                            imin = j;
                        }
                    }
                    a[imin] = a[i];
                    a[i] = amin;
                }
            }
            for (int i = 0; i < a.Length;i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
            }
        }
        static void task3_8()
        {
            double[] a = new double[8] { -12, 5, -6, -7, 8, 9, -15, -10 };
            int[] b = new int[0];
            double[] c = new double[0];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    Array.Resize(ref c, c.Length + 1);
                    Array.Resize(ref b, b.Length + 1);
                    b[k] = i;
                    c[k] = a[i];
                    k++;
                }
            }
            Array.Sort(c);
            Array.Reverse(c);
            for (int i = 0; i < b.Length; i++)
            {
                a[b[i]] = c[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
            }
        }
        static void task3_9()
        {
            double[] a = new double[8] { -1, 12, 11, 10, 9, 10, 9, 10 };
            int count = 1, count1 = 1;
            int max1 = 0, max2 = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    count++;
                    max1 = Math.Max(max1, count);
                    count1 = 1;
                    continue;
                }
                if (a[i] < a[i + 1])
                {
                    count1++;
                    max2 = Math.Max(max2, count1);
                    count = 1;
                    continue;
                }
                max1 = Math.Max(max1, count);
                max2 = Math.Max(max2, count1);
                count = 1;
                count1 = 1;
            }
            Console.WriteLine(Math.Max(max1,max2));
        }
        static void task3_12()
        {
            double[] a = new double[12] { -12, 5, 6, -7, 8, 9, 15, -10, 4 , 1, 9, 14};
            a = Array.FindAll(a, x => x > 0);
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
        static void task3_13()
        {
            double[] a = new double[12] { -12, 5, 4, -7, 8, -7, 15, -12, 4, 1, -12, 14 };
            var b = new HashSet<double>();
            foreach (var x in a)
            {
                if (!b.Contains(x))
                {
                    b.Add(x);
                }
            }
            Array.Resize(ref a, b.Count);
            a = b.ToArray();
            foreach (var x in a)
                Console.WriteLine("{0} ", x);
        }
        static void task0_11()
        {
            double[] a = new double[12] {1,2,3,4,5,6,7,8,9,10,11,12};
            Array.Sort(a);
            bool f = false;
            int l = 0, r = a.Length - 1;
            int t = (l + r) / 2;
            Console.WriteLine("Enter the desired element");
            if (double.TryParse(Console.ReadLine(),out double x))
            {
                while (r - l != 1)
                    {
                    if (a[t] == x)
                    {
                        f = true;
                        Console.WriteLine(t);
                        break;
                    }
                    else if (a[t] > x) 
                    {
                        r = t;
                        t = (l + r) / 2;
                    }
                    else
                    {
                        l = t;
                        t = (l + r) / 2;
                    }
                    }
                if (a[l] == x)
                {
                    Console.WriteLine(l);
                    f = true;
                }
                else if (a[r] == x)
                {
                    Console.WriteLine(r);
                    f = true;
                }
                if (!f) Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine("Error");
            }
    }
        static void task0_12()
        {
            double[] a = new double[5] { 0, 2, 4, 6, 8};
            double[] b = new double[7] { 1,3,5,7,9,11,13};
            double[] c = new double[a.Length + b.Length];
            int p = 0, k = 0;
            if (b.Length < a.Length)
            {
                for (int i = 0; i < b.Length * 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        c[i] = a[p];
                        p++;
                    }
                    else
                    {
                        c[i] = b[k];
                        k++;
                    }
                }
                for (int i = b.Length * 2; i < c.Length;i++)
                {
                    c[i] = a[p];
                    p++;
                }
                foreach (int i in c)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 0; i < a.Length * 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        c[i] = a[p];
                        p++;
                    }
                    else
                    {
                        c[i] = b[k];
                        k++;
                    }
                }
                for (int i = a.Length * 2; i < c.Length; i++)
                {
                    c[i] = b[p];
                    p++;
                }
                foreach (int i in c)
                {
                    Console.WriteLine(i);
                }
            }

        }
        static void task0_13()
        {
            double[] a = new double[5] { 0, -2, 4, 6, 8 };
            double[] b = new double[7] { 1, 3, 5, 7, 9, 11, 13 };
            double[] c = new double[a.Length + b.Length];
            int k = 0,p = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[k];
                k++;
            }
            for (int i = k; i < c.Length; i++)
            {
                c[i] = b[p];
                p++;
            }
            Array.Sort(c);
            Array.Reverse(c);
            foreach(int i in c)
            {
                Console.WriteLine(i);
            }

        }
        static void task0_14()
        {
            double[] a = new double[5] { 0, -2, 4, 6, 8 };
            Array.Reverse(a);
            foreach(int i in a)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
        static void task0_15()
        {
            int[] a = new int[6] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Enter M");
            int p = 0;
            if (int.TryParse(Console.ReadLine(), out int m))
            {
                int[] b = new int[m];
                for (int i = a.Length - 1; i >= a.Length - m;i--)
                {
                    b[p] = a[i];
                    p++;
                }
                p = 0;
                Array.Reverse(b);
                Array.Resize(ref a,a.Length - m);
                Array.Reverse(a);
                Array.Resize(ref a, a.Length + m);
                for (int i = a.Length - 1; i > a.Length - m - 1; i--)
                {
                    a[i] = b[p];
                    p++;
                }
                Array.Reverse(a);
                foreach (int i in a)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
    
