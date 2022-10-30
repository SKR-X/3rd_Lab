// there are two parts of code (1 and 2 levels from 2100 + 3 level in different code blocks) , you can skip 1 chapter of 2100 by setting skip1 boolean to "true"
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        int i = 0;

        double q = 0, p = 0, ip = 0, iq = 0, s = 0;

        bool skip1 = false;
        bool skip2 = false;

        if (!skip1)
        {
            double[] nums = new double[5];

            Console.WriteLine("1.6 Введите элементы массива");

            for (i = 0; i < nums.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out nums[i]);
            }

            for (i = 0; i < nums.Length; i++)
            {
                s += nums[i] * nums[i];
            }

            Console.WriteLine($"1.6 Длина вектора: {Math.Sqrt(s)}");

            double[] nums3 = new double[10];

            Console.WriteLine("1.11 Введите элементы массива");

            for (i = 0; i < nums3.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out nums3[i]);
            }

            List<double> list = new List<double>();

            for (i = 0; i < nums3.Length; i++)
            {
                if (nums3[i] > 0)
                {
                    list.Add(nums3[i]);
                }
            }

            Console.WriteLine("1.11 Массив пол. элементов:");

            for (i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            double io = 0, iz = 0;

            Console.WriteLine("1.12 Введите элементы массива");

            double[] nums4 = new double[8];

            for (i = 0; i < nums4.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out nums4[i]);
            }



            for (i = 0; i < nums4.Length; i++)
            {
                if (nums4[i] < 0)
                {
                    io = i;
                    iz = nums4[i];
                }
            }

            Console.WriteLine($"1.12 Значение = {iz} Номер = {io}");

            double[] nums5 = new double[10];

            Console.WriteLine("1.13 Введите элементы массива");

            for (i = 0; i < nums5.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out nums5[i]);
            }

            List<double> listch = new List<double>();

            List<double> listnch = new List<double>();

            for (i = 0; i < nums5.Length; i++)
            {
                if (i % 2 == 0)
                {
                    listch.Add(nums5[i]);
                }
                else
                {
                    listnch.Add(nums5[i]);
                }
            }

            Console.WriteLine("1.13 Четные:");

            for (i = 0; i < listch.Count; i++)
            {
                Console.Write(listch[i] + " ");
            }

            Console.WriteLine("\n1.13 Нечетные:");

            for (i = 0; i < listnch.Count; i++)
            {
                Console.Write(listnch[i] + " ");
            }

            Console.WriteLine("\n");
        }

        double max = 0, min = 2000, inp = 0;

        int maxi = 0, mini = 0, n = 0;

        Console.WriteLine("2.5 Напишите размер массива");

        Int32.TryParse(Console.ReadLine(), out n);

        if (n >= 1)
        {
            double[] mas25 = new double[n];

            Console.WriteLine("2.5 Напишите элементы массива");

            for (i = 0; i < n; i++)
            {
                Double.TryParse(Console.ReadLine(), out mas25[i]);
            }
            List<double> listneg = new List<double>();

            bool trigger = true;

            int j = 0;

            for (i = 0; i < mas25.Length; i++)
            {
                if (mas25[i] > max)
                {
                    max = mas25[i];

                    maxi = i;

                }

                if (mas25[i] < min)
                {
                    min = mas25[i];

                    mini = i;

                }

            }

            if (maxi > mini)
            {
                for (i = mini + 1; i < maxi; i++)
                {
                    if (mas25[i] < 0)
                    {
                        listneg.Add(mas25[i]);
                    }
                }
            }
            else
            {
                for (i = mini - 1; i > maxi; i--)
                {
                    if (mas25[i] < 0)
                    {
                        listneg.Add(mas25[i]);
                    }
                }
            }

            Console.WriteLine("\n2.5 Массив отр. элементов:");

            for (i = 0; i < listneg.Count; i++)
            {
                Console.WriteLine(listneg[i]);
            }
        }
        //2.6


        Console.WriteLine("\n2.6 Напишите размер массива");

        Int32.TryParse(Console.ReadLine(), out n);


        if (n >= 1)
        {
            double[] mas26 = new double[n];

            Console.WriteLine("2.6 Напишите P");

            Double.TryParse(Console.ReadLine(), out p);

            s = 0;

            double mr = 0, minr = 0;

            Console.WriteLine("2.6 Напишите элементы массива");

            for (i = 0; i < n; i++)
            {
                Double.TryParse(Console.ReadLine(), out mas26[i]);
            }

            for (i = 0; i < n; i++)
            {
                s += mas26[i];
            }

            mr = Math.Round(s / n);

            if (n != 0)
            {
                minr = Math.Abs(mas26[0] - mr);
                mini = 0;

                for (i = 1; i < n; i++)
                {
                    if (Math.Abs(mas26[i] - mr) < minr)
                    {
                        minr = Math.Abs(mas26[i] - mr);
                        mini = i;
                    }
                }
                Console.WriteLine($"Наиболее приближенный {mas26[mini]} под индексом {mini}");

                double[] mas261 = new double[n + 1];

                for (i = 0; i <= mini; i++)
                {
                    mas261[i] = mas26[i];
                }

                mas261[mini + 1] = p;

                for (i = mini + 2; i < n + 1; i++)
                {
                    mas261[i] = mas26[i - 1];
                }

                Console.WriteLine("2.6 Исправленный массив:");

                for (i = 0; i < mas261.Length; i++)
                {
                    Console.WriteLine(mas261[i]);
                }
            }
        }

        //2.9
        Console.WriteLine("\n2.9 Напишите размер массива");

        Int32.TryParse(Console.ReadLine(), out n);

        s = 0;

        if (n >= 1)
        {
            double[] mas29 = new double[n];
            Console.WriteLine("2.6 Напишите элементы массива");
            for (i = 0; i < n; i++)
            {
                Double.TryParse(Console.ReadLine(), out mas29[i]);
            }

            max = 0;
            min = mas29[0];
            int c = 0;

            for (i = 0; i < mas29.Length; i++)
            {
                if (mas29[i] > max)
                {
                    max = mas29[i];
                    maxi = i;
                }

                if (mas29[i] < min)
                {
                    min = mas29[i];
                    mini = i;
                }
            }

            if (maxi > mini)
            {
                for (i = mini + 1; i < maxi; i++)
                {
                    s += mas29[i];
                    c++;
                }
            }
            else
            {
                for (i = mini + 1; i < maxi; i++)
                {
                    s += mas29[i];
                    c++;
                }
            }

            Console.WriteLine($"2.9 Ср. Знач = {s / c}");
        }

        List<double> list210 = new List<double>();

        Console.WriteLine("2.10 Введите кол-во элементов массива");

        min = 0;

        if (Int32.TryParse(Console.ReadLine(), out n) && n>=1)
        {
            Console.WriteLine("2.10 Введите элементы массива");
            for (i = 0; i < n; i++)
            {
                Double.TryParse(Console.ReadLine(), out inp);
                list210.Add(inp);
            }

            for (i = 0; i < n; i++)
            {
                if ((list210[i]<min && list210[i] > 0) || (min==0 && list210[i] > 0))
                {
                    min = list210[i];
                }
            }

            list210.Remove(min);

            Console.WriteLine("2.10 Массив без минимального элемента:");

            for (i = 0; i < list210.Count; i++)
            {
                Console.WriteLine(list210[i]);
            }
        }

        Console.WriteLine("2.11 Введите кол-во элементов массива");

        if(Int32.TryParse(Console.ReadLine(), out n) && n >= 1)
        {
            Console.WriteLine("2.11 Введите P");

            Double.TryParse(Console.ReadLine(), out p);

            double[] mas211 = new double[n];

            Console.WriteLine("2.11 Введите элементы массива");

            for (i = 0; i < n; i++)
            {
                Double.TryParse(Console.ReadLine(), out inp);
                mas211[i] = inp;
            }

            for (i = 0; i < mas211.Length; i++)
            {
                if (mas211[i]>0)
                {
                    mini = i;
                }
            }

            double[] imas211 = new double[n+1];

            for (i = 0; i <= mini; i++)
            {
                imas211[i] = mas211[i];
            }

            imas211[mini + 1] = p;

            for (i = mini+1; i<mas211.Length;i++)
            {
                imas211[i + 1] = mas211[i];
            }

            Console.WriteLine("2.11 Исправлнный массив");

            for (i = 0; i < imas211.Length; i++)
            {
                Console.WriteLine(imas211[i]);
            }

        }

        

    }
}

