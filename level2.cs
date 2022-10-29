using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

class homew4lvl2
{
    static void Main()
    {
        Console.WriteLine("введите номер задания (5,6,9,10,11,13,15)");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb == 5)
        {
            #region Level2 Task5
            Console.WriteLine("введите массив чисел:");
            string[] temp5 = Console.ReadLine().Split(" ");
            int l = temp5.Length;
            double maxim5 = -1000000;
            int indexmax5 = 0;
            int indexmin5 = 0;
            double minim5 = 1000000;
            double[] ma5 = new double[l];
            bool h = true;
            for (int i5 = 0; i5 < l; i5++)
            {
                h = double.TryParse(temp5[i5], out double xx);
                if (h == true)
                {
                    ma5[i5] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (h == true)
            {
                for (int i51 = 0; i51 < l; i51++)
                {
                    if (ma5[i51] > maxim5) { maxim5 = ma5[i51]; indexmax5 = i51; } //находим индекс максимального
                    if (ma5[i51] < minim5) { minim5 = ma5[i51]; indexmin5 = i51; } //находим индекс минимального
                }

                int indexstart5 = 0;
                int indexend5 = 0;
                if (indexmin5 < indexmax5) { indexstart5 = indexmin5; indexend5 = indexmax5; } //меняем порядок индексов в зависимости от порядка минимального и максимального элементов
                else { indexstart5 = indexmax5; indexend5 = indexmin5; }
                int ix5 = indexstart5 + 1;
                double[] res5 = new double[indexend5 - indexstart5 + 1];
                int ires5 = 0;
                while (ix5 < indexend5)
                {
                    if (ma5[ix5] < 0) //сохраняем в массив отрицательнве значения между элементами
                    {
                        res5[ires5] = ma5[ix5];
                        ires5 += 1;
                    }
                    ix5++;
                }
                Console.WriteLine("вывод массива:");
                for (int iend5 = 0; iend5 < ires5; iend5++) Console.WriteLine(res5[iend5]);
                
            }
            #endregion
        }
        else if (numb == 6)
        {
            #region Level2 Task6
            Console.WriteLine("введите массив!");
            string[] temp6 = Console.ReadLine().Split(" ");
            int l6 = temp6.Length;
            bool o = true;
            double[] ma6 = new double[l6];
            for (int i6 = 0; i6 < l6; i6++)
            {
                o = double.TryParse(temp6[i6], out double xx);
                if (o == true)
                {
                    ma6[i6] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                }
            }
            if (o == true)
            {
                Console.WriteLine("введите элемент Р");
                double P = Convert.ToDouble(Console.ReadLine());
                double sum = 0.0;
                foreach (double x6 in ma6)
                {
                    sum += x6; //находим сумму массива для среднего значения
                }
                double average = sum / l6;
                //Console.WriteLine(average);
                double raz;
                int index6 = 0;
                double razmin = 1000000000;
                for (int i61 = 0; i61 < l6; i61++)
                {
                    raz = Math.Abs(ma6[i61] - average); //рассматриваем разницу между элементом и средним значением
                    if (raz < razmin)
                    {
                        razmin = raz;
                        index6 = i61;
                    }
                }
                double[] res6 = new double[l6 + 1];
                for (int i62 = 0; i62 < l6 + 1; i62++)
                {
                    if (i62 <= index6) res6[i62] = ma6[i62]; //переносим первую часть до среднего значения массива в новый массив
                    else if (i62 == (index6 + 1)) res6[i62] = P; //вставляем значение Р
                    else res6[i62] = ma6[i62 - 1]; //добавляем вторую часть массива
                }
                for (int i63 = 0; i63 < l6 + 1; i63++)
                    Console.WriteLine(res6[i63]);
            }
            #endregion
        }
        else if (numb == 9)
        {
            #region level2 Task9
            Console.WriteLine("введите массив!");
            string[] temp9 = Console.ReadLine().Split(" ");
            int l9 = temp9.Length;
            double[] ma9 = new double[l9];
            bool u = true;
            for (int i9 = 0; i9 < l9; i9++)
            {
                u = double.TryParse(temp9[i9], out double xx);
                if (u == true)
                {
                    ma9[i9] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            }
            double maxim9 = -100000000;
            double minim9 = 100000000;
            int indexmin9 = 0;
            int indexmax9 = 0;
            if (u == true)
            {
                for (int i91 = 0; i91 < l9; i91++)
                {
                    if (ma9[i91] > maxim9) { maxim9 = ma9[i91]; indexmax9 = i91; } //находим индекс максимального
                    if (ma9[i91] < minim9) { minim9 = ma9[i91]; indexmin9 = i91; } //находим индекс минимального
                }
                int indexstart9 = 0;
                int indexend9 = 0;
                if (indexmin9 < indexmax9) { indexstart9 = indexmin9; indexend9 = indexmax9; } //меняем порядок индексов в зависимости от порядка минимального и максимального элементов
                else { indexstart9 = indexmax9; indexend9 = indexmin9; }
                int ix9 = indexstart9 + 1;
                double sum9 = 0.0;
                while (ix9 < indexend9)
                {
                    sum9 += ma9[ix9]; //находим сумму между минимальным и максимальным элементами
                    ix9++;
                }
                Console.WriteLine($"среднее арифмитическое -> {sum9 / (indexend9 - indexstart9 - 1)}");
            }
            #endregion
        }
        else if (numb == 10)
        {
            #region Level2 Task10
            Console.WriteLine("введите массив!");
            string[] temp0 = Console.ReadLine().Split(" ");
            int l0 = temp0.Length;
            double[] ma0 = new double[l0];
            bool v = true;
            for (int i0 = 0; i0 < l0; i0++)
            {
                v = double.TryParse(temp0[i0], out double xx);
                if (v == true)
                {
                    ma0[i0] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
                
            }
            double min0 = 1000000;
            int indexmin0 = 0;
            if (v == true)
            {


                for (int j0 = 0; j0 < l0; j0++)
                {
                    if ((ma0[j0] < min0) && (ma0[j0] > 0)) //находим наименьшее положительное значение
                    {
                        min0 = ma0[j0];
                        indexmin0 = j0;
                    }
                }
                //создаем удаление элемента:(
                if (min0 != 1000000)
                {
                    for (int i = indexmin0; (i + 1) < l0; i++)
                    {
                        ma0[i] = ma0[i + 1];
                    }
                    l0 = l0 - 1;
                }

                for (int z0 = 0; z0 < (l0); z0++)
                    Console.WriteLine(ma0[z0]);
            }
            #endregion
        }
        else if (numb == 11)
        {
            #region Level2 Task11
            Console.WriteLine("введите массив!");
            string[] temp1 = Console.ReadLine().Split(" ");
            int l1 = temp1.Length;
            double[] ma1 = new double[l1 + 1];
            bool b = true;
            for (int i1 = 0; i1 < l1; i1++)
            {
                b = double.TryParse(temp1[i1], out double xx);
                if (b == true)
                {
                    ma1[i1] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (b == true)
            {
                Console.WriteLine("введите элемент Р");
                double P1 = Convert.ToDouble(Console.ReadLine());
                int ix1 = 0;
                for (int i1 = (l1 - 1); i1 > 0; i1--)
                {
                    if (ma1[i1] > 0)
                    {
                        ix1 = i1; //находим последний положительный элемент
                        break;
                    }
                }
                double tempx = ma1[ix1 + 1]; //конструкция замены значений элементов для сдввига массива
                double tempx1;
                ma1[ix1 + 1] = P1;
                ix1 = ix1 + 2;
                while (ix1 < l1 + 1)
                {
                    tempx1 = ma1[ix1];
                    ma1[ix1] = tempx;
                    tempx = tempx1;
                    ix1++;
                }

                for (int z1 = 0; z1 < l1 + 1; z1++) Console.WriteLine(ma1[z1]);
            }
            #endregion
        }
        else if (numb == 13)
        {
            #region Level2 Task13
            Console.WriteLine("введите массив!");
            string[] temp3 = Console.ReadLine().Split(" ");
            int l3 = temp3.Length;
            double[] ma3 = new double[l3 + 1];
            bool y = true;
            for (int i3 = 0; i3 < l3; i3++)
            {
                y = double.TryParse(temp3[i3], out double xx);
                if (y == true)
                {
                    ma3[i3] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (y == true)
            {
                double maxim3 = -100000000;
                int indexmax3 = 0;
                for (int j3 = 0; j3 < l3; j3 += 2)//шаг два так как четный индекс
                {
                    if (ma3[j3] > maxim3) { maxim3 = ma3[j3]; indexmax3 = j3; } //находим индекс максимального
                }
                ma3[indexmax3] = indexmax3;//заменяем

                for (int z3 = 0; z3 < l3; z3++) Console.WriteLine(ma3[z3]);
            }
            #endregion
        }
        else if (numb == 15)
        {
            #region Level2 Task15
            Console.WriteLine("введите массив! A"); //ввод массива А
            string[] temp5a = Console.ReadLine().Split(" ");
            int l5a = temp5a.Length;
            double[] ma5a = new double[l5a + 1];
            bool ku = true;
            for (int i5a = 0; i5a < l5a; i5a++)
            {
                ku = double.TryParse(temp5a[i5a], out double xx);
                if (ku == true)
                {
                    ma5a[i5a] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (ku == true)
            {
                Console.WriteLine("введите массив! B"); //ввод массива В
                string[] temp5b = Console.ReadLine().Split(" ");
                int l5b = temp5b.Length;
                double[] ma5b = new double[l5b + 1];
                for (int i5b = 0; i5b < l5b; i5b++) ma5b[i5b] = double.Parse(temp5b[i5b]);

                Console.WriteLine("введите номер элемента k>=0"); //ввод к 
                int k = Convert.ToInt32(Console.ReadLine());
                if (k >= 0)
                {
                    int c = 0;
                    int c2 = k + 1;
                    double[] mas = new double[l5a + l5b];
                    for (int ix = 0; ix < (l5a + l5b); ix++)
                    {
                        if ((ix >= (k + 1)) && (c < l5b))
                        {
                            mas[ix] = ma5b[c]; //вставка 
                            c++;
                        }
                        else if (ix < (k + 1)) mas[ix] = ma5a[ix];
                        else
                        {
                            mas[ix] = ma5a[c2];
                            c2++;
                        }
                    }
                    for (int z5 = 0; z5 < (l5a + l5b); z5++) Console.WriteLine(mas[z5]);
                }
                else Console.WriteLine("k>=0");
            }

            #endregion
        }
        else Console.WriteLine("выберите задание из списка:(");
    }
}
