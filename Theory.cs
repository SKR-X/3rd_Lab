using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Xml.Serialization;

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
            for (int i = 0; i < n; i++)
            {
                mas[i] = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
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
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(mas2[i]);
            }
            Console.WriteLine("Mas with odd index");
            for (int i = 0; i < 5; i++)
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
            double max = 0;
            int a = 0;
            b = 0;
            double min = 0;
            Console.WriteLine("Write numbers in mas");
            for (int i = 0; i < N; i++)
            {
                mas[i] = double.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = mas[i];
                    min = mas[i];
                    a = i;
                    b = i;
                }
                if (mas[i] > max)
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
            void Level2_6()
                {
                Console.WriteLine("Level2_6");
                double P;
                Console.WriteLine("Write number P");
                P = double.Parse(Console.ReadLine());
                int n;
                int k = 0;
                Console.WriteLine("Write amount numbers in mas");
                n = int.Parse(Console.ReadLine());
                n = n + 1;
                double max = 0, sum = 0;
                double[] mas = new double[n];
                Console.WriteLine("Write numbers in mas");
                for (int i = 0; i < n - 1; i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                    sum += mas[i];
                }
                sum /= n - 1;
                double min;
                min = Math.Abs(sum - mas[0]);
                for (int i = 1; i < n - 1; i++)
                {
                    if (Math.Abs(mas[i] - sum) < min)
                    {
                        k = i;
                    }
                }
                for (int i = n - 1; i > k; i--)
                {
                    mas[i] = mas[i - 1];
                }
                mas[k + 1] = P;
                Console.WriteLine("Answer");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mas[i]);
                }
            }
           void Level2_9(){
                Console.WriteLine("Level 2_9");
                int a = 0, b = 0;
                double min = 0;
                double max = 0;
                Console.WriteLine("amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                double [] mas = new double[n];
                Console.WriteLine("Write elements in mas");
                mas[0] = double.Parse(Console.ReadLine());
                max = mas[0];
                min = mas[0];
                double sum = 0;
                for (int i = 1; i < n; i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                    if (mas[i] > max)
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
                if (b > a) Console.WriteLine("Wrong b must be less than a");
                if (a - b - 1 == 0 || n==1) Console.WriteLine("No elements");
                else
                {
                    for (int i = b + 1; i < a; i++)
                    {
                        sum += mas[i];
                    }

                    sum /= a - b - 1;
                    Console.WriteLine("Answer - {0:f4}", sum);
                }
            }
            void Level2_10()
            {
                Console.WriteLine("Level 2_10");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                double[] mas = new double[n];
                double min = 0;
                int flag = 0;
                int k = 0;
                Console.WriteLine("Write elements in mas");
                for (int i=0; i<n; i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                    if (mas[i]>0 && flag==0)
                    {
                        min=mas[i];
                        flag = 1;
                        k = i;
                    }
                    if (mas[i] < min && mas[i] > 0 && flag == 1) { min = mas[i];k = i; }
                }
                if (flag == 1)
                {
                    for (int i = k; i < n - 1; i++)
                    {
                        mas[i] = mas[i + 1];
                    }
                    mas = mas.SkipLast(1).ToArray();
                    Console.WriteLine("Anwer");
                    Console.WriteLine(string.Join(",", mas));
                }
                else Console.WriteLine("No correct numbers");
            }
            void Level2_11()
            {
                Console.WriteLine("Level 2_11");
                Console.WriteLine("Write P");
                double P = double.Parse(Console.ReadLine());
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                n = n + 1;
                double[] mas = new double[n];
                int k = -1;
                Console.WriteLine("Write elements in mas");
                for (int i=0; i<n-1;i++)
                {
                    mas[i]=double.Parse(Console.ReadLine());
                    if (mas[i]>0)
                    {
                        k= i;
                    }
                }
                if (k != -1)
                {
                    for (int i = n - 1; i > k + 1; i--)
                    {
                        mas[i] = mas[i - 1];
                    }
                    mas[k + 1] = P;
                    Console.WriteLine("Answer");
                    Console.WriteLine(string.Join(", ", mas));
                }
                else Console.WriteLine("No correct numbers");

            }
            void Level2_13()
            {
                Console.WriteLine("Level 2_13");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                double[] mas = new double[n];
                Console.WriteLine("Write elements in mas");
                mas[0] = double.Parse(Console.ReadLine());
                double max = mas[0];
                int k = 0;
                for(int i=1;i<n;i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                    if (i % 2 == 0 && mas[i] > max) k = i;

                }
                mas[k] = k;
                Console.WriteLine("Answer");
                Console.WriteLine(string.Join(", ", mas));
            }
            void Level2_15()
            {
                Console.WriteLine("Level 2_15");
                Console.WriteLine("Write k");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("Write amount of elements in mas a");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Write amount of elements in mas b");
                int m = int.Parse(Console.ReadLine());
                n = n + m;
                double[] a = new double[n];
                double[] b = new double[m];
                Console.WriteLine("Write elements in mas a");
                for (int i = 0; i<n-m;i++)
                {
                    if (k > n) break;
                    if (i < k)
                    {


                        a[i] = double.Parse(Console.ReadLine());
                    }
                    if (i>=k)
                    {
                        a[i + m] = double.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Write elements in mas b");
                for (int j=0;j<m;j++)
                {
                   if (k>n) break;
                    b[j] = double.Parse(Console.ReadLine());
                    a[k] = b[j];
                    k += 1;
                }
                if (k > n) Console.WriteLine("Wrong number k");
                else
                {
                    Console.WriteLine("Answer");
                    Console.WriteLine(string.Join(", ", a));
                }
            }
            void Level3_1()
            {
                Console.WriteLine("Level 3_1");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                double[] mas = new double[n];
                double[] mas2= new double[n];
                int count = 0;
                double k = 0;
                Console.WriteLine("Write elements in mas");
                mas[0] = double.Parse(Console.ReadLine());
                double max = mas[0];
                for (int i =1; i<n;i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                    if (mas[i] > max)
                    {
                        max = mas[i];
                        count = 0;
                        mas2[count] = i;
                    }
                    else if (mas[i]==max)
                    {
                        count += 1;
                        mas2[count] = i;
                    }
                }
                mas2 = mas2.SkipLast(n - count - 1).ToArray();
                Console.WriteLine("Answer");
                Console.WriteLine(string.Join(", ", mas2));
            }
            void Level3_3()
            {
                Console.WriteLine("Level 3_3");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                double[] mas= new double[n];
                Console.WriteLine("Write elements in mas");
                mas[0] = double.Parse(Console.ReadLine());
                double max = mas[0];
                int k = 0;
                double swap = 0;
                for (int i = 1; i<n;i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                    if (mas[i]>max)
                    {
                        max = mas[i];
                        k = i;
                    }
                }
                if (k % 2 != 0) k = k - 1;
                for (int i=0;i<k;i+=2)
                {
                    swap = mas[i];
                    mas[i] = mas[i + 1];
                    mas[i + 1] = swap;
                }
                Console.WriteLine("Answer");
                Console.WriteLine(string.Join(", ", mas));
            }
            void Level3_5()
            {
                Console.WriteLine("Level 3_5");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Write elements in mas");
                double[] mas = new double[n];
                double swap = 0;
                for (int i = 0; i<n;i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                }
                for (int i = 0; i<n; i+=2)
                {
                    for (int j = i+2; j<n;j+=2)
                    {
                       if (mas[i] < mas[j])
                        {
                            swap = mas[i];
                            mas[i] = mas[j];
                            mas[j] = swap;
                        }
                    }
                }
                Console.WriteLine("Answer");
                Console.WriteLine(string.Join(", ", mas));
            }
            void Level3_8()
            {
                Console.WriteLine("Level 3_8");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                double[] mas= new double[n];
                double swap = 0;
                Console.WriteLine("Write elements in mas");
                for (int i=0;i<n;i++)
                {
                    mas[i]=double.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    if (mas[i]<0)
                    {
                        for (int j=i+1;j<n;j++)
                        {
                            if (mas[j] <0 )
                            {
                                if (mas[i] > mas[j])
                                {
                                    swap = mas[i];
                                    mas[i] = mas[j];
                                    mas[j] = swap;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Answer");
                Console.WriteLine(string.Join(", ",mas));
            }
            void Level3_9()
            {
                Console.WriteLine("Level 3_9");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                double[] mas= new double[n];
                int count = 0;
                int k = -1;
                int count2 = 0;
                Console.WriteLine("Write elements in mas");
                for (int i=0;i<n;i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                }
                for (int i=0;i<n-1;i++)
                {
                    count = 0;
                    count2 = 0;
                    for (int j=i;j<n-1;j++)
                    {
                        if (mas[j] > mas[j + 1])
                        {
                            count += 1;
                            if (count > k) k = count;
                        }
                        else count = 0;
                        if (mas[j] < mas[j + 1])
                        { 
                            count2 += 1;
                            if (count2>k) k = count2;

                        }
                        else count2 = 0;
                    }
                }
                Console.WriteLine("Answer");
                Console.WriteLine(k);
                
            }
            void Level3_12()
            {
                Console.WriteLine("Level 3_12");
                int n = 12;
                double[] mas= new double[n];
                int count = 0;
                double swap = 0;
                Console.WriteLine("Write elements in mas");
                for (int i=0;i<n;i++)
                {
                    mas[i]=double.Parse(Console.ReadLine());
                    if (mas[i] < 0) count += 1;
                }
                for(int i=0;i<n;i++)
                {
                    if (mas[i] < 0)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            if (mas[j]>0)
                            {
                                swap = mas[i];
                                mas[i] = mas[j];
                                mas[j] = swap;
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine("Answer");
                mas = mas.SkipLast(count).ToArray();
                Console.WriteLine(string.Join(", ", mas));
            }
            void Level3_13()
            {
                Console.WriteLine("Level 3_13");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                double[] mas = new double[n];
                double swap = 0;
                int count = 0;
                int count2 = 0;
                int flag = 0;
                Console.WriteLine("Write elements in mas");
                for (int i=0;i<n;i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                }
                for(int i=0;i<n-1;i++)
                {
                    flag = 0;
                    for(int j=i+1;j<n;j++)
                    {
                        if (mas[i] == mas[j])
                        {   if (flag == 0)
                            {
                                flag = 1;
                                count += 1;
                            }
                            for (int x=j+1;x<n;x++)
                            {
                                if (mas[j] != mas[x])
                                {
                                    swap = mas[j];
                                    mas[j] = mas[x];
                                    mas[x] = swap;
                                    count2 += 1;
                                    
                                    break;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Answer");
                mas = mas.SkipLast(count).ToArray();
                Console.WriteLine(string.Join(", ",mas));   
            }
            void search_element()
            {
                Console.WriteLine("Search_elements");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                double[] mas= new double[n];
                Console.WriteLine("Write elements in mas");
                for (int i=0;i<n;i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Write number that you want find");
                double s = double.Parse(Console.ReadLine());
                Array.Sort(mas);
                int i1 = 0, i2 = n - 1;
                int k;
                k = (i2 + i1) / 2;
                while (mas[k]!=s)
                {
                    if (s < mas[k]) i2 = k - 1;
                    else i1 = k + 1;
                    k= (i2 + i1) / 2;
                    if (i1 > i2) break;
                }
                if (i1 > i2) Console.WriteLine("No number");
                else Console.WriteLine("Your number in mas");
            }
            void unification()
            {
                Console.WriteLine("Unification");
                Console.WriteLine("Write amount of elements in mas a");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Write amount of elements in mas b");
                int m = int.Parse(Console.ReadLine());
                int l = n + m;
                double[] a = new double[n];
                double[] b = new double[m];
                double[] c = new double[l];
                Console.WriteLine("Write elements in mas a");
                for (int i=0;i<n;i++)
                {
                    a[i]= double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Write elements in mas b");
                for (int i=0;i<m;i++)
                {
                    b[i]= double.Parse(Console.ReadLine());
                }
                for (int i=0;i<Math.Min(n,m);i++)
                {
                    c[i*2]= a[i];
                    c[i * 2 + 1] = b[i];
                }
                int k = 0;
                if (n>m)
                {
                    for (int i=m*2;i<(m+n);i++)
                    {
                        c[i] = a[m + k];
                        k++;
                    }
                    Console.WriteLine("Your mas");
                    Console.WriteLine(String.Join(",", c));
                }
                else if (n<m)
                {
                    for (int i=n*2;i<(m+n);i++)
                    {
                        c[i] = b[n + k];
                        k++;
                    }
                    Console.WriteLine("Your mas");
                    Console.WriteLine(String.Join(",", c));
                }
                else
                {
                    Console.WriteLine("Your mas");
                    Console.WriteLine(String.Join(",", c));
                }
            }
            void unification2()
            {
                Console.WriteLine("Unification2");
                Console.WriteLine("Write amount of elements in mas a");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Write amount of elements in mas b");
                int m = int.Parse(Console.ReadLine());
                double[] a = new double[n];
                double[] b = new double[m];
                double[] c = new double[n + m];
                Console.WriteLine("Write elements in mas a");
                for (int i=0; i<n;i++)
                {
                    a[i] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Write elements in mas b");
                for (int i=0;i<m;i++)
                {
                    b[i] = double.Parse(Console.ReadLine());
                }
                Array.Sort(a);
                Array.Sort(b);
                Array.Reverse(a);
                Array.Reverse(b);
                int I = 0;
                int J = 0;
                for (int i=0;i<n+m;i++)
                {
                   if (I<n && J<m)
                    {
                        if (a[I] > b[J])
                        {
                            c[i] = a[I];
                            I++;
                        }
                        else
                        {
                            c[i] = b[J];
                            J++;
                        }
                    }
                    else
                    {
                        if(I>=n)
                        {
                            c[i] = b[J];
                            J++;
                        }
                        else if (J>=m)
                        {
                            c[i] = a[I];
                            I++;
                        }
                    }
                }
                Console.WriteLine("Your mas");
                Console.WriteLine(String.Join(", ", c));
            }
            void invert()
            {
                Console.WriteLine("Invert");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Write elements in mas");
                double[] mas = new double[n];
                for (int i=0;i<n;i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                }
                n = n - 1;
                double swap = 0;
                for (int i=0;i<=n/2;i++)
                {
                    swap = mas[i];
                    mas[i] = mas[n - i];
                    mas[n - i] = swap;
                }
                Console.WriteLine("Your mas");
                Console.WriteLine(String.Join(", ",mas));

            }
            void shift()
            {
                Console.WriteLine("Shift");
                Console.WriteLine("Write amount of elements in mas");
                int n = int.Parse (Console.ReadLine());
                Console.WriteLine("Write number m");
                int m = int.Parse(Console.ReadLine());
                double[] mas = new double[n];
                Console.WriteLine("Write elements in mas");
                for (int i = 0; i<n;i++)
                {
                    mas[i] = double.Parse(Console.ReadLine());
                }
                double pred = 0;
                double next = 0;
                for (int i=0;i<m;i++)
                {
                    pred = mas[0];
                    for (int j=0;j<(n-1);j++)
                    {
                        next = mas[j+1];
                        mas[j + 1] = pred;
                        pred = next;
                    }
                    mas[0] = pred;
                }
                Console.WriteLine("Your Mas");
                Console.WriteLine(String.Join(", ",mas));
            }
            Level2_6();
            Level2_9();
            Level2_10();
            Level2_11();
            Level2_13();
            Level2_15();
            Level3_1();
            Level3_3();
            Level3_5();
            Level3_8();
            Level3_9();
            Level3_12();
            Level3_13();
            search_element();
            unification();
            unification2();
            invert();
            shift();

        }
    }
}
