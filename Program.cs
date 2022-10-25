using System;

namespace _3rdLab
{
    internal class Program
    {
        static void Main()
        {

            #region LEVEL 1

            Console.WriteLine("_LEVEL_1_\n");

            #region Task 6

            Console.WriteLine("Task 6: \n");

            int[] vector = new int[5];
            double vector_lenght = 0;

            Console.WriteLine("Введите координаты вектора (вводите числа!)");
            for (int i = 0; i < vector.Length; i++)
            {
                Int32.TryParse(Console.ReadLine(), out vector[i]);
            }

            for (int i = 0; i < vector.Length; i++)
            {
                vector_lenght += vector[i] * vector[i];
            }
            vector_lenght = Math.Sqrt(vector_lenght);

            Console.WriteLine($"Длина вектор равна: {vector_lenght}\n");
            #endregion

            #region Task 10

            Console.WriteLine("Task 10: \n");

            double[] a10 = new double[10];
            double P = 0;
            double Q = 0;
            int count = 0;

            Console.WriteLine("Введите элементы массива (вводите числа): ");
            for (int i = 0; i < a10.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out a10[i]);
            }

            Console.Write("Введите значение числа P : \t");
            double.TryParse(Console.ReadLine(), out P);

            Console.Write("Введите значение числа Q (Q > P): \t");
            double.TryParse(Console.ReadLine(), out Q);

            for (int i = 0; i < a10.Length; i++)
            {
                if (a10[i] < Q && a10[i] > P)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество чисел, которые лежат между P и Q, равно {count} \n");

            #endregion

            #region Task 11

            Console.WriteLine("Task 11: \n");

            double[] a11 = new double[10];
            double[] b11 = new double[10];

            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < a11.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out a11[i]);
            }

            for (int i = 0; i < a11.Length; i++)
            {
                if (a11[i] > 0)
                {
                    b11[i] = a11[i];
                }
            }

            var result = string.Join(", ", b11.Where(x => x > 0));
            Console.WriteLine($"Получившийся массив: {result} \n");

            #endregion

            #region Task 12

            Console.WriteLine("Task 12: \n");

            double[] a12 = new double[8] { 3, 5, 17, -20, 32, 44, -2, 7 };
            double a_last = 0;
            double i_last = 0;

            for (int i = 0; i < a12.Length; i++)
            {
                if (a12[i] < 0)
                {
                    a_last = a12[i];
                    i_last = i;
                }
            }
            Console.WriteLine("Изначальная строка: \t {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", a12[0], a12[1], a12[2], a12[3], a12[4], a12[5], a12[6], a12[7]);
            Console.WriteLine($"Значение последнего отрицательного элемента: {a_last}, а его номер: {i_last + 1} \n");

            #endregion

            #region Task 13

            Console.WriteLine("Task 13: \n");

            int[] a13 = new int[10] { 1, 3, 6, 11, 54, 22, 2, 3, 8, 14 };
            int[] b13 = new int[5];
            int[] c13 = new int[5];

            int n13 = 1;
            int indexOdd = 0;
            int indexEven = 0;

            foreach (var number in a13)
            {
                if (n13 == 1)
                {
                    b13[indexOdd] = number;
                    indexOdd++;
                }
                else
                {
                    c13[indexEven] = number;
                    indexEven++;
                }

                n13 = -n13;
            }

            Console.WriteLine("Изначальная строка: \t {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", a13[0], a13[1], a13[2], a13[3], a13[4], a13[5], a13[6], a13[7], a13[8], a13[9]);
            Console.WriteLine("Строка с элементами на чётных позициях: \t {0}, {1}, {2}, {3}, {4}", b13[0], b13[1], b13[2], b13[3], b13[4]);
            Console.WriteLine("Строка с элементами на нечётных позициях: \t {0}, {1}, {2}, {3}, {4}", c13[0], c13[1], c13[2], c13[3], c13[4]);

            #endregion

            #endregion

            #region LEVEL 2

            Console.WriteLine("_LEVEL_2_ \n");

            #region Task 5

            int n, min5, max5, n0, amount;
            max5 = 0;
            amount = 2;

