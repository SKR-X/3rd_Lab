using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Project
{ 
    class Lab_3_1
    {
        static void Main(string[] args)
        {
            static double[] InputArray(string tasknumber = "ERROR")
            {
                Console.WriteLine($"{tasknumber} Enter an array like: 1 2 3 4 5");

                string[] strlist = Console.ReadLine().Split();
                double[] numlist = new double[strlist.Length];

                for (int i = 0; i < strlist.Length; i++)
                {
                    if (!double.TryParse(strlist[i], out numlist[i]))
                    {
                        Console.WriteLine($"{tasknumber} Elements of array must be int numbers");
                        return null;
                    }
                }

                if (strlist.Length != numlist.Length)
                {
                    return null;
                }

                return numlist;
            }

            static void PrintAnswerList(double[] result, string tasknumber)
            {
                Console.WriteLine($"Task {tasknumber} answer:");
                Console.WriteLine(String.Join(" ", result));
                return;
            }

            static void PrintAnswerNumber(double result, string tasknumber)
            {
                Console.WriteLine($"Task {tasknumber} answer:");
                Console.WriteLine(result);
                return;
            }

            static bool CheckLength(double[] numlist, int lenght, string tasknumber = "ERROR")
            {
                if (numlist.Length != lenght)
                {
                    Console.WriteLine($"{tasknumber} The lenght of list is different from {lenght}");
                    return false;
                }

                return true;
            }

            // Level 1

            static void task_1_6()
            {
                while (true)
                {
                    double[] numlist = InputArray("1.6");
                    double sum = 0;

                    if (numlist == null) continue;
                    if (!CheckLength(numlist, 5, "1.6")) continue;

                    for (int i = 0; i < numlist.Length; i++)
                    {
                        sum += numlist[i] * numlist[i];
                    }

                    if (CheckLength(numlist, 5, "1.6"))
                    {
                        Console.WriteLine(numlist.Length);
                        Console.WriteLine(String.Join(" ", numlist));
                        PrintAnswerNumber(Math.Pow(sum, 0.5), "1.6");
                        break;
                    }
                }
            }
            //task_1_6();

            static void task_1_10()
            {
                while (true)
                {
                    double p, q;
                    int counter = 0;
                    Console.WriteLine("1.10 Enter P");
                    if (!double.TryParse(Console.ReadLine(), out p))
                    {
                        Console.WriteLine("1.10 P must be number");
                        continue;
                    }
                    Console.WriteLine("1.10 Enter Q");
                    if (!double.TryParse(Console.ReadLine(), out q))
                    {
                        Console.WriteLine("1.10 Q must be number");
                        continue;
                    }

                    double[] numlist = InputArray("1.10");

                    if (numlist == null) continue;
                    if (!CheckLength(numlist, 10, "1.10")) continue;

                    for (int i = 0; i < numlist.Length; i++)
                    {
                        if (p < numlist[i] && numlist[i] < q) counter++;
                    }

                    PrintAnswerNumber(counter, "1.10");
                    break;
                }
            }
            //task_1_10();

            static void task_1_11()
            {
                while (true)
                {
                    double[] numlist = InputArray("1.11");
                    double[] newlist = new double[0];
                    int counter = 0;

                    if (numlist == null) continue;
                    if (!CheckLength(numlist, 10, "1.11")) continue;

                    foreach (double elem in numlist)
                    {
                        if (elem > 0)
                        {
                            Array.Resize(ref newlist, counter + 1);
                            newlist[counter] = elem;
                            counter++;
                        } 
                    }

                    PrintAnswerList(newlist, "1.11");
                    break;
                }
            }
            //task_1_11();

            static void task_1_12()
            {
                while (true)
                {
                    double[] numlist = InputArray("1.12");

                    if (numlist == null) continue;
                    if (!CheckLength(numlist, 8, "1.12")) continue;

                    for (int i = numlist.Length - 1; i >= 0; i--)
                    {
                        if (numlist[i] < 0)
                        {
                            Console.WriteLine($"Task 1.12 Answer:\nElement: {numlist[i]}, Index: {i}");
                            break;
                        }
                        
                    }
                    break;
                }
            }
            //task_1_12();

            static void task_1_13()
            {
                while (true)
                {
                    double[] numlist = InputArray("1.13");
                    double[] frslist = new double[5];
                    double[] seclist = new double[5];

                    if (numlist == null) continue;
                    if (!CheckLength(numlist, 10, "1.13")) continue;

                    for (int i = 0; i < numlist.Length; i++)
                    {
                        if (i % 2 == 0) frslist[i / 2] = numlist[i];
                        if (i % 2 != 0) seclist[(i + 1) / 2 - 1] = numlist[i];
                    }

                    Console.WriteLine($"Task 1.13 answer:");
                    Console.WriteLine($"Even positions nums: {String.Join(" ", frslist)}");
                    Console.WriteLine($"Odd positions nums: {String.Join(" ", seclist)}");
                    break;
                }
            }
            //task_1_13();

            // Level 2

            static void task_2_5()
            {
                while (true)
                {
                    double[] numlist = InputArray("2.5");
                    double[] newlist = new double[numlist.Length];

                    if (numlist == null) continue;

                    double maxel = numlist[0], minel = numlist[0];
                    int maxind = 0, minind = 0, index = 0;

                    for (int i = 0; i < numlist.Length; i++)
                    {
                        if (numlist[i] > maxel)
                        {
                            maxel = numlist[i];
                            maxind = i;
                        }

                        if (numlist[i] < minel)
                        {
                            minel = numlist[i];
                            minind = i;
                        }
                    }

                    for (int i = Math.Min(minind, maxind) + 1; i < Math.Max(minind, maxind); i++)
                    {
                        if (numlist[i] < 0)
                        {
                            newlist[index] = numlist[i];
                            index++;
                        }
                    }

                    double[] answer = new double[index];

                    for (int i = 0; i < answer.Length; i++)
                    {
                        answer[i] = newlist[i];
                    }

                    PrintAnswerList(answer, "2.5");
                    break;
                }
            }
            //task_2_5();

            static void task_2_6()
            {
                double[] numlist = InputArray("2.6");
                double p;



                Console.WriteLine("2.6 Enter P");
                if (!double.TryParse(Console.ReadLine(), out p))
                {
                    return;
                }

                double average = numlist.Average();

                int ind = 0;
                double diff = Math.Abs(average - numlist[0]);
                for (int i = 0; i < numlist.Length; i++)
                {
                    if (diff > Math.Abs(average - numlist[i]))
                    {
                        diff = Math.Abs(average - numlist[i]);
                        ind = i;
                    }
                }

                Array.Resize<double>(ref numlist, numlist.Length + 1);

                for (int i = numlist.Length - 1; i > ind; i--)
                {
                    numlist[i] = numlist[i - 1];
                }

                numlist[ind + 1] = p;

                PrintAnswerList(numlist, "2.6");
            }
            //task_2_6();

            static void task_2_9()
            {
                while (true)
                {
                    double[] numlist = InputArray("2.6");

                    double max = numlist.Max(), min = numlist.Min();
                        
                    int maxInd = Array.IndexOf(numlist, numlist.Max());
                    int minInd = Array.IndexOf(numlist, numlist.Min());
                    int firstInd = Math.Min(maxInd, minInd);
                    int secondInd = Math.Max(minInd, maxInd);

                    double sumOfElements = 0;

                    for (int i = Math.Min(maxInd, minInd) + 1; i < Math.Max(minInd, maxInd); i++)
                    {
                        sumOfElements += numlist[i];
                    }

                    if (secondInd - firstInd <= 1)
                    {
                        Console.WriteLine(0);
                        return;
                    }
                    Console.WriteLine("Task 2.6 answer:");
                    Console.WriteLine(sumOfElements / (secondInd - firstInd - 1));
                }
            }
            //task_2_9();

            static void task_2_10()
            {
                double[] numlist = InputArray("2.11");

                int ind = 0;
                double min = Math.Pow(10, 10);

                for (int i = 0; i < numlist.Length; i++)
                {
                    if (numlist[i] < min && numlist[i] > 0)
                    {
                        min = numlist[i];
                        ind = i;
                    }
                }

                double[] result = new double[numlist.Length - 1];
                int curInd = 0;
                for (int i = 0; i < numlist.Length; i++)
                {
                    if (i != ind)
                    {
                        result[curInd] = numlist[i];
                        curInd++;
                    }
                }
                PrintAnswerList(result, "2.10");
            }
            //task_2_10();

            static void task_2_11()
            {
                double[] numlist = InputArray("2.11");


                Console.WriteLine("2.11 Enter P");
                if (!double.TryParse(Console.ReadLine(), out double p))
                {
                    return;
                }


                int ind = 0;
                for (int i = 0; i < numlist.Length; i++)
                {
                    if (numlist[i] > 0)
                    {
                        ind = i;
                    }
                }

                Array.Resize<double>(ref numlist, numlist.Length + 1);

                for (int i = numlist.Length - 1; i > ind; i--)
                {
                    numlist[i] = numlist[i - 1];
                }

                numlist[ind + 1] = p;

                PrintAnswerList(numlist, "2.11");
            }
            //task_2_11();

            static void task_2_13()
            {
                double[] numlist = InputArray("2.13");

                int ind = 0;
                double max = 0;
                for (int i = 0; i < numlist.Length; i++)
                {
                    Console.WriteLine($"{numlist[i]} {i}");
                    if (numlist[i] > max && i % 2 == 0)
                    {
                        Console.WriteLine(i);
                        ind = i;
                        max = numlist[i];
                    }
                }

                Console.WriteLine(max);
                numlist[ind] = ind;
                PrintAnswerList(numlist, "2.13");
            }
            //task_2_13();

            static void task_2_15()
            {
                double[] a = InputArray("2.15");
                double[] b = InputArray("2.15");

                Console.WriteLine("2.15 Enter K");
                if (!int.TryParse(Console.ReadLine(), out int k))
                {
                    return;
                }

                Array.Resize<double>(ref a, a.Length + b.Length);

                for (int i = a.Length - 1; i > a.Length - b.Length - 1; i--)
                {
                    a[i] = a[i - b.Length];
                }

                for (int i = 0; i < b.Length; i++)
                {
                    a[k + i + 1] = b[i];
                }

                PrintAnswerList(a, "2.15");
            }
            //task_2_15();

            // Level 3

            static void task_3_1()
            {
                double[] newlist = InputArray("3.1");
                double max = 0;
                int count = 0;

                for (int i = 0; i < newlist.Length; i++)
                {
                    if (newlist[i] > max)
                    {
                        max = newlist[i];
                        count = 0;
                    }
                    if (newlist[i] == max)
                    {
                        count += 1;
                    }
                }

                Console.WriteLine($"Task 3.1 answer: {count}");

            }
            //task_3_1();

            static void task_3_5()
            {
                double[] newlist = InputArray("3.5");
                double temp;

                for (int i = 1; i < newlist.Length; i+=2)
                {
                    for (int j = i + 2; j < newlist.Length; j += 2)
                    {
                        if (newlist[i] > newlist[j])
                        {
                            temp = newlist[i];
                            newlist[i] = newlist[j];
                            newlist[j] = temp;
                        }
                    }
                }
                PrintAnswerList(newlist, "3.5");
            }
            //task_3_5();

            static void task_3_8()
            {
                double[] newlist = InputArray("3.8");
                double temp;

                for (int i = 0; i < newlist.Length; i++)
                {
                    if (newlist[i] < 0) {

                        for (int j = i + 1; j < newlist.Length; j++)
                        {
                            if (newlist[j] < 0 && newlist[i] < newlist[j])
                            {
                                temp = newlist[i];
                                newlist[i] = newlist[j];
                                newlist[j] = temp;
                            }
                        }
                    }
                }
                PrintAnswerList(newlist, "3.8");
            }
            //task_3_8();

            static void task_3_9()
            {
                double[] newlist = InputArray("3.9");
                int answer = 0, poscoun = 1, negcoun = 1;

                for (int i = 1; i < newlist.Length; i++)
                {

                    if (newlist[i - 1] < newlist[i])
                    {
                        negcoun = 1;
                        poscoun += 1;
                    }
                    else if (newlist[i - 1] > newlist[i])
                    {
                        poscoun = 1;
                        negcoun += 1;
                    }

                    answer = Math.Max(answer, Math.Max(negcoun, poscoun));
                }
                PrintAnswerNumber(answer, "3.9");
            }
            //task_3_9();

            static void task_3_12()
            {
                double[] newlist = InputArray("3.12");
                int[] poslist = new int[newlist.Length];
                if (!CheckLength(newlist, 12, "3.12")) {
                    return;
                }
                int poscoun = 0;

                for (int i= 0; i < newlist.Length; i++)
                {
                    if (newlist[i] >= 0)
                    {
                        poslist[poscoun] = i;
                        poscoun++;
                    }
                }

                double[] answer = new double[poscoun];

                for (int i = 0; i < answer.Length; i++)
                {
                    answer[i] = newlist[poslist[i]];
                }

                PrintAnswerList(answer, "3.12");
            }
            //task_3_12();

            static void task_3_13()
            {
                double[] newlist = InputArray("3.13");
                int[] ansind = new int[newlist.Length];
                int posind = 0;
                bool flag;

                for (int i = 0; i < newlist.Length; i++)
                {
                    flag = true;

                    for (int j = 0; j < i; j++)
                    {
                        if (newlist[i] == newlist[j])
                        {
                            flag = false;
                        }
                    }

                    if (flag)
                    {
                        ansind[posind] = i;
                        posind++;
                    }
                }

                double[] asnwer = new double[posind];

                for (int i = 0; i < asnwer.Length; i++)
                {
                    asnwer[i] = newlist[ansind[i]];
                }

                PrintAnswerList(asnwer, "3.13");
            }
            //task_3_13();

            // 11-15 end of theory

            static void task_11()
            {
                double[] newlist = InputArray("11"); // Since the task says that the array is sorted, sorting does not make sense.
                Console.WriteLine("Enter x");
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    return;
                }
                int i, fr = 0, ls = newlist.Length - 1;

                while (ls - fr > 1)
                {
                    i = (ls + fr) / 2;

                    if (x == newlist[i])
                    {
                        PrintAnswerNumber(i, "11");
                        break;
                    }
                    else if (x < newlist[i])
                    {
                        ls = i - 1;
                    }
                    else
                    {
                        fr = i + 1;
                    }
                
                }
            }
            //task_11();

            static void task_12()
            {
                double[] a = InputArray("12");

                if (a == null)
                {
                    return;
                }

                double[] b = InputArray("12");

                if (b == null)
                {
                    return;
                }

                double[] c = new double[a.Length + b.Length];

                int minsize = Math.Min(a.Length, b.Length);

                for (int i = 0; i < minsize; i++)
                {
                    c[2 * i] = a[i];
                    c[2 * i + 1] = b[i];
                }

                if (a.Length != b.Length)
                {
                    int curind = minsize * 2;
                    if (a.Length > b.Length)
                    {
                        for (int i = minsize; i < a.Length; i++)
                        {
                            c[curind] = a[i];
                            curind++;
                        }
                    }
                    else
                    {
                        for (int i = minsize; i < b.Length; i++)
                        {
                            c[curind] = b[i];
                            curind++;
                        }
                    }
                }

                PrintAnswerList(c, "12");
            }
            //task_12();

            static void task_13()
            {
                double[] a = InputArray("13");
                double[] b = InputArray("13");

                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] < a[j])
                        {
                            double temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < b.Length; i++)
                {
                    for (int j = i + 1; j < b.Length; j++)
                    {
                        if (b[i] < b[j])
                        {
                            double temp = b[i];
                            b[i] = b[j];
                            b[j] = temp;
                        }
                    }
                }

                int inda = 0, indb = 0;
                double[] c = new double[a.Length + b.Length];

                for (int i = 0; i < c.Length; i++)
                {
                    if (inda == a.Length)
                    {
                        c[i] = b[indb];
                        indb++;
                        continue;
                    }
                    if (indb == b.Length)
                    {
                        c[i] = a[inda];
                        inda++;
                        continue;
                    }
                    if (a[inda] > b[indb])
                    {
                        c[i] = a[inda];
                        inda++;
                    }
                    else
                    {
                        c[i] = b[indb];
                        indb++;
                    }
                }

                PrintAnswerList(c, "13");
            }
            //task_13();

            static void task_14()
            {
                double[] nums = InputArray("14");

                for (int i = 0; i < nums.Length / 2; i++)
                {
                    double temp = nums[i];
                    nums[i] = nums[nums.Length - i - 1];
                    nums[nums.Length - i - 1] = temp;
                }

                PrintAnswerList(nums, "14");
            }
            //task_14();

            static void task_15()
            {
                double[] nums = InputArray("15");
                double[] answer = new double[nums.Length];
                int curind = 0;

                if (!int.TryParse(Console.ReadLine(), out int n))
                {
                    return;
                }

                for (int i = nums.Length - (n % nums.Length); i < nums.Length; i++)
                {
                    answer[curind] = nums[i];
                    curind++;
                }

                for (int i = 0; i < nums.Length - (n % nums.Length); i++)
                {
                    answer[curind] = nums[i];
                    curind++;
                }

                PrintAnswerList(answer, "15");

            }
            task_15();
        }
    }
}