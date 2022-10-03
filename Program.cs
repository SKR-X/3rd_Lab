using System;

namespace _3nd_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1.6
            Console.WriteLine("Level 1 Task 6");
            double a;
            double s = 0;
            for (int i = 1; i <= 5; i++)
            {
                while (true)
                {
                    Console.WriteLine($"    Please enter {i} number:");
                    if (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("    Wrong number, please try again");
                        continue;
                    }
                    break;
                }
                s += a * a;
            }
            Console.WriteLine($"    {Math.Sqrt(s)}");
            #endregion
            
            #region task 1.10
            Console.WriteLine("Level 1 Task 10");
            double p, q, a;
            int counter = 0;
            double s = 0;
            while (true)
            {
                Console.WriteLine($"    Please enter P:");
                if (!double.TryParse(Console.ReadLine(), out p))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.WriteLine($"    Please enter Q:");
                if (!double.TryParse(Console.ReadLine(), out q))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                break;
            }
            if (p > q)
            {
                (p, q) = (q, p);
            }
            Console.WriteLine("    Please enter 10 numbers");
            for (int i = 1; i <= 10; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                if (a >= p && a <= q) counter++;
            }
            Console.WriteLine($"    numbers in [{p}, {q}]:{counter}");
            #endregion
            
            #region task 1.11
            Console.WriteLine("Level 1 Task 11");
            //var pos = new List<double>();
            double a;
            string s = "";

            Console.WriteLine("    Please enter 10 numbers");
            for (int i = 1; i <= 10; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                if (a > 0) s += $"{a} ";
            }
            Console.WriteLine("     Answer:");
            Console.WriteLine(s);
            #endregion
            
            #region task 1.12
            Console.WriteLine("Level 1 Task 12");
            double a;
            double x = 0;
            int counter = 0;

            Console.WriteLine("    Please enter 8 numbers");
            for (int i = 0; i < 8; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                if (a < 0)
                {
                    counter = i;
                    x = a;
                }
            }
            if (x == 0)
            {
                Console.WriteLine($"    There is no negative elements in the list");
            }
            else Console.WriteLine($"    Last negative elevent is: {x}, its number in the list is: {counter}");
            #endregion
            
            #region task 1.13
            Console.WriteLine("Level 1 Task 13");
            double a;
            var a1 = new List<double>(5);
            var a2 = new List<double>(5);

            Console.WriteLine("    Please enter 10 numbers");
            for (int i = 1; i <= 10; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                if (i % 2 == 1)
                {
                    a1.Add(a);
                }
                else a2.Add(a);
            }
            foreach (double i in a1)
            {
                Console.Write($"{i} ");
            }
            Console.Write("\n");
            foreach (double i in a2)
            {
                Console.Write($"{i} ");
            }
            #endregion
            
            #region task 2.5
            Console.WriteLine("Level 2 Task 5");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n < 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            var x = new List<double>(n);
            var x_new = new List<double>();
            double min = double.PositiveInfinity;
            double max = double.NegativeInfinity;
            int min_n = -1;
            int max_n = -1;

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x.Add(a);
                if (a < min)
                {
                    min = a;
                    min_n = i;
                }
                if (a > max)
                {
                    max = a;
                    max_n = i;
                }
            }
            int start = Math.Min(min_n, max_n);
            int end = Math.Max(min_n, max_n);
            for (int k = start + 1; k < end; k++)
            {
                if (x[k] < 0) x_new.Add(x[k]);       
            }
            Console.WriteLine("     Answer: ");
            foreach (double j in x_new)
            {
                Console.Write($"{j} ");
            }
            #endregion
            
            #region task 2.6
            Console.WriteLine("Level 2 Task 6");
            int n;
            double p;
            double s = 0;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                Console.WriteLine("    Please enter p:");
                if (!double.TryParse(Console.ReadLine(), out p))
                {
                    Console.WriteLine("    Wrong p, please try again");
                    continue;
                }
                break;
            }

            var x = new List<double>(n);

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x.Add(a);
                s += a;
            }

            double average = s / n;
            double min = double.PositiveInfinity;
            int index = -1;

            for (int i = 0; i < n; i++)
            {
                double dif = Math.Abs(x[i] - average);
                if (dif < min)
                {
                    min = dif;
                    index = i;
                }
            }
            x.Insert(index + 1, p);
            Console.WriteLine("     Answer: ");
            foreach (double j in x)
            {
                Console.Write($"{j} ");
            }
            #endregion
            
            #region task 2.9
            Console.WriteLine("Level 2 Task 9");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            var x = new List<double>(n);
            double min = double.PositiveInfinity;
            double max = double.NegativeInfinity;
            int min_n = -1;
            int max_n = -1;

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x.Add(a);
                if (a < min)
                {
                    min = a;
                    min_n = i;
                }
                if (a > max)
                {
                    max = a;
                    max_n = i;
                }
            }
            int start = Math.Min(min_n, max_n);
            int end = Math.Max(min_n, max_n);
            int dif = end - start - 1;
            if (dif <= 0)
            {
                Console.WriteLine($"     Task can't be solved for such array");
            }
            else
            {
                double s = 0;
                for (int k = start + 1; k < end; k++)
                {
                    s += x[k];
                }

                Console.WriteLine($"     Answer: {s / dif}");
            }
            #endregion
            
            #region task 2.10
            Console.WriteLine("Level 2 Task 10");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            var x = new List<double>(n);
            double min = double.PositiveInfinity;
            int min_n = -1;

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x.Add(a);
                if (a < min && a > 0)
                {
                    min = a;
                    min_n = i;
                }
            }
            if (min_n == -1)
            {
                Console.WriteLine("    There are no positive elements in array");
            }
            else
            {
                x.RemoveAt(min_n);
                Console.WriteLine("     Answer: ");
                foreach (double j in x)
                {
                    Console.Write($"{j} ");
                }
            }            
            #endregion
            
            #region task 2.11
            Console.WriteLine("Level 2 Task 11");
            int n;
            int index = -1;
            double p;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n < 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                Console.WriteLine("    Please enter p:");
                if (!double.TryParse(Console.ReadLine(), out p))
                {
                    Console.WriteLine("    Wrong p, please try again");
                    continue;
                }
                break;
            }

            var x = new List<double>(n);

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x.Add(a);
                if (a > 0)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("     Answer: There is no positive elements in the list");
            }
            else
            {
                x.Insert(index + 1, p);
                Console.WriteLine("     Answer: ");
                foreach (double j in x)
                {
                    Console.Write($"{j} ");
                }
            }
           #endregion
           
           #region task 2.13
            Console.WriteLine("Level 2 Task 13");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            var x = new double[n];
            double max = double.NegativeInfinity;
            int index = -1;

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x[i] = a;
                if (i % 2 == 0 && a > max)
                {
                    max = a;
                    index = i;
                }
            }
            x[index] = index;
            Console.WriteLine("     Answer: ");
            foreach (double j in x)
            {
                Console.Write($"{j} ");
            }
            #endregion
            
            #region task 2.15
            Console.WriteLine("Level 2 Task 15");
            int n, m, k;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                Console.WriteLine("    Please enter m");
                if ((!int.TryParse(Console.ReadLine(), out m)) || (m <= 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                Console.WriteLine("    Please enter k");
                if ((!int.TryParse(Console.ReadLine(), out k)) || (k < 0) || (k + 1 > n))
                {
                    Console.WriteLine("    Wrong k, please try again");
                    continue;
                }
                break;
            }

            var a = new List<double>(n + m);
            var b = new List<double>(m);

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                a.Add(x);
            }

            Console.WriteLine($"    Please enter {m} numbers");
            for (int i = 0; i < m; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                b.Add(x);
            }

            a.InsertRange(k + 1, b);
            Console.WriteLine("     Answer: ");
            foreach (double j in a)
            {
                Console.Write($"{j} ");
            }
            #endregion
            
            #region task 3.1
            Console.WriteLine("Level 3 Task 1");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n < 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            var x = new double[n];
            var indexes = new List<double>();
            double max = double.NegativeInfinity;

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x[i] = a;
                if (a > max)
                {
                    max = a;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (x[i] == max)
                {
                    indexes.Add(i);
                }
            }
            Console.WriteLine("     Answer: ");
            foreach (double j in indexes)
            {
                Console.Write($"{j} ");
            }
            #endregion
            
            #region task 3.5
            Console.WriteLine("Level 3 Task 5");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n < 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            var x = new double[n];

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x[i] = a;
            }

            for (int i = 0; i < n; i += 2)
            {
                for (int j = i + 2; j < n; j += 2)
                {
                    if (x[i] > x[j])
                    {
                        (x[j], x[i]) = (x[i], x[j]);
                    }
                }
            }

            Console.WriteLine("     Answer: ");
            foreach (double j in x)
            {
                Console.Write($"{j} ");
            }
            #endregion
            
            #region task 3.8
            Console.WriteLine("Level 3 Task 8");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n < 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            var x = new double[n];
            var b = new List<double>();

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x[i] = a;
                if (a < 0)
                {
                    b.Add(i);
                }
            }

            foreach (int i in b)
            {
                foreach (int j in b)
                {
                    if (x[i] < x[j])
                    {
                        (x[i], x[j]) = (x[j], x[i]);
                    }
                }
            }

            Console.WriteLine("     Answer: ");
            foreach (double j in x)
            {
                Console.Write($"{j} ");
            }
            #endregion
            
            #region task 3.9
            Console.WriteLine("Level 3 Task 9");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n < 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            var x = new double[n];

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x[i] = a;
            }

            int max_p1 = 1, max_p2 = 1, p1 = 1, p2 = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (x[i] > x[i + 1])
                {
                    p1 ++;
                    max_p2 = Math.Max(max_p2, p2);
                    p2 = 1;
                }
                if (x[i] < x[i + 1])
                {
                    p2++;
                    max_p1 = Math.Max(max_p1, p1);
                    p1 = 1;
                }
            }
            max_p2 = Math.Max(max_p2, p2);
            max_p1 = Math.Max(max_p1, p1);
            Console.WriteLine($"     Answer: {Math.Max(max_p1, max_p2)}");
            #endregion
            
            #region task 3.12
            Console.WriteLine("Level 3 Task 12");
            int n = 12;
            var x = new double[n];
            var b = new List<double>();

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x[i] = a;
            }

            foreach (double i in x)
            {
                if (i >= 0)
                {
                    b.Add(i);
                }
            }
            Console.WriteLine("     Answer: ");
            foreach (double j in b)
            {
                Console.Write($"{j} ");
            }
            #endregion
            
            #region task 3.13
            Console.WriteLine("Level 3 Task 13");
            int n;
            while (true)
            {
                Console.WriteLine("    Please enter n");
                if ((!int.TryParse(Console.ReadLine(), out n)) || (n < 0))
                {
                    Console.WriteLine("    Wrong n, please try again");
                    continue;
                }
                break;
            }

            var x = new List<double>(n);

            Console.WriteLine($"    Please enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("    Wrong number, please try again");
                    continue;
                }
                x.Add(a);
            }
            //of course I want to use IEnumerable.Distinct() but I assume you would not like it)
            for (int i = 0; i < x.Count; i++)
            {
                for (int k = i + 1; k < x.Count; k++)
                {
                    if (x[i] == x[k])
                    {
                        x.RemoveAt(k);
                        --k;
                    }
                }
            }

            Console.WriteLine("     Answer: ");
            foreach (double j in x)
            {
                Console.Write($"{j} ");
            }
            #endregion
            
            #region task 0.11
            Console.WriteLine("Level Final Boss Task 11");
            static int Task11(double[] a, int n, double x)
            {
                int i1 = 0;
                int i2 = n - 1;
                while (i1 <= i2)
                {
                    int i = (i1 + i2) / 2;
                    if (x == a[i])
                    {
                        return i;
                    }
                    else if (x < a[i])
                    {
                        i2 = i - 1;
                    }
                    else
                    {
                        i1 = i + 1;
                    }
                }
                return -1;
            }
            #endregion
            
            #region task 0.12
            Console.WriteLine("Level Final Boss Task 12");
            static double[] Task12(double[] a, double[] b, int n, int m)
            {
                double[] c = new double[m + n];
                if (n > m)
                {
                    for (int i = 0; i < m; i++)
                    {
                        c[2 * i] = a[i];
                        c[2 * i + 1] = b[i];
                    }
                    for (int i = m; i < n; i++)
                    {
                        c[m + i] = a[i];
                    }
                }
                else if (m > n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        c[2 * i] = a[i];
                        c[2 * i + 1] = b[i];
                    }
                    for (int i = n; i < m; i++)
                    {
                        c[n + i] = b[i];
                    }
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        c[2 * i] = a[i];
                        c[2 * i + 1] = b[i];
                    }
                }
                return c;
            }
            /*var x = Task12(new double[] { -1, -2, -3, -4, -5 }, new double[] { 1, 2, 3, 4, 5, 6, 7 }, 5, 7);
            Console.WriteLine("     Answer: ");
            foreach (double j in x)
            {
                Console.Write($"{j} ");
            }
            Console.Write("\n");
            var y = Task12(new double[] { 1, 2, 3, 4, 5, 6, 7 }, new double[] { -1, -2, -3, -4, -5 }, 7, 5);
            Console.WriteLine("     Answer: ");
            foreach (double j in y)
            {
                Console.Write($"{j} ");
            }*/
            #endregion
            
            #region task 0.13
            Console.WriteLine("Level Final Boss Task 13");
            static double[] Task13(double[] a, double[] b, int n, int m)
            {
                var c = new double[n + m];
                int i = 0, j = 0, k = 0;
                while (i < n && j < m)
                    c[k++] = a[i] >= b[j] ? a[i++] : b[j++];
                while (i < n)
                    c[k++] = a[i++];
                while (j < m)
                    c[k++] = b[j++];
                return c;
            }
            /*var x = Task13(new double[] { 10, 8, 6, 4, 2 }, new double[] { 5, 4, 3, 2, 1, 0}, 5, 6);
            Console.WriteLine("     Answer: ");
            foreach (double j in x)
            {
                Console.Write($"{j} ");
            }*/
            #endregion
            
            #region task 0.14
            Console.WriteLine("Level Final Boss Task 14");
            static double[] Task14(double[] x, int n)
            {
                for (int i = 0; i <= n/2 - 1; i++)
                {
                    (x[i], x[n - i - 1]) = (x[n - i - 1], x[i]);
                }
                return x;
            }
            /*var x = Task14(new double[] { 10, 8, 6, 4, 2, 7, 11, 22, 123}, 9);
            Console.WriteLine("     Answer: ");
            foreach (double j in x)
            {
                Console.Write($"{j} ");
            }*/
            #endregion
            
            #region task 0.15
            Console.WriteLine("Level Final Boss Task 15");
            static double[] Task15(double[] x, int n, int m)
            {
                double last = x[n - 1];
                for (int i = 0; i < m; i++)
                {
                    for (int j = n-2; j >= 0; j--)
                    {
                        x[j + 1] = x[j];
                    }
                    x[0] = last;
                    last = x[n - 1];
                }
                return x;
            }
            /*var x = Task15(new double[] { 10, 8, 6, 4, 2, 7, 11, 22, 123}, 9, 3);
            Console.WriteLine("     Answer: ");
            foreach (double j in x)
            {
                Console.Write($"{j} ");
            }*/
            #endregion
        }
    }
}
