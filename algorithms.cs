using System;
using System.Numerics;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

class homew4_algorithms
{
    static void Main()
    {
        Console.WriteLine("введите массив для проверки");
        
        string[] temp1 = (Console.ReadLine()).Split(' ');
        int l = temp1.Length;
        double[] ma = new double[l];
        bool u = true;
        for (int i = 0; i < l; i++)
        {
            u = double.TryParse(temp1[i], out double xx);
            if (u == true)
            {
                ma[i] = xx;
            }
            else
            {
                Console.WriteLine("введите заново");
                break;
            }

        }
        if (u == true)
        {
            Console.WriteLine("выберите, что хотите: ");
            Console.WriteLine("поиск заданного элемента в упорядоченном массиве (бинарный поиск) - 1");
            Console.WriteLine("объединение двух массивов с чередованием элементов - 2");
            Console.WriteLine("объединение двух упорядоченных массивов в один с сохранием упорядоченности - 3");
            Console.WriteLine("инвертирование массива - 4");
            Console.WriteLine("циклический сдвиг - 5");
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb == 1)
            {
                Console.WriteLine("введите значение, которое вы хотите найти");
                double x = Convert.ToDouble(Console.ReadLine());
                int left = 0;
                int right = l - 1;

                int k = 0;
                int c = 0;
                while (left < right - 1)
                {
                    c++;
                    k = (left + right) / 2;
                    if (ma[k] == x)
                    {
                        break;
                    }
                    c++;
                    if (ma[k] < x) left = k;
                    else right = k;
                }
                if (ma[k] != x)
                {
                    if (ma[left] == x) k = left;
                    else
                    {
                        if (ma[right] == x) k = right;
                        else k = -1;

                    }
                }
                Console.WriteLine(k);
            }
            else if (numb == 2)
            {
                Console.WriteLine("введите массив второй");
                string[] temp2 = (Console.ReadLine()).Split(' ');
                int m = temp2.Length;
                double[] ma2 = new double[m];
                bool v = true;
                for (int i = 0; i < m; i++)
                {
                    v = double.TryParse(temp2[i], out double xx);
                    if (v == true)
                    {
                        ma2[i] = xx;
                    }
                    else
                    {
                        Console.WriteLine("введите заново");
                        break;
                    }

                }
                if (v== true)
                {
                    int c1 = 0;
                    int c2 = 0;
                    double[] ma3 = new double[l + m];
                    int z = 0;
                    int d = 0;
                    int p = 0;
                    if (l == m) z = l;
                    else if (l > m) { z = m; d = 1; }
                    else { z = l; d = 2; }

                        for (int ix = 0; ix < (2 * z); ix++)
                        {
                            if (ix % 2 == 0) { ma3[ix] = ma[c1]; c1++; }
                            else { ma3[ix] = ma2[c2]; c2++; }
                        }
                    if (d == 1)
                    {
                        int t = 0;
                        for (int i = m; i < l; i++)
                        {
                            ma3[z * 2 + t] = ma[i];
                            t++;
                        }
                    }
                    else if (d == 2)
                    {
                        int t = 0;
                        for (int i = l; i < m; i++)
                        {
                            ma3[z * 2 + t] = ma2[i];
                            t++;
                        }
                    }
                        for (int ixx = 0; ixx < (l+m); ixx++)
                            Console.WriteLine(ma3[ixx]);
                    }
                
             
            }
            else if (numb == 3)
            {
                Console.WriteLine("введите массив второй");
                string[] temp2 = (Console.ReadLine()).Split(' ');
                int m = temp2.Length;
                double[] b = new double[m];
                bool v = true;
                for (int i = 0; i < m; i++)
                {
                    v = double.TryParse(temp2[i], out double xx);
                    if (v == true)
                    {
                        b[i] = xx;
                    }
                    else
                    {
                        Console.WriteLine("введите заново");
                        break;
                    }

                }
                if (v == true)
                {
                    
                    double[] ma3 = new double[l + m];
                    int i = 0;
                    int j = 0;
                    int c = 0;

                    while (c<(l+m))
                    {
                        //Console.WriteLine('-');
                        if ((i < l) && (j < m))
                        {
                            if (ma[i] >= b[j])
                            {
                                ma3[c] = ma[i];
                                //Console.WriteLine($"ma3[c] -> {ma3[c]}, c -> {c}, ma[i] -> {ma[i]}, i -> {i}");
                                i++;
                                c++;
                                while ((ma[i] > b[j]))
                                {
                                    ma3[c] = ma[i];
                                    //Console.WriteLine($"ma3[c] -> {ma3[c]}, c -> {c}, ma[i] -> {ma[i]}, i -> {i}");
                                    i++;
                                    c++;
                                    if (i == l) break;

                                }
                            }
                            else
                            {
                                ma3[c] = b[j];
                                j++;
                                c++;
                                //Console.WriteLine(ma3[c]);
                                while ((ma[i] < b[j]))
                                {
                                    ma3[c] = b[j];
                                    j++;
                                    c++;
                                    //Console.WriteLine(ma3[c]);
                                    if (j == m) break;
                                }
                            }
                        }

                        else 
                        {
                            int q = 0;
                            int r = 0;
                            int y = 0;
                            if (l > m) y = l;
                            else y = m;
                            double[] temp = new double[y];
                            if (i == l)
                            {
                                q = j;
                                r = m;
                                temp = b;
                            }
                            else
                            {
                                q = i;
                                r = l;
                                temp = ma;
                            }
                            while (q < r)
                                {
                                    ma3[c] = temp[q];
                                    q++;
                                    c++;
                                }
                           
                        }

                    }



                    for (int ixx = 0; ixx < (l+m); ixx++)
                        Console.WriteLine(ma3[ixx]);
                }

            }
            else if (numb == 4)
            {
                int i = 0;
                int j = l-1;
                
                while ((j - i )>= 1)
                {
                    double t = ma[i];
                    ma[i] = ma[j];
                    ma[j] = t;
                    i++;
                    j--;
                }
                for (int ixx = 0; ixx < (l); ixx++)
                    Console.WriteLine(ma[ixx]);
            }
            else if (numb == 5)
            {
                Console.WriteLine("введите m");
                int m = Convert.ToInt32(Console.ReadLine());
                if (m > 0)
                {
                    double[] temp = new double[m];
                    double[] temp2 = new double[l-m];
                    
                    int c = 0;
                    int c2 = 0;
                    for (int i = 0; i < l; i++)
                    {
                        if (i < (l - m)) { temp2[c] = ma[i]; c++; }
                        else {
                            temp[c2] = ma[i]; c2++; }
                    }
                    c = 0;
                    c2 = 0;
                    for (int j = 0; j < l; j++)
                        {
                            if (j < m) { ma[j] = temp[c];c++; }
                            else { ma[j] = temp2[c2];c2++; }
                        }



                    for (int ixx = 0; ixx < (l); ixx++)
                        Console.WriteLine(ma[ixx]);
                }
                else Console.WriteLine("m>0");
            }
            else Console.WriteLine("выберите из списка");
        }
    }
}