//-------------------------------------------------------
// SECOND CHAPTER (3 LEVEL FROM 2100)
//-------------------------------------------------------


//2.13

using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, maxi = 0;
            double max = 0, inp = 0;

            Console.WriteLine("2.13 Введите размер массива:");

            if (Int32.TryParse(Console.ReadLine(), out n) && n >=1 )
            {

                double[] mas213 = new double[n];

                Console.WriteLine("2.13 Введите элементы массива:");

                for (int i = 0;  i < mas213.Length;  i++)
                {
                    Double.TryParse(Console.ReadLine(), out inp);
                    mas213[i] = inp;
                }

                for (int i = 0; i < mas213.Length; i++)
                {
                    if (mas213[i] > max && i%2==0)
                    {
                        max = mas213[i];
                        maxi = i;
                    }
                }

                Console.WriteLine("2.13 Измененный массив:");

                Console.WriteLine(max);
                
                mas213[maxi] = maxi;

                for (int i = 0; i < mas213.Length; i++)
                {
                    Console.WriteLine(mas213[i]);
                }
            }
            


        }
    }
}


//2.15

using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0, maxi = 0, i = 0, k = 0;
            double max = 0, inp = 0;

            Console.WriteLine("2.15 Введите размер массива A:");

            if (Int32.TryParse(Console.ReadLine(), out n) && n >= 1)
            {

                double[] masA = new double[n];

                Console.WriteLine("2.15 Введите элементы массива A:");

                for (i = 0; i < masA.Length; i++)
                {
                    Double.TryParse(Console.ReadLine(), out inp);
                    masA[i] = inp;
                }

                Console.WriteLine("2.15 Введите размер массива B:");

                if (Int32.TryParse(Console.ReadLine(), out m) && m >= 1)
                {
                    double[] masB = new double[m];

                    Console.WriteLine("2.15 Введите элементы массива B:");

                    for (i = 0; i < masB.Length; i++)
                    {
                        Double.TryParse(Console.ReadLine(), out inp);
                        masB[i] = inp;
                    }

                    List<double> listAB = new List<double>();

                    Console.WriteLine("2.15 Введите K:");

                    if (Int32.TryParse(Console.ReadLine(), out k) && k >= 1)
                    {
                        for (i = 0; i < k; i++)
                        {
                            listAB.Add(masA[i]);
                        }

                        for (i = 0; i < masB.Length; i++)
                        {
                            listAB.Add(masB[i]);
                        }

                        for (i = k; i < masA.Length; i++)
                        {
                            listAB.Add(masA[i]);
                        }
                    }

                    Console.WriteLine("2.15 Измененный массив:");

                    for (i = 0; i < listAB.Count; i++)
                    {
                        Console.WriteLine(listAB[i]);
                    }
                }

            }



        }
    }
}

