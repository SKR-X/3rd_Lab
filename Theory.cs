using System;
using System.Threading.Channels;

namespace _3rd_Lab
{
    class Tasks
    {
        static void Main(string[] args)
        {
            string s;
            int n;
            double L = 0;
            int k = 0;
            int m;
            double sum = 0;
            double delta = 0;
            int deltai = 0;
            int count = 0;
            double maxN = double.MinValue, minN = double.MaxValue;
            int maxI = 0, minI = 0;
            double P;
            Console.WriteLine("1st level");
            
            void Task6_1lvl()
            {
                Console.WriteLine("6 task:");
                double[] coordinates = new double[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Введите {i} член массива");
                    s = Console.ReadLine();
                    coordinates[i] = double.Parse(s);
                    L += (coordinates[i] * coordinates[i]);
                }
            
                Console.WriteLine($"Длина вектора будет равна {Math.Sqrt(L)}");
            }
            void Task10_1lvl()
            {
                Console.WriteLine("10 task:");
                double[] nums = new double[10];
                Console.WriteLine("Enter the P:");
                double P = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Q:");
                double Q = double.Parse(Console.ReadLine());
                if (P < Q)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        s = Console.ReadLine();
                        nums[i] = double.Parse(s);
                        if (nums[i] > P && nums[i] < Q) count++;
                    }
                }
                else Console.WriteLine("P must be more then Q");
            
                Console.WriteLine($"The number of numbers enclosed between P and Q are {count}");
            }
            void Task11_1lvl()
            {
                Console.WriteLine("11 task:");
                double[] allnums = new double[10];
                double[] posnums = new double[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Enter the {i} element for array:");
                    s = Console.ReadLine();
                    allnums[i] = double.Parse(s);
                    if (allnums[i] > 0)
                    {
                        posnums[k] = allnums[i];
                        k++;
                    }
                }

                Console.WriteLine("Array only with positive numbers:");
                for (int i = 0; i < k; i++)
                {
                    Console.Write(posnums[i]);
                    Console.Write(" ");
                }
            }
            void Task12_1lvl()
            {
                Console.WriteLine("12 task:");
                k = 0;
                double lastneg = 0;
                double[] allnums2 = new double[8];
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine($"Enter the {i} element for array:");
                    s = Console.ReadLine();
                    allnums2[i] = double.Parse(s);
                    if (allnums2[i] < 0)
                    {
                        lastneg = allnums2[i];
                        k = i;
                    }
                }
            