            Console.WriteLine("Введите количество элементов массива");

            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] mas1 = new int[n];

                Console.WriteLine("Введите элементы массива: ");

                for (int i = 0; i < mas1.Length; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out mas1[i]);
                }

                for (int j = 0; j < mas1.Length; j++)
                {
                    if (mas1[j] > max5)
                    {
                        max5 = mas1[j];
                    }

                }

                min5 = max5;

                for (int i = 0; i < mas1.Length; i++)
                {
                    if (mas1[i] < min5)
                    {
                        min5 = mas1[i];
                    }
                }

                n0 = min5;

                for (int i = 0; i < mas1.Length; i++)
                {
                    if (mas1[i] < 0)
                    {
                        if (mas1[i] != min5 && mas1[i] != max5)
                        {
                            amount++;
                        }
                    }

                }
                int[] mas2 = new int[amount];
                mas2[0] = n0;

                for (int i = 1; i < n; i++)
                {
                    if (mas1[i] < 0)
                    {
                        if (mas1[i - 1] != min5 && mas1[i - 1] != max5)
                        {
                            mas2[i] = mas1[i - 1];
                        }
                        else
                        {
                            if (mas1[i - 1] == min5 || mas1[i - 1] == max5)
                            {
                                mas2[i] = mas1[i];
                                i++;
                            }
                        }

                    }

                }

                mas2[amount - 1] = max5;

                Console.WriteLine("Task5: получившийся массив -");
                for (int i = 0; i < mas2.Length; i++)
                {
                    Console.WriteLine(mas2[i]);
                }
            }

            #endregion

            #region Task 6

            Console.WriteLine("Task 6: ");
            int p, summ, mid, midnum, p_num;

            summ = 0;
            midnum = 0;
            p_num = 0;

            Console.Write("Введите количество элементов в массиве: \t");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] mas6 = new int[n];

                Console.WriteLine("Введите элементы массива:");
                for (int i = 0; i < mas6.Length; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out mas6[i]);
                }

                Console.Write("Введите число P: \t");
                Int32.TryParse(Console.ReadLine(), out p);

                for (int i = 0; i < mas6.Length; i++)
                {
                    if (mas6[i] == p)
                    {
                        p_num = i;
                    }

                    summ += mas6[i];
                }

                mid = summ / n;

                for (int i = 1; i < n; i++)
                {
                    mas6[i - 1] = mas6[i - 1];
                    if ((i - 1) >= p_num)
                    {
                        mas6[i - 1] = mas6[i];
                    }
                }

                for (int i = 1; i < mas6.Length; i++)
                {
                    if (Math.Abs(mid - mas6[i - 1]) < Math.Abs(mid - mas6[i]))
                    {
                        midnum = i - 1;
                    }
                }
                for (int i = 1; i < (n - 1); i++)
                {
                    mas6[n - i] = mas6[n - (i + 1)];
                }
                mas6[midnum + 1] = p;

                Console.WriteLine("Полученный массив - ");
                for (int j = 0; j < mas6.Length; j++)
                {
                    Console.WriteLine(mas6[j]);
                }
            }

            #endregion

            #region Task 9

            Console.WriteLine("_Task 9_:");

            int max9, min9, max9_i, min9_i;
            double n9, answer9;

            max9 = 0;
            min9_i = 0;
            max9_i = 0;
            summ = 0;
            n9 = 0;

            Console.Write("Введите количество элементов массива: \t");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] mas9 = new int[n];

                Console.WriteLine("Введите элементы массива:");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out mas9[i]);
                }

                for (int i = 0; i < mas9.Length; i++)
                {
                    if (max9 < mas9[i])
                    {
                        max9 = mas9[i];
                        max9_i = i;
                    }
                }

                min9 = max9;

                for (int i = 0; i < mas9.Length; i++)
                {
                    if (min9 > mas9[i])
                    {
                        min9 = mas9[i];
                        min9_i = i;
                    }
                }

                if (min9_i < max9_i)
                {
                    for (int i = min9_i + 1; i < max9_i; i++)
                    {
                        summ += mas9[i];
                    }

                    n9 = max9_i - min9_i - 1;
                }
                else
                {
                    for (int i = max9_i + 1; i < min9_i; i++)
                    {
                        summ += mas9[i];
                    }

                    n9 = min9_i - max9_i - 1;
                }

                answer9 = summ / n9;

                Console.WriteLine($"Ответ: {answer9}");
            }

            #endregion

            #region Task 10

            int min10, min10_i;

            min10_i = 0;

            Console.Write("Введите количество элементов массива: \t");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] mas10 = new int[n];

                Console.WriteLine("Введите элементы массива:");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out mas10[i]);
                }
                min10 = mas10[0];

                for (int i = 0; i < n; i++)
                {
                    if (mas10[i] > 0 && min10 > mas10[i])
                    {
                        min10 = mas10[i];
                        min10_i = i;
                    }
                }

                int[] mas10_2 = new int[n - 1];
                for (int i = 1; i < n; i++)
                {
                    mas10_2[i - 1] = mas10[i - 1];
                    if ((i - 1) >= min10_i)
                    {
                        mas10_2[i - 1] = mas10[i];
                    }
                }

                Console.WriteLine($"Task 10: получившийся массив");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mas10_2[i]);
                }
            }

            #endregion

            #region Task 11

            int last_i;

            last_i = 0;

            Console.Write("Введите количество элементов массива: \t");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] mas11 = new int[n];

                Console.WriteLine("Введите элементы массива:");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out mas11[i]);
                }

                Console.Write("Введите P: \t");
                Int32.TryParse(Console.ReadLine(), out p);

                for (int i = 0; i < n; i++)
                {
                    if (mas11[i] > 0)
                    {
                        last_i = i;
                    }
                }

                if (last_i + 1 == n)
                {
                    mas11[0] = p;
                }
                else
                {
                    mas11[last_i + 1] = p;
                }

                Console.WriteLine("Task 11: получившийся массив");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mas11[i]);
                }
            }

            #endregion

            #region Task 13

            Console.WriteLine("_TASK_13_:");

            int max13, max13_i;

            max13 = 0;
            max13_i = 0;

            Console.Write("Введите количество элементов массива: \t");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] mas13 = new int[n];

                Console.WriteLine("Введите элементы массива:");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out mas13[i]);
                }

                for (int i = 0; i < n; i = i + 2)
                {
                    if (max13 < mas13[i])
                    {
                        max13 = mas13[i];
                        max13_i = i;
                    }
                }

                mas13[max13_i] = max13_i;

                Console.WriteLine("Task 13: получившийся массив -");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mas13[i]);
                }
            }

            #endregion

            #region Task 15

            Console.WriteLine("_TASK_15_:");

            int m, k;

            Console.Write("Введите количество элементов 1 массива: \t");
            Int32.TryParse(Console.ReadLine(), out n);

            Console.Write("Введите количество элементов 2 массива: \t");
            Int32.TryParse(Console.ReadLine(), out m);

            int[] A = new int[n];
            int[] B = new int[m];

            Console.WriteLine("Введите элементы 1 массива:");
            for (int i = 0; i < A.Length; i++)
            {
                Int32.TryParse(Console.ReadLine(), out A[i]);
            }

            Console.WriteLine("Введите элементы 2 массива:");
            for (int i = 0; i < B.Length; i++)
            {
                Int32.TryParse(Console.ReadLine(), out B[i]);
            }

            Console.Write("Введите K: \t");
            Int32.TryParse(Console.ReadLine(), out k);

            int[] C = new int[n + m];

            int result_i = 0;

            //Ввожу первую часть значений массива А 
            for (int i = 0; i < k; i++)
            {
                C[result_i] = A[i];
                result_i++;
            }

            //Ввожу значения массива B
            for (int j = 0; j < m; j++)
            {
                C[result_i] = B[j];
                result_i++;

            }

            //Ввожу вторую часть значений массива А 
            for (int i = k; i < n; i++)
            {
                C[result_i] = A[i];
                result_i++;
            }

            Console.WriteLine("Task 15: получившийся массив - ");
            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine(C[i]);
            }

            #endregion

            #endregion

            #region LEVEL 3

            Console.WriteLine("_LEVEL_3_ \n");

            #region Task 1

            Console.WriteLine("_TASK_1_:");

            int max;

            Console.Write("Введите длину массива: \t");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] a1 = new int[n];

                Console.WriteLine("Введите элементы массива: ");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out a1[i]);
                }

                max = a1[0];
                int[] b1 = new int[n];
                int b1_i = 0;

                for (int i = 1; i < n; i++)
                {
                    if (max == a1[i])
                    {
                        b1[b1_i] = i;
                        b1_i++;
                    }

                    if (max < a1[i])
                    {
                        b1_i = 0;
                        max = a1[i];
                        b1[b1_i] = i;
                        b1_i++;
                    }

                }

                Console.WriteLine("Получившийся массив: ");
                for (int i = 0; i < b1_i; i++)
                {
                    Console.WriteLine(b1[i]);
                }
            }

            #endregion

            #region Task 5

            Console.WriteLine("_TASK_5_:");

            Console.Write("Введите длину массива: \t");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] a5 = new int[n];

                Console.WriteLine("Введите элементы массива: ");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out a5[i]);
                }

                for (int i = 0; i < n - 1; i = i + 2)
                {
                    int amin = a5[i];
                    int imin = i;

                    for (int j = i + 2; j < n; j = j + 2)
                    {
                        if (a5[j] < amin)
                        {
                            amin = a5[j];
                            imin = j;
                        }
                    }

                    a5[imin] = a5[i];
                    a5[i] = amin;
                }

                Console.WriteLine("Получившийся массив: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a5[i]);
                }
            }

            #endregion

            #region Task 8

            Console.WriteLine("_TASK_8_:");

            Console.Write("Введите длину массива: \t");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] a8 = new int[n];

                Console.WriteLine("Введите элементы массива: ");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out a8[i]);
                }

                for (int i = 0; i < n - 1; i = i + 1)
                {
                    int amax = 0;
                    int imax = 0;

                    if (a8[i] < 0)
                    {
                        amax = a8[i];
                        imax = i;

                        for (int j = i + 1; j < n; j++)
                        {
                            if (a8[j] < 0)
                            {
                                if (a8[j] > amax)
                                {
                                    amax = a8[j];
                                    imax = j;
                                }
                            }
                        }
                        a8[imax] = a8[i];
                        a8[i] = amax;
                    }

                }

                Console.WriteLine("Получившийся массив: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a8[i]);
                }
            }

            #endregion

            #region Task 9

            Console.WriteLine("_TASK_9_:");

            int[] a9 = new int[] { -9, -11, 83, -32, -5, -2, -1, 22, 44, 2, 101, 204 };
            int tohigh = 0, tolow = 0;
            max = 0;

            for (int i = 0; i < a9.Length - 1; i++)
            {
                if (tohigh > max)
                {
                    max = tohigh;
                }

                if (tolow > max)
                {
                    max = tolow;
                }

                if (a9[i] > a9[i + 1])
                {
                    tolow++;
                }
                else tolow = 0;

                if (a9[i] < a9[i + 1])
                {
                    tohigh++;
                }
                else tohigh = 0;
            }

            Console.WriteLine($"Длина самой упорядоченной последовательности: {max + 1}");

            #endregion

            #region Task 12

            Console.WriteLine("_TASK_12_:");

            int[] a12_2 = new int[] { -9, 11, 83, -32, -5, -2, -1, 22, 44, 2, 101, 204 };

            for (int i = 0; i < 12; i++)
            {
                if (a12_2[i] < 0)
                {
                    a12_2[i] = 0;
                }
            }

            Console.Write("Получившийся массив: ");
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"{a12_2[i]}, ");
            }

            #endregion

            #region Task 13

            Console.WriteLine("_TASK_13_:");

            Console.Write("Введите длину массива: \t");

            if (int.TryParse(Console.ReadLine(), out n))
            {
                int[] d13 = new int[n];
                Console.WriteLine("Введите элементы массива: ");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out d13[i]);
                }

                for (int i = 0; i < n - 1; i++)
                {
                    int a_rep = d13[i];

                    for (int j = i + 1; j < n; j++)
                    {
                        if (d13[j] == a_rep)
                        {
                            d13[j] = 0;
                            d13[i] = 0;
                        }
                    }

                }

                Console.WriteLine("Получившийся массив: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(d13[i]);
                }
            }

            #endregion

            #endregion

            #region Extra

            #region Task 11

            Console.WriteLine("_TASK_11_:");

            Console.Write("Введите длину массива (n): \t");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] a = new int[n];
                Console.WriteLine("Введите элементы массива: ");
                for (int j = 0; j < n; j++)
                {
                    Int32.TryParse(Console.ReadLine(), out a[j]);
                }

                for (int j = 0; j < n - 1; j++)
                {
                    int amin = a[j];
                    int imin = j;

                    for (int q = j + 1; q < n; q++)
                    {
                        if (amin > a[q])
                        {
                            amin = a[q];
                            imin = q;
                        }
                    }

                    a[imin] = a[j];
                    a[j] = amin;
                }

                int x = 0;
                Console.Write("Введите число X: \t");
                Int32.TryParse(Console.ReadLine(), out x);

                int i, i1, i2;
                i1 = 0;
                i2 = n - 1;

                while (true)
                {
                    i = (i1 + i2) / 2;

                    if (i2 < i1)
                    {
                        Console.WriteLine("Массив не содержит X");
                        break;
                    }

                    if (x == a[i])
                    {
                        Console.WriteLine($"Ответ: элемент равный Х есть и его номер - {i}");
                        break;
                    }

                    else if (x < a[i])
                    {
                        i2 = i - 1;
                        continue;
                    }

                    else if (x > a[i])
                    {
                        i1 = i + 1;
                        continue;
                    }
                }
            }

            #endregion

            #region Task 12

            Console.WriteLine("_TASK_12_:");

            Console.Write("Введите длину массива A: \t");
            Int32.TryParse(Console.ReadLine(), out n);

            Console.Write("Введите длину массива B: \t");
            Int32.TryParse(Console.ReadLine(), out m);

            if (n == m)
            {
                int[] A12 = new int[n];
                int[] B12 = new int[m];

                Console.WriteLine("Введите элементы массива А:");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out A12[i]);
                }

                Console.WriteLine("Введите элементы массива B:");
                for (int i = 0; i < m; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out B12[i]);
                }

                int[] C12 = new int[2 * n];

                int i_A = 0;
                int i_B = 0;

                for (int i = 0; i < 2 * n; i++)
                {
                    if (i % 2 == 0)
                    {
                        C12[i] = A12[i_A];
                        i_A++;
                    }
                    else
                    {
                        C12[i] = B12[i_B];
                        i_B++;
                    }
                }

                Console.WriteLine("Получившийся массив C:");
                for (int i = 0; i < 2 * n; i++)
                {
                    Console.WriteLine(C12[i]);
                }
            }

            if (n < m)
            {
                int[] A12 = new int[n];
                int[] B12 = new int[m];

                Console.WriteLine("Введите элементы массива А:");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out A12[i]);
                }

                Console.WriteLine("Введите элементы массива B:");
                for (int i = 0; i < m; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out B12[i]);
                }

                int[] C12 = new int[n + m];

                int i_A = 0;
                int i_B = 0;

                for (int i = 0; i < 2 * n; i++)
                {
                    if (i % 2 == 0)
                    {
                        C12[i] = A12[i_A];
                        i_A++;
                    }
                    else
                    {
                        C12[i] = B12[i_B];
                        i_B++;
                    }
                }

                i_B = n;
                for (int i = 2 * n; i < n + m; i++)
                {
                    C12[i] = B12[i_B];
                    i_B++;

                }

                Console.WriteLine("Получившийся массив C:");
                for (int i = 0; i < n + m; i++)
                {
                    Console.WriteLine(C12[i]);
                }
            }
            else
            {
                int[] A12 = new int[n];
                int[] B12 = new int[m];

                Console.WriteLine("Введите элементы массива А:");
                for (int i = 0; i < n; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out A12[i]);
                }

                Console.WriteLine("Введите элементы массива B:");
                for (int i = 0; i < m; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out B12[i]);
                }

                int[] C12 = new int[n + m];

                int i_A = 0;
                int i_B = 0;

                for (int i = 0; i < 2 * m; i++)
                {
                    if (i % 2 == 0)
                    {
                        C12[i] = A12[i_A];
                        i_A++;
                    }
                    else
                    {
                        C12[i] = B12[i_B];
                        i_B++;
                    }
                }

                i_A = m;
                for (int i = 2 * m; i < n + m; i++)
                {
                    C12[i] = A12[i_A];
                    i_A++;

                }

                Console.WriteLine("Получившийся массив C:");
                for (int i = 0; i < n + m; i++)
                {
                    Console.WriteLine(C12[i]);
                }
            }

            #endregion

            #region Task 13

            Console.WriteLine("_TASK_13_:");

            Console.Write("Введите длину массива A: \t");
            Int32.TryParse(Console.ReadLine(), out n);

            Console.Write("Введите длину массива B: \t");
            Int32.TryParse(Console.ReadLine(), out m);

            int[] A13 = new int[n];
            int[] B13 = new int[m];
            int[] C13 = new int[n + m];

            Console.WriteLine("Введите элементы массива А: ");
            for (int i = 0; i < n; i++)
            {
                Int32.TryParse(Console.ReadLine(), out A13[i]);
            }

            Console.WriteLine("Введите элементы массива B: ");
            for (int i = 0; i < m; i++)
            {
                Int32.TryParse(Console.ReadLine(), out B13[i]);
            }

            //Сортировка массива А
            for (int i = 0; i < n - 1; i++)
            {
                int amax = A13[i];
                int imax = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (A13[j] > amax)
                    {
                        amax = A13[j];
                        imax = j;
                    }
                }
                A13[imax] = A13[i];
                A13[i] = amax;
            }

            //Сортировка массива B
            for (int i = 0; i < m - 1; i++)
            {
                int amax = B13[i];
                int imax = i;

                for (int j = i + 1; j < m; j++)
                {
                    if (B13[j] > amax)
                    {
                        amax = B13[j];
                        imax = j;
                    }
                }
                B13[imax] = B13[i];
                B13[i] = amax;
            }

            int A_i = 0, B_i = 0, C_i = 0;
            bool flag = true;

            while (flag)
            {
                while (A13[A_i] >= B13[B_i])
                {
                    C13[C_i] = A13[A_i];
                    A_i++;
                    C_i++;

                    if (A_i >= n)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == false)
                    break;

                while (A13[A_i] < B13[B_i])
                {
                    C13[C_i] = B13[B_i];
                    B_i++;
                    C_i++;

                    if (B_i >= m)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == false)
                    break;

            }

            if (B_i <= m)
            {
                for (; B_i < m; B_i++)
                {
                    C13[C_i] = B13[B_i];
                    C_i++;
                }
            }

            if (A_i <= n)
            {
                for (; A_i < n; A_i++)
                {
                    C13[C_i] = A13[A_i];
                    C_i++;
                }
            }


            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < n + m; i++)
            {
                Console.WriteLine(C13[i]);
            }

            #endregion

            #region Task 14

            Console.WriteLine("_TASK_14_:");

            Console.Write("Введите длину массива A: \t");
            Int32.TryParse(Console.ReadLine(), out n);

            int[] A14 = new int[n];
            int savenum = 0;

            Console.WriteLine("Введите элементы массива А:");
            for (int i = 0; i < n; i++)
            {
                Int32.TryParse(Console.ReadLine(), out A14[i]);
            }

            for (int i = 0; i < n / 2; i++)
            {
                savenum = A14[i];
                A14[i] = A14[n - (i + 1)];
                A14[n - (i + 1)] = savenum;
            }

            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(A14[i]);
            }

            #endregion

            #region Task 15

            Console.WriteLine("_TASK_15_:");

            Console.Write("Введите длину массива A: \t");
            Int32.TryParse(Console.ReadLine(), out n);

            int[] A15 = new int[n];

            Console.WriteLine("Введите элементы массива А:");
            for (int i = 0; i < n; i++)
            {
                Int32.TryParse(Console.ReadLine(), out A15[i]);
            }

            Console.Write("Введите, насколько сдвигать вправо (m): \t");
            Int32.TryParse(Console.ReadLine(), out m);

            savenum = 0;

            for (int i = 0; i < m; i++)
            {
                savenum = A15[n - 1];
                for (int j = n - 2; j >= 0; j--)
                {
                    A15[j + 1] = A15[j];
                }

                A15[0] = savenum;

            }

            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(A15[i]);
            }

            #endregion

            #endregion

        }
    } 
}