//3.1

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, maxi = 0, i = 0, c = 0, maxc = 0, inc = 0;
            double max = 0, inp = 0;

            Console.WriteLine("2.13 Введите размер массива:");

            if (Int32.TryParse(Console.ReadLine(), out n) && n >= 1)
            {

                double[] mas = new double[n];
                List<double> list = new List<double>();
                List<int> listi = new List<int>();

                Console.WriteLine("2.13 Введите элементы массива:");

                for (i = 0; i < mas.Length; i++)
                {
                    Double.TryParse(Console.ReadLine(), out inp);
                    mas[i] = inp;
                }

                for (i = 0; i < mas.Length; i++)
                {
                    if (mas[i]>=max)
                    {
                        max = mas[i];
                        list.Add(mas[i]);
                        listi.Add(i);
                    }
                }

                for (i = 0; i < list.Count-1; i++)
                {
                    c = 0;
                    for (int j = i; j < list.Count; j++)
                    {
                        if(list[i] == list[j])
                        {
                            c++;
                        }
                    }
                    if (c > maxc)
                    {
                        maxc = c;
                        max = list[i];
                    }
                }

                int[] masmax = new int[maxc];

                for (i = 0; i < list.Count; i++)
                {
                    if (list[i] == max)
                    {
                        masmax[inc] = listi[i];
                        inc++;
                    }
                }

                Console.WriteLine("3.1 Массив индексов:");

                for (i = 0; i < maxc; i++)
                {
                    Console.WriteLine(masmax[i]);
                }
            }
        }
    }
}