                Console.WriteLine($"Last negative element is {lastneg}, his index is {k}");
            }
            void Task13_1lvl()
            {
                Console.WriteLine("13 task:");
                double[] allnums3 = new double[10];
                double[] evennum = new double[5];
                double[] oddnum = new double[5];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Enter the {i} element for array:");
                    s = Console.ReadLine();
                    allnums3[i] = double.Parse(s);
                    if (i % 2 == 0)
                    {
                        evennum[i / 2] = allnums3[i];
                    }
                    else oddnum[i / 2] = allnums3[i];
                }

                Console.WriteLine("Array with elements on even indexes:");
                Console.WriteLine(String.Join(" ", evennum));
                Console.WriteLine("Array with elements on odd indexes:");
                Console.WriteLine(String.Join(" ", oddnum));
            }
            
            Console.WriteLine("2nd level");
            void Task5_2lvl()
            {
                Console.WriteLine("5 task:");
                count = 0;
                k = 0;
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] allnums4 = new double[n];
                    double[] negnums = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter the {i} element for array:");
                        s = Console.ReadLine();
                        allnums4[i] = double.Parse(s);
                        if (allnums4[i] > maxN)
                        {
                            maxI = i;
                            maxN = allnums4[i];
                        }
                        if (allnums4[i] < minN)
                        {
                            minI = i;
                            minN = allnums4[i];
                        }
                    }
                    for (int i = (Math.Min(maxI, minI) + 1); i <= Math.Max(maxI, minI); i++)
                    {
                        if (allnums4[i] > 0) continue;
                        negnums[k] = allnums4[i];
                        k++;
                    }
                    Console.WriteLine($"Array with negative numbers:");
                    for (int i = 0; i < k; i++)
                    {
                        Console.Write(negnums[i] + " ");
                    }
                }
            }
            void Task6_2lvl()
            {
                Console.WriteLine("6 task:");
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Enter the P number:");
                    if (double.TryParse(Console.ReadLine(), out P))
                    {
                        double[] allnums5 = new double[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Enter the {i} element for array:");
                            s = Console.ReadLine();
                            allnums5[i] = double.Parse(s);
                            sum += allnums5[i];
                        }

                        Console.WriteLine("Source array:");
                        Console.WriteLine(String.Join(" ", allnums5));
                        sum = sum / n;
                        delta = Math.Abs(Math.Abs(allnums5[0]) - Math.Abs(sum));
                        deltai = 0;
                        for (int i = 1; i < n; i++)
                        {
                            if (Math.Abs(Math.Abs(allnums5[i]) - Math.Abs(sum)) < delta)
                            {
                                delta = Math.Abs(Math.Abs(allnums5[i]) - Math.Abs(sum));
                                deltai = i;
                            }
                        }
            
                        allnums5[deltai + 1] = P;
                        Console.WriteLine("Final array:");
                        Console.WriteLine(String.Join(" ", allnums5));
                    
                    }
                }
            }
            void Task9_2lvl()
            {
                Console.WriteLine("9 task:");
                maxN = double.MinValue; 
                minN = double.MaxValue;
                maxI = 0;
                minI = 0;
                count = 0;
                sum = 0;
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] allnums6 = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter the {i} element for array:");
                        s = Console.ReadLine();
                        allnums6[i] = double.Parse(s);
                        if (allnums6[i] > maxN)
                        {
                            maxN = allnums6[i];
                            maxI = i;
                        }
            
                        if (allnums6[i] < minN)
                        {
                            minN = allnums6[i];
                            minI = i;
                        }
                    }
            
                    for (int i = (Math.Min(minI, maxI) + 1); i < Math.Max(minI, maxI); i++)
                    {
                        sum += allnums6[i];
                        count++;
                    }
                    Console.WriteLine($"Arithmetic mean is {sum / count}");
                }
            }
            void Task10_2lvl()
            {
                Console.WriteLine("10 task:");
                k = 0;
                minN = double.MaxValue;
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] allnums7 = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter the {i} element for array:");
                        s = Console.ReadLine();
                        allnums7[i] = double.Parse(s);
                        if (allnums7[i] > 0 && allnums7[i] < minN)
                        {
                            minN = allnums7[i];
                            k = i;
                        }
                    }

                    Console.WriteLine("Source array:");
                    Console.WriteLine(String.Join(" ", allnums7));
                    Console.WriteLine("Final array:");
                    for (int i = 0; i < n; i++)
                    {
                        if (i == k) continue;
                        Console.Write(allnums7[i] + " ");
                    }
                }
            }
            void Task11_2lvl()
            {
                Console.WriteLine("11 task:");
                k = 0;
                double prev = 0, next = 0;
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Enter the P number:");
                    if (double.TryParse(Console.ReadLine(), out P))
                    {
                        double[] allnums8 = new double[n + 1];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Enter the {i} element for array:");
                            s = Console.ReadLine();
                            allnums8[i] = double.Parse(s);
                            if (allnums8[i] > 0) k = i;
                        }
                        
                        Console.WriteLine("Source array:");
                        Console.WriteLine(String.Join(" ", allnums8.Take(n)));
                        prev = allnums8[k + 1];
                        for (int i = 0; i < n; i++)
                        {
                            if (i >= (k + 1))
                            {
                                next = allnums8[i + 1];
                                allnums8[i + 1] = prev;
                                prev = next;
                            }
                        }
                        allnums8[k + 1] = P;
                        Console.WriteLine("Final array:");
                        Console.WriteLine(String.Join(" ", allnums8));
                    }
                }
            }
            void Task13_2lvl()
            {
                Console.WriteLine("13 task:");
                maxN = double.MinValue;
                maxI = 0;
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] allnums9 = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter the {i} element for array:");
                        s = Console.ReadLine();
                        allnums9[i] = double.Parse(s);
                        if (i % 2 == 0 && allnums9[i] > maxN)
                        {
                            maxN = allnums9[i];
                            maxI = i;
                        }
                    }

                    Console.WriteLine("Source array:");
                    Console.WriteLine(String.Join(" ", allnums9));
                    allnums9[maxI] = maxI;
                    Console.WriteLine("Final array:");
                    Console.WriteLine(String.Join(" ", allnums9));
                }
            }
            void Task15_2lvl()
            {
                Console.WriteLine("15 task:");
                Console.WriteLine("Enter the lenght of the 1 array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Enter the lenght of the 2 array:");
                    if (int.TryParse(Console.ReadLine(), out m))
                    {
                        Console.WriteLine("Enter the k number:");
                        if (int.TryParse(Console.ReadLine(), out k))
                        {
                            double[] arrayA = new double[n + m];
                            double[] arrayB = new double[m];
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine($"Enter the {i} element for A array:");
                                s = Console.ReadLine();
                                arrayA[i] = double.Parse(s);
                            }
                            for (int i = 0; i < m; i++)
                            {
                                Console.WriteLine($"Enter the {i} element for B array:");
                                s = Console.ReadLine();
                                arrayB[i] = double.Parse(s);
                            }

                            Console.WriteLine("Source A array:");
                            Console.WriteLine(String.Join(" ", arrayA.Take(n)));
                            Console.WriteLine("Source B array:");
                            Console.WriteLine(String.Join(" ", arrayB));
                            for (int i = m + k + 1, j = 1; i < n + m; i++, j++)
                            {
                                arrayA[i] = arrayA[k + j];
                            }
                            for (int i = 1; i <= m; i++)
                            {
                                arrayA[k + i] = arrayB[i - 1];
                            }

                            Console.WriteLine("Final array:");
                            Console.WriteLine(String.Join(" ", arrayA));
                        }
                    }
                }
            }
            
            Console.WriteLine("3rd level");
            
            void Task1_3lvl()
            {
                Console.WriteLine("1 task:");
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] allnums8 = new double[n];
                    int[] arrayI = new int[1000];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter the {i} element for array:");
                        s = Console.ReadLine();
                        allnums8[i] = double.Parse(s);
                        if (allnums8[i] > maxN)
                        {
                            maxN = allnums8[i];
                            k = 0;
                            arrayI[k] = i;
                        }
                        else if (allnums8[i] == maxN)
                        {
                            k++;
                            arrayI[k] = i;
                        }
                    }

                    Console.WriteLine("Array with indexes:");
                    Console.WriteLine(String.Join(" ", arrayI.Take(k + 1)));
                }
            }
            void Task5_3lvl()
            {
                Console.WriteLine("5 task:");
                double amin;
                int imin;
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] allnums = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter the {i} element for array:");
                        s = Console.ReadLine();
                        allnums[i] = double.Parse(s);
                    }

                    for (int i = 0; i < n - 2; i += 2)
                    {
                        amin = allnums[i];
                        imin = i;
                        for (int j = i + 2; j < n; j += 2)
                        {
                            if (allnums[j] < amin)
                            {
                                amin = allnums[j];
                                imin = j;
                            }
                        }

                        allnums[imin] = allnums[i];
                        allnums[i] = amin;
                    }

                    Console.WriteLine("Final array:");
                    Console.WriteLine(String.Join(" ", allnums));
                }
            }
            void Task8_3lvl()
            {
                Console.WriteLine("8 task:");
                double amax;
                int imax;
                k = 0;
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] allnums = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter the {i} element for array:");
                        s = Console.ReadLine();
                        allnums[i] = double.Parse(s);
                        if (k == 0 && allnums[i] < 0) k = (i + 1);
                    }

                    k -= 1;
                    for (int i = k; i < n - 1; i++)
                    {
                        if (allnums[i] > 0) continue;
                        amax = allnums[i];
                        imax = i;
                        Console.WriteLine($"{amax}, {imax}");
                        for (int j = i + 1; j < n; j++)
                        {
                            if (allnums[j] > 0) continue;
                            if (allnums[j] > amax)
                            {
                                amax = allnums[j];
                                imax = j;
                            }
                        
                        }
                        allnums[imax] = allnums[i];
                        allnums[i] = amax;

                    }

                    Console.WriteLine("Final array:");
                    Console.WriteLine(String.Join(" ", allnums));
                }
            }
            void Task9_3lvl()
            {
                Console.WriteLine("9 task:");
                bool flag1 = true, flag2 = true;
                int k1 = 1, k2 = 1;
                int maxB = 0, maxM = 0;
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] allnums = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter the {i} element for array:");
                        s = Console.ReadLine();
                        allnums[i] = double.Parse(s);
                    }

                    for (int i = 0; i < n - 1; i++)
                    {
                        if (allnums[i + 1] > allnums[i])
                        {
                            k1++;
                        }
                        else
                        {
                            maxB = Math.Max(maxB, k1);
                            k1 = 1;
                        }
                        if (allnums[i + 1] < allnums[i])
                        {
                            k2++;
                        }
                        else
                        {
                            maxM = Math.Max(maxM, k2);
                            k2 = 1;
                        }
                    }

                    maxB = Math.Max(maxB, k1);
                    maxM = Math.Max(maxM, k2);

                    Console.WriteLine("Biggest subsequence lenght:");
                    Console.WriteLine(Math.Max(maxM, maxB));
                }
            }
            void Task12_3lvl()
            {
                Console.WriteLine("12 task:");
                n = 12;
                int x;
                double[] allnums9 = new double[12];
                List<int> indexes = new List<int>();
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine($"Enter the {i} element for array:");
                    s = Console.ReadLine();
                    allnums9[i] = double.Parse(s);
                    if (allnums9[i] < 0) indexes.Add(i);
                }

                Console.WriteLine("Source array:");
                Console.WriteLine(String.Join(" ", allnums9));
                for (int j = 0; j < (indexes.Count); j++)
                {
                    x = indexes[j] - j;
                    n -= 1;
                    for (int i = x; i < n; i++)
                    {
                        allnums9[i] = allnums9[i + 1];
                    }
                }

                Console.WriteLine("Final array:");
                Console.WriteLine(string.Join(" ", allnums9.Take(n)));
            }
            void Task13_3lvl()
            {
                Console.WriteLine("13 task:");
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] allnums10 = new double[n];
                    List<double> recurring = new List<double>();
                    for (int i = 0; i < n; i++)
                    {
                        s = Console.ReadLine();
                        allnums10[i] = double.Parse(s);
                        if (recurring.Contains(allnums10[i]) == true) continue;
                        else recurring.Add(allnums10[i]);
                    }

                    Console.WriteLine(string.Join(" ", recurring));
                }
            }
            
            Console.WriteLine("Algoritms");
            
            void BinarySearch()
            {
                Console.WriteLine("Binary Search");
                Console.WriteLine("Enter the lenght of the array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] array = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter the {i} element for array:");
                        s = Console.ReadLine();
                        array[i] = double.Parse(s);
                    }
                    Array.Sort(array);
                    Console.WriteLine("Enter the number which you want to find:");
                    double number;
                    number = double.Parse(Console.ReadLine());
                    int i1 = 0, i2 = n - 1;
                    k = (i1 + i2) / 2;
                    while (array[k] != number)
                    {
                        if (number < array[k]) i2 = k - 1;
                        else i1 = k + 1;
                        k = (i1 + i2) / 2;
                        if (i1 > i2) break;
                    }

                    if (i1 > i2) Console.WriteLine("Unlucky");
                    else Console.WriteLine("Lucky");
                }
            }
            void Unification1()
            {
                Console.WriteLine("Unification1");
                k = 0;
                Console.WriteLine("Enter the lenght for first array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Enter the lenght for second array:");
                    if (int.TryParse(Console.ReadLine(), out m))
                    {
                        double[] arrayA = new double[n];
                        double[] arrayB = new double[m];
                        double[] arrayC = new double[n + m];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Enter the {i} element for A array");
                            s = Console.ReadLine();
                            arrayA[i] = double.Parse(s);
                        }
                        for (int i = 0; i < m; i++)
                        {
                            Console.WriteLine($"Enter the {i} element for B array");
                            s = Console.ReadLine();
                            arrayB[i] = double.Parse(s);
                        }

                        for (int i = 0; i < Math.Min(n, m); i++)
                        {
                            arrayC[2 * i] = arrayA[i];
                            arrayC[2 * i + 1] = arrayB[i];
                        }

                        if (n > m)
                        {
                            for (int i = 2 * m; i < (n + m); i++)
                            {
                                arrayC[i] = arrayA[m + k];
                                k++;
                            }

                            Console.WriteLine("The final array:");
                            Console.WriteLine(string.Join(" ", arrayC));
                        }
                        else if (n < m)
                        {
                            for (int i = 2 * n; i < (n + m); i++)
                            {
                                arrayC[i] = arrayB[n + k];
                                k++;
                            }
                            Console.WriteLine("The final array:");
                            Console.WriteLine(string.Join(" ", arrayC));
                        }
                        else
                        {
                            Console.WriteLine("The final array:");
                            Console.WriteLine(string.Join(" ", arrayC));
                        }
                    }
                }
            }
            void Unification2()
            {
                Console.WriteLine("Unification2");
                int I = 0, J = 0;
                Console.WriteLine("Enter the lenght of 1 array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] arrayA = new double[n];
                    Console.WriteLine("Enter the lenght of 2 array:");
                    if (int.TryParse(Console.ReadLine(), out m))
                    {
                        double[] arrayB = new double[m];
                        double[] arrayC = new double[n + m];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Enter the {i} element for A array:");
                            s = Console.ReadLine();
                            arrayA[i] = double.Parse(s);
                        }
                        for (int i = 0; i < m; i++)
                        {
                            Console.WriteLine($"Enter the {i} element for B array:");
                            s = Console.ReadLine();
                            arrayB[i] = double.Parse(s);
                        }
                        Array.Sort(arrayA);
                        Array.Sort(arrayB);
                        Array.Reverse(arrayA);
                        Array.Reverse(arrayB);
                        Console.WriteLine("First array:");
                        Console.WriteLine(String.Join(" ", arrayA));
                        Console.WriteLine("Second array:");
                        Console.WriteLine(String.Join(" ", arrayB));
                        for (int i = 0; i < (n + m); i++)
                        {
                            if (I < n && J < m)
                            {
                                if (arrayA[I] >= arrayB[J])
                                {
                                    arrayC[i] = arrayA[I];
                                    I++;
                                }
                                else
                                {
                                    arrayC[i] = arrayB[J];
                                    J++;
                                }
                            }
                            else
                            {
                                if (J >= m)
                                {
                                    arrayC[i] = arrayA[I];
                                    I++;
                                }
                                else if (I >= n)
                                {
                                    arrayC[i] = arrayB[J];
                                    J++;
                                }
                            }
                            
                        }

                        Console.WriteLine("Final array:");
                        Console.WriteLine(String.Join(" ", arrayC));
                    }
                }
            }
            void Reverse()
            {
                Console.WriteLine("Reverse");
                double G = 0;
                Console.WriteLine("Enter the lenght for array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    double[] allnums = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Enter the {i} element for array:");
                        s = Console.ReadLine();
                        allnums[i] = double.Parse(s);
                    }

                    Console.WriteLine(String.Join(" ", allnums));
                    n -= 1;
                    for (int i = 0; i <= (n / 2); i++)
                    {
                        G = allnums[i];
                        allnums[i] = allnums[n - i];
                        allnums[n - i] = G;
                    }

                    Console.WriteLine(String.Join(" ", allnums));
                }
            }
            void CycleShift()
            {
                Console.WriteLine("Cycle Shift");
                Console.WriteLine("Enter the lenght for array:");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Enter the m:");
                    if (int.TryParse(Console.ReadLine(), out m))
                    {
                        double next = 0, prev = 0;
                        double[] allnums = new double[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Enter the {i} element for array:");
                            s = Console.ReadLine();
                            allnums[i] = double.Parse(s);
                        }

                        Console.WriteLine("Array:");
                        Console.WriteLine(String.Join(" ", allnums));
                        for (int i = 0; i < m; i++)
                        {
                            prev = allnums[0];
                            for (int j = 0; j < (n - 1); j++)
                            {
                                next = allnums[j + 1];
                                allnums[j + 1] = prev;
                                prev = next;
                            }

                            allnums[0] = prev;
                        }

                        Console.WriteLine("Final array:");
                        Console.WriteLine(String.Join(" ", allnums));
                    }
                }
            }
            Task6_1lvl();
            Task10_1lvl();
            Task11_1lvl();
            Task12_1lvl();
            Task13_1lvl();
            Task5_2lvl();
            Task6_2lvl();
            Task9_2lvl();
            Task10_2lvl();
            Task11_2lvl();
            Task13_2lvl();
            Task15_2lvl();
            Task1_3lvl();
            Task5_3lvl();
            Task8_3lvl();
            Task9_3lvl();
            Task12_3lvl();
            Task13_3lvl();
            BinarySearch();
            Unification1();
            Unification2();
            Reverse();
            CycleShift();
        }
    }
}
