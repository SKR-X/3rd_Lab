using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            #region Task#1.10
            int P, Q;
            int[] a1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите элемент масива под индексом {0}", i);
                int.TryParse(Console.ReadLine(), out a1[i]);
            }
            Console.WriteLine("Введите P: ");
            int.TryParse(Console.ReadLine(), out P);
            Console.WriteLine("Введите Q: ");
            int.TryParse(Console.ReadLine(), out Q);
            int k = 0;
            if (P > Q)
            {
                int ppp = Q; Q = P; P = ppp;
            }
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] > P && a1[i] < Q) k++;
            }
            Console.WriteLine(k);
            #endregion

            #region Task#2.13
            int elemCount5;
            Console.WriteLine("Введите кол-во элеметов массива:");
            int.TryParse(Console.ReadLine(), out elemCount5);
            if (elemCount5 <= 0) Console.WriteLine("Error");
            double[] b5 = new double[elemCount5];
            for (int j = 0; j < b5.Length; j++)
            {
                Console.WriteLine("Введите элемент массива под индексом {0}", j);
                double.TryParse(Console.ReadLine(), out b5[j]);
            }
            double mxb5 = b5[0];
            int jmx = 0;
            for (int j = 2; j < b5.Length; j++)
            {
                if (b5[j] > mxb5)
                {
                    mxb5 = b5[j];
                    jmx = j;
                }
                b5[jmx] = jmx;
            }
            for (int j = 0; j < b5.Length; j++)
                Console.WriteLine("{0:f1}", b5[j]);
            Console.WriteLine();
            #endregion

            #region Task#4.11
            Console.WriteLine("Введите размер массива");
            int.TryParse(Console.ReadLine(), out int BA);
            int[] Barray = new int[BA];
            for (int i = 0; i < BA; i++)
                Barray[i] = random.Next(10);
            Console.WriteLine();
            for (int i = 0; i < BA; i++)
                Console.Write("{0:d} ", Barray[i]);
            Console.WriteLine();
            Console.WriteLine("Введите x, который хотите найти в массиве ");
            int.TryParse(Console.ReadLine(), out int xx);
            int indxx = 0, indxx_2 = BA - 1;
            int srxx = (indxx + indxx_2) / 2;
            while (indxx_2 >= indxx)
            {
                if (xx == Barray[srxx])
                {
                    Console.WriteLine("YEEES");
                    break;
                }
                else if (xx < Barray[srxx])
                {
                    indxx_2 = srxx - 1;
                }
                else
                {
                    indxx = srxx + 1;
                }
                srxx = (indxx + indxx_2) / 2;
            }
            if (indxx_2 < indxx) Console.WriteLine("NOOOO");
            #endregion

            #region Task#4.12
            Console.WriteLine("Введите размер массива1");
            int.TryParse(Console.ReadLine(), out int n12);
            Console.WriteLine("Введите размер массива2");
            int.TryParse(Console.ReadLine(), out int m12);
            double[] a12 = new double[n12];
            double[] b12 = new double[m12];
            for (int i = 0; i < n12; i++)
                a12[i] = random.Next(50);
            Console.WriteLine();
            for (int i = 0; i < m12; i++)
                b12[i] = random.Next(50);
            Console.WriteLine();
            double[] c12 = new double[n12 + m12];
            int p = 0, q = 0, kk = 0;
            while (p != a12.Length & q != b12.Length)
            {
                c12[k] = a12[p];
                kk++;
                p++;
                c12[k] = b12[q];
                q++;
                kk++;
            }
            for (int i = k; i != c12.Length; i++)
            {
                if (a12.Length < b12.Length)
                {
                    c12[i] = b12[q];
                    q++;
                }
                else
                {

                    c12[i] = a12[p];
                    p++;
                }
            }


            foreach (double x in c12)
                Console.WriteLine(x);
            #endregion

            #region Task#4.13
            Console.WriteLine("Введите размер массива1");
            int.TryParse(Console.ReadLine(), out int n13);
            double[] a13 = new double[n13];
            for (int i = 0; i < n13; i++)
                a13[i] = random.Next(30);
            Console.WriteLine();
            Console.WriteLine("Введите размер массива2");
            int.TryParse(Console.ReadLine(), out int m13);
            double[] b13 = new double[m13];
            for (int i = 0; i < m13; i++)
                b13[i] = random.Next(30);
            Console.WriteLine();
            double[] c13 = new double[a13.Length + b13.Length];
            int p13 = 0;
            int q13 = 0;
            for (int i = 0; i != c13.Length; i++)
            {
                if (p13 < a13.Length & q13 < b13.Length)
                {
                    if (a13[p13] > b13[q13])
                    {
                        c13[i] = a13[p13];
                        p13++;
                    }
                    else
                    {
                        c13[i] = b13[q13];
                        q13++;
                    }
                }
                else if (p13 >= a13.Length)
                {
                    c13[i] = b13[q13];
                    q13++;
                }
                else
                {
                    c13[i] = a13[p13];
                    p13++;
                }
            }
            foreach (double x in c13)
                Console.WriteLine(x);
            #endregion

            #region Task#4.14
            Console.WriteLine("Введите размер массива");
            int.TryParse(Console.ReadLine(), out int n14);
            int[] a14 = new int[n14];
            for (int i = 0; i < n14; i++)
                a14[i] = random.Next(50);
            Console.WriteLine();
            for (int i = 0; i < n14; i++)
                Console.Write("{0:d} ", a14[i]);
            Console.WriteLine();
            for (int i = 0; i < n14 / 2; i++)
            {
                (a14[i], a14[n14 - i - 1]) = (a14[n14 - i - 1], a14[i]);
            }
            Console.WriteLine("new array: ");
            for (int i = 0; i < n14; i++)
            {
                Console.Write("{0:d} ", a14[i]);
            }
            Console.WriteLine();
            #endregion

            #region Task#4.15
            Console.WriteLine("Введите размер массива");
            int.TryParse(Console.ReadLine(), out int n15);
            Console.WriteLine("Введите интервал");
            int.TryParse(Console.ReadLine(), out int m15);
            int[] a15 = new int[n15];
            int k15;
            for (int i = 0; i < a15.Length; i++)
                a15[i] = random.Next(20);
            Console.WriteLine();
            for (int i = 0; i < a15.Length; i++)
                Console.Write("{0:d} ", a15[i]);
            Console.WriteLine();
            for (int i = 0; i < m15; i++)
            {
                k15 = a15[n15 - 1];
                for (int j = n15 - 1; j > 0; j--)
                {
                    a15[j] = a15[j - 1];
                }
                a15[0] = k15;
            }
            for (int i = 0; i < a15.Length; i++)
                Console.Write("{0:d} ", a15[i]);
            Console.WriteLine();
            #endregion
        }
    }
}