//3.5

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0, i = 0, c = 1;
            double inp = 0, temp = 0;
             Console.WriteLine("2.13 Введите размер массива:");

            if (Int32.TryParse(Console.ReadLine(), out n) && n >= 1)
            {

                double[] mas = new double[n];

                Console.WriteLine("2.13 Введите элементы массива:");

                for (i = 0; i < mas.Length; i++)
                {
                    Double.TryParse(Console.ReadLine(), out inp);
                    mas[i] = inp;
                }

                Console.WriteLine("Сортированный:");

                while (c > 0)
                {
                    c = 0;
                    for (i = 0; i < mas.Length - 2; i+=2)
                    {
                        if (mas[i] > mas[i + 2])
                        {
                            temp = mas[i];
                            mas[i] = mas[i + 2];
                            mas[i + 2] = temp;
                            c++;
                        }
                    }
                }

                for (i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine(mas[i]);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0, i = 0, c = 1, j = 0;
            double inp = 0, temp = 0;
            Console.WriteLine("3.8 Введите размер массива:");

            if (Int32.TryParse(Console.ReadLine(), out n) && n >= 1)
            {

                double[] mas = new double[n];

                Console.WriteLine("3.8 Введите элементы массива:");

                for (i = 0; i < mas.Length; i++)
                {
                    Double.TryParse(Console.ReadLine(), out inp);
                    mas[i] = inp;
                }

                Console.WriteLine("3.8 Сортированный:");

                for (i = 0; i < mas.Length-1; i++)
                {
                    for (j = i+1; j < mas.Length; j++)
                    {
                        if ((mas[i] < mas[j]) && (mas[i]<0 && mas[j]<0))
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }

                for (i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine(mas[i]);
                }
            }
        }
    }
}

//3.9

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0, i = 0, c = 1, j = 0,max = 0;
            double inp = 0, temp = 0;
            Console.WriteLine("3.9 Введите размер массива:");

            if (Int32.TryParse(Console.ReadLine(), out n) && n >= 1)
            {

                double[] mas = new double[n];

                Console.WriteLine("3.9 Введите элементы массива:");

                for (i = 0; i < mas.Length; i++)
                {
                    Double.TryParse(Console.ReadLine(), out inp);
                    mas[i] = inp;
                }

                for (i = 0; i < mas.Length-1; i++)
                {
                    if (mas[i+1] < mas[i])
                    {
                        c++;
                        if (c > max)
                        {
                            max = c;
                        }
                    } else
                    {
                        if(c>max)
                        {
                            max = c;
                        }
                        c = 1;
                    }
                }
                c = 1;
                for (i = 0; i < mas.Length-1; i++)
                {
                    if (mas[i + 1] > mas[i])
                    {
                        c++;
                        if (c > max)
                        {
                            max = c;
                        }
                    }
                    else
                    {
                        if (c > max)
                        {
                            max = c;
                        }
                        c = 1;
                    }
                }
                    Console.WriteLine($"Ответ: {max}");
            }
        }
    }
}


//3.12

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0, i = 0, c = 0, j = 0, max = 0;
            double inp = 0, temp = 0;

                double[] mas = new double[12];

                Console.WriteLine("3.12 Введите элементы массива:");

            for (i = 0; i < mas.Length; i++)
            {
                Double.TryParse(Console.ReadLine(), out inp);
                mas[i] = inp;
            }

            for (i = 0; i < mas.Length; i++)
                {
                if (mas[i]>=0)
                {
                    c++;
                }
                }

            double[] maspol = new double[c];

            c = 0;

            for (i = 0; i < mas.Length; i++)
            {
                if (mas[i]>=0)
                {
                    maspol[c] = mas[i];
                    c++;
                }
            }

            mas = maspol;

            Console.WriteLine("3.12 Ответ массив:");

            for (i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }
    }
}

//3.13

using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, maxi = 0, i = 0, j = 0;
            double max = 0, inp = 0;
            bool exit = false;

            Console.WriteLine("3.13 Введите размер массива:");

            if (Int32.TryParse(Console.ReadLine(), out n) && n >= 1)
            {

                List<double> list = new List<double>();

                Console.WriteLine("3.13 Введите элементы массива:");

                for (i = 0; i < n; i++)
                {
                    Double.TryParse(Console.ReadLine(), out inp);
                    list.Add(inp);
                }

                for (i = 0; i < list.Count-1; i++)
                {
                    for (j = i + 1; j < list.Count; j++)
                    {
                        if (list[i] == list[j])
                        {
                            list.RemoveAt(j);
                            j--;
                        }
                    }
                }

                Console.WriteLine("3.13 Ответ:");

                for (i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}

//1.10

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.10");
            double[] aa = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 0;
            double P = 2, Q = 5;
            if (P >= Q)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            foreach (double i in aa)
            {
                if (i > P && i < Q)
                {
                    k++;
                }
            }
            Console.WriteLine($"Между P и Q: {k}\n");
        }
    }
}

//2.5

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double max = 0, min = 2000, inp = 0;

            int maxi = 0, mini = 0, n = 0;

            Console.WriteLine("2.5 Напишите размер массива");

            Int32.TryParse(Console.ReadLine(), out n);

            if (n >= 1)
            {
                double[] mas25 = new double[n];

                Console.WriteLine("2.5 Напишите элементы массива");

                for (i = 0; i < n; i++)
                {
                    Double.TryParse(Console.ReadLine(), out mas25[i]);
                }
                List<double> listneg = new List<double>();

                bool trigger = true;

                int j = 0;

                for (i = 0; i < mas25.Length; i++)
                {
                    if (mas25[i] > max)
                    {
                        max = mas25[i];

                        maxi = i;

                    }

                    if (mas25[i] < min)
                    {
                        min = mas25[i];

                        mini = i;

                    }

                }

                int temp;

                if (maxi < mini)
                {
                    temp = maxi;
                    maxi = mini;
                    mini = temp;
                }
                for (i = mini + 1; i < maxi; i++)
                {
                    if (mas25[i] < 0)
                    {
                        listneg.Add(mas25[i]);
                    }
                }

                Console.WriteLine("\n2.5 Массив отр. элементов:");

                for (i = 0; i < listneg.Count; i++)
                {
                    Console.WriteLine(listneg[i]);
                }
            }
        }
    }
}

//3.1

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[12] { 1, -5, -9, -111, 2, 5, 7, 120, 8, 120, -10, 120 };
            List<int> a2 = new List<int>();
            int maximus = 1;
            for (int i = 0; i < 12; i++)
            {
                if (a[i] == maximus)
                {
                    a2.Add(i);
                }
                if (a[i] > maximus)
                {
                    maximus = a[i];
                    a2.Clear();
                    a2.Add(i);
                }
            }
            for (int i = 0; i < a2.Count; i++)
            {
                Console.Write($"  {a2[i]}  ");
            }
            Console.WriteLine();

        }
    }
}


