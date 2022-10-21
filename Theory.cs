using System;

namespace _3rd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region Task 1.6
            {
                const int l16= 5;
                double[] a16 = new double[l16];
                for (int i = 0; i < a16.Length; i++)
                {
                    double el16;
                    Console.WriteLine($"Enter {i} element");
                    double.TryParse(Console.ReadLine(),out el16);
                    a16[i] = el16;
                }
                double l=0;
                for(int i=0;i<l16;i++)
                {
                    l += (a16[i] * a16[i]);
                }
                l = Math.Pow(l, 0.5);
                Console.WriteLine($"Answer for 1.6 is {l}");
            }
            #endregion
            #region Task10
            {
                const int l10 = 10;
                int k10 = -1, k101 = -1;
                double[] a10 = new double[l10];
                Console.WriteLine("Enter P");
                double P, Q;
                bool success10 = double.TryParse(Console.ReadLine(), out P);
                if (success10)
                {
                    Console.WriteLine("Enter Q");
                    bool succes10 = double.TryParse(Console.ReadLine(), out Q);
                    if (succes10)
                    {
                        for (int i = 0; i < l10; i++)
                        {
                            double el10;
                            Console.WriteLine($"Enter {i} element ");
                            double.TryParse(Console.ReadLine(), out el10);
                            a10[i] = el10;
                        }
                        for (int i1 = 0; i1 < l10; i1++)
                        {
                            if (a10[i1] == P)
                            {
                                k10 = i1;
                            }
                            if (a10[i1] == Q)
                            {
                                k101 = i1;
                            }
                        }
                        if ((k10 != -1) && (k101 != -1))
                        {
                            Console.WriteLine($"There are {Math.Abs(k101 - k10) - 1} elements between P and Q");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("INCORRECT VALUE");
                }
            }
            #endregion
            #region Task11
            {
                const int n = 10;
                int nu11=0;
                double[] a = new double[n];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    double elem;
                    Console.WriteLine($"Enter el {i} of massive");
                    double.TryParse(Console.ReadLine(), out elem);
                    a[i] = elem;
                    if (elem > 0)
                        nu11++;
                }
                double[] b = new double[nu11];
                foreach (double x in a)
                {
                    if (x > 0)
                    {
                        b[k] = x;
                        k += 1;
                    }
                }
                for (int i1 = 0; i1 < nu11; i1++)
                    Console.Write("{0:f1} ", b[i1]);
                Console.WriteLine();
            }
            #endregion
            #region Task12
            {
                const int m = 8;
                double val = -10;
                int iel = 0;
                double[] c = new double[m];
                for (int i = 0; i < m; i++)
                {
                    double el = 0;
                    Console.WriteLine($"Enter el {i}: ");
                    double.TryParse(Console.ReadLine(), out el);
                    c[i] = el;
                }
                for (int i1 = m - 1; i1 >= 0; i1--)
                {
                    if (c[i1] < 0)
                    {
                        iel = i1;
                        val = c[i1];
                        break;
                    }
                }
                if (val != -10)
                    Console.WriteLine($"Number of el is {iel}, value is {val}");
                if (val == -10)
                    Console.WriteLine("No negative number");
            }
            #endregion
            #region Task13
            {
                const int len = 10, l = 5;
                int k1 = 0, k2 = 0;
                double[] mas = new double[len];
                double[] masch = new double[l];
                double[] masnch = new double[l];
                for (int i = 0; i < len; i++)
                {
                    double el13;
                    Console.WriteLine($"Enter value of el {i}");
                    double.TryParse(Console.ReadLine(), out el13);
                    mas[i] = el13;
                }
                for (int i = 0; i < len; i++)
                {
                    if (i%2==0)
                    {
                        masch[k1] = mas[i];
                        k1 += 1;
                    }
                    else
                    {
                        masnch[k2] = mas[i];
                        k2 += 1;
                    }
                }
                foreach (double x in masch)
                    Console.Write("{0:f1} ", x);
                Console.WriteLine();
                foreach (double y in masnch)
                    Console.Write("{0:f1} ", y);
                Console.WriteLine();
            }
            #endregion
            #region Task2.5
            {
                Console.WriteLine("Enter length of massive");
                int l26;
                bool success26 = int.TryParse(Console.ReadLine(), out l26);
                if (success26)
                {
                    double[] a26 = new double[l26];
                    double[] b26 = new double[l26];
                    for (int i = 0; i < l26; i++)
                    {
                        double el26;
                        Console.WriteLine($"Enter {i} element");
                        double.TryParse(Console.ReadLine(), out el26);
                        a26[i] = el26;
                    }
                    int a26maxi = 0;
                    int a26mini = 0;
                    double a26max = a26[0];
                    double a26min = a26[0];
                    for (int i1 = 0; i1 < l26; i1++)
                    {
                        if (a26[i1] > a26max)
                        {
                            a26max = a26[i1];
                            a26maxi = i1;
                        }
                        if (a26[i1] < a26min)
                        {
                            a26min = a26[i1];
                            a26mini = i1;
                        }
                    }
                    int k26 = Math.Abs(a26mini - a26maxi);
                    int kf26 = 0;
                    if (a26mini > a26maxi)
                    {
                        for (int i = a26maxi + 1; i < a26mini; i++)
                        {
                            if (a26[i] < 0)
                            {
                                b26[kf26] = a26[i];
                                kf26 += 1;
                            }
                        }
                    }
                    if (a26mini < a26maxi)
                    {
                        for (int i = a26mini + 1; i < a26maxi; i++)
                        {
                            if (a26[i] < 0)
                            {
                                b26[kf26] = a26[i];
                                kf26 += 1;
                            }
                        }
                    }
                    for (int i = 0; i < kf26; i++)
                        Console.Write("{0:} ", b26[i]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Incorrect length");
                }
            }
            #endregion
            #region Task2.6
            {
                double p26;
                Console.WriteLine("Enter p26");
                bool success25 = double.TryParse(Console.ReadLine(), out p26);
                if (success25)
                {
                    int l25;
                    Console.WriteLine("Enter lenght of massive");
                    int.TryParse(Console.ReadLine(), out l25);
                    double[] a25 = new double[l25+1];
                    for(int i=0;i<l25;i++)
                    {
                        double el25;
                        Console.WriteLine($"Enter {i} element");
                        double.TryParse(Console.ReadLine(), out el25);
                        a25[i] = el25;
                    }
                    double sm25 = 0;
                    int c25 = 0;
                    for(int i=0;i<l25;i++)
                    {
                        sm25 += a25[i];
                        c25 += 1;
                    }
                    double sr25 = sm25 / c25;
                    double k25 = Math.Abs(a25[0]-sr25);
                    int i25 = 0;
                    for(int i=0;i<l25;i++)
                    {
                        if ((Math.Abs(a25[i]-sr25)<k25))
                        {
                            k25 = Math.Abs(a25[i] - sr25);
                            i25 = i;
                        }
                    }
                    for(int i=l25-1;i>i25;i--)
                    {
                        a25[i + 1] = a25[i];
                    }
                    a25[i25 + 1] = p26;
                    foreach (double x in a25)
                        Console.Write("{0:} ", x);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Incorrect Value");
                }
            }
            #endregion
            #region Task2.9
            {
                int l29;
                Console.WriteLine("Enter lenght of massive");
                bool success29=int.TryParse(Console.ReadLine(), out l29);
                if(success29)
                {
                    double[] a29 = new double[l29];
                    for (int i1 = 0; i1 < l29; i1++)
                    {
                        double el29;
                        Console.WriteLine($"Enter {i1} element");
                        double.TryParse(Console.ReadLine(), out el29);
                        a29[i1] = el29;
                    }
                    double amx29 = a29[0], amn29 = a29[0];
                    int amxi29 = 0, amni29 = 0;
                    for (int i = 0; i < l29; i++)
                    {
                        if (a29[i] > amx29)
                        {
                            amx29 = a29[i];
                            amxi29 = i;
                        }
                        if (a29[i] < amn29)
                        {
                            amn29 = a29[i];
                            amni29 = i;
                        }
                    }
                    double sm29 = 0;
                    int c29 = 0;
                    if ((Math.Abs(amni29 - amxi29) - 1) > 0)
                    {
                        if (amni29 > amxi29)
                        {
                            for (int i = amxi29 + 1; i < amni29; i++)
                            {
                                sm29 += a29[i];
                                c29 += 1;
                            }
                        }
                        else if (amni29 < amxi29)
                        {
                            for (int i = amni29 + 1; i < amxi29; i++)
                            {
                                sm29 += a29[i];
                                c29 += 1;
                            }
                        }
                        double ans29 = sm29 / c29;
                        Console.WriteLine($"Answer for 2.9 is {ans29}");
                    }
                    else
                    {
                        Console.WriteLine("Answer is 0");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                }
            }
            #endregion
            #region Task2.10
            {
                int l210;
                Console.WriteLine("Enter Lenght of massive 2.10");
                bool success210 = int.TryParse(Console.ReadLine(), out l210);
                if (success210)
                {
                    double[] a210 = new double[l210];
                    int n210 = l210 - 1;
                    for (int i = 0; i < l210; i++)
                    {
                        double el210;
                        Console.WriteLine($"Enter {i} elemnts");
                        double.TryParse(Console.ReadLine(), out el210);
                        a210[i] = el210;
                    }
                    double a210min = Math.Abs(a210[0]);
                    int i210min = 0;
                    for (int i = 0; i < l210; i++)
                    {
                        if (a210min > a210[i] && a210[i] > 0)
                        {
                            a210min = a210[i];
                            i210min = i;
                        }
                    }
                    for (int i = i210min; i < n210; i++)
                    {
                        a210[i] = a210[i + 1];
                    }
                    for (int i = 0; i < n210; i++)
                        Console.Write("{0:} ", a210[i]);
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("Incorrect value");
            }
            #endregion
            #region Task2.11
            {
                double p211;
                int count211 = 0;
                Console.WriteLine("Enter P");
                bool success211=double.TryParse(Console.ReadLine(), out p211);
                if(success211)
                {
                    int l211;
                    Console.WriteLine("Enter lenght of massive");
                    bool sucess211=int.TryParse(Console.ReadLine(), out l211);
                    if(sucess211)
                    {
                        double[] a211 = new double[l211 + 1];
                        for (int i = 0; i < l211; i++)
                        {
                            double el211;
                            Console.WriteLine($"Enter {i} element");
                            double.TryParse(Console.ReadLine(), out el211);
                            if (el211>0)
                            {
                                count211++;
                            }
                            a211[i] = el211;
                        }
                        if(count211>0)
                        {
                            for (int i = l211 - 1; i >= 0; i--)
                            {
                                if (a211[i] <= 0)
                                {
                                    a211[i + 1] = a211[i];
                                }
                                else if (a211[i] > 0)
                                {
                                    a211[i + 1] = p211;
                                    break;
                                }

                            }
                            foreach (double x in a211)
                                Console.Write("{0} ", x);
                            Console.WriteLine();
                        }
                        else
                            Console.WriteLine("You havent mentioned positive number");

                    }
                    else
                        Console.WriteLine("Incorrect value");
                }
                else
                {
                    Console.WriteLine("Incorrect P");
                }
            }
            #endregion
            #region Task 2.13
            {
                int l213;
                Console.WriteLine("Enter lenght of massive");
                bool sucess213=int.TryParse(Console.ReadLine(),out l213);
                if(sucess213)
                {
                    double[] a213 = new double[l213];
                    for (int i = 0; i < l213; i++)
                    {
                        double el213;
                        Console.WriteLine($"Enter {i} element");
                        double.TryParse(Console.ReadLine(), out el213);
                        a213[i] = el213;
                    }
                    double amx213 = a213[0];
                    int k213 = 0;
                    for (int i = 0; i < l213; i += 2)
                    {
                        if (a213[i] > amx213)
                        {
                            amx213 = a213[i];
                            k213 = i;
                        }
                    }
                    a213[k213] = k213;
                    foreach (double x in a213)
                        Console.Write("{0:} ", x);
                }
                else
                    Console.WriteLine("Incorrect value");
            }
            #endregion
            #region Task2.15
            {
                int k215,l215,n215;
                Console.WriteLine("Enter k215");
                bool success215=int.TryParse(Console.ReadLine(), out k215);
                if(success215)
                {
                    Console.WriteLine("Enter n215 lenght of B");
                    bool succes215=int.TryParse(Console.ReadLine(), out n215);
                    if(succes215)
                    {
                        Console.WriteLine("Enter length of a215");
                        bool suces215=int.TryParse(Console.ReadLine(), out l215);
                        if(suces215)
                        {
                            double[] a215 = new double[n215 + l215];
                            double[] b215 = new double[n215];
                            for (int i = 0; i < l215; i++)
                            {
                                double el215;
                                Console.WriteLine($"Enter {i} element of A massive");
                                double.TryParse(Console.ReadLine(), out el215);
                                a215[i] = el215;
                            }
                            for (int i = 0; i < n215; i++)
                            {
                                double e215;
                                Console.WriteLine($"Enter {i} element of B massive");
                                double.TryParse(Console.ReadLine(), out e215);
                                b215[i] = e215;
                            }
                            for (int i = n215 - 1; i >= 0; i--)
                            {
                                double nd = b215[i];
                                double p215 = 0;
                                for (int j = n215 + l215 - 2; j >= k215; j--)
                                {
                                    a215[j + 1] = a215[j];
                                }
                                a215[k215 + 1] = nd;
                            }
                            foreach (int x in a215)
                                Console.Write("{0:} ", x);
                            Console.WriteLine();
                        }

                    }

                }

            }
            #endregion
            #region Task3.1
            {
                int l31;
                Console.WriteLine("Enter l31 of massive");
                bool success31=int.TryParse(Console.ReadLine(), out l31);
                if(success31)
                {
                    double[] a31 = new double[l31];
                    double[] n31 = new double[l31];
                    for (int i = 0; i < l31; i++)
                    {
                        double el31;
                        Console.WriteLine($"Enter {i} element");
                        double.TryParse(Console.ReadLine(), out el31);
                        a31[i] = el31;
                    }
                    double mx31 = a31[0];
                    int k31 = 0;
                    for (int i = 0; i < l31; i++)
                    {
                        if (a31[i] > mx31)
                        {
                            mx31 = a31[i];
                            k31 = 0;
                            n31[k31] = i;
                        }
                        else if (a31[i] == mx31)
                        {
                            k31 += 1;
                            n31[k31] = i;
                        }
                    }
                    for (int i = 0; i < k31; i++)
                        Console.Write("{0:} ", n31[i]);
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("Incorrect value");
            }
            #endregion
            #region Task3.5
            {
                int l35;
                Console.WriteLine("Enter l35");
                bool success35=int.TryParse(Console.ReadLine(),out l35);
                if (success35)
                {
                    double[] a35 = new double[l35];
                    for (int i = 0; i < l35; i++)
                    {
                        double el35;
                        Console.WriteLine($"Enter {i} element");
                        double.TryParse(Console.ReadLine(), out el35);
                        a35[i] = el35;
                    }
                    for (int i = 0; i < l35 - 1; i += 2)
                    {
                        double a35min = a35[i];
                        int i35min = i;
                        for(int j=i+2;j<l35;j+=2)
                        {
                            if (a35[j]<a35min)
                            {
                                a35min = a35[j];
                                i35min = j;
                            }
                        }
                        a35[i35min] = a35[i];
                        a35[i] = a35min;

                    }
                    foreach (double x in a35)
                        Console.Write("{0:} ", x);
                    Console.WriteLine();
                }
            }
            #endregion
            #region Task3.8
            {
                int l38;
                Console.WriteLine("Enter l38");
                bool success38=int.TryParse(Console.ReadLine(),out l38);
                if(success38)
                {
                    double[]a38=new double[l38];
                    double el38;
                    for(int i=0;i<l38;i++)
                    {
                        Console.WriteLine($"Enter {i} element");
                        double.TryParse(Console.ReadLine(), out el38);
                        a38[i]=el38;
                    }
                    for(int i=0;i<l38-1;i++)
                    {
                        if (a38[i]<0)
                        {
                            double amax38 = a38[i];
                            int imx38 = i;
                            for (int j = i+1; j < l38; j++)
                            {
                                if (a38[j] < 0)
                                {
                                    if (a38[j] > amax38)
                                    {
                                        amax38=a38[j];
                                        imx38 = j;
                                    }
                                }
                            }
                            a38[imx38] = a38[i];
                            a38[i] = amax38;
                        }
                    }
                    foreach (int x in a38)
                        Console.Write("{0:} ", x);
                    Console.WriteLine();
                }
            }
            #endregion
            #region Task3.9
            {
                int l39;
                int kv39 = 0, ans39 = 0;
                Console.WriteLine("Enter l39");
                bool success39 = int.TryParse(Console.ReadLine(), out l39);
                if (success39)
                {
                    double[] a39 = new double[l39];
                    for (int i = 0; i < l39; i++)
                    {
                        double el39;
                        Console.WriteLine($"Enter {i} element");
                        double.TryParse(Console.ReadLine(), out el39);
                        a39[i] = el39;
                    }
                    int k391 = 0;
                    int k39 = 0;
                    for (int i = 1; i < l39; i++)
                    {
                        if (a39[i - 1] < a39[i])
                        {
                            k391++;
                        }
                        else
                        {
                            k391 = 0;
                        }
                        kv39 = Math.Max(k391, kv39);
                        if (a39[i - 1] > a39[i])
                        {
                            k39++;
                        }
                        else
                        {
                            k39 = 0;
                        }
                        kv39 = Math.Max(k39, kv39);
                    }
                    ans39 = kv39;
                    Console.WriteLine($"Answer for 3.9 is {ans39}");
                }
                else
                    Console.WriteLine("Incorrect value");
            }
            #endregion
            #region Task3.12
            {
                int l312 = 12;
                double[] a312 = new double[l312];
                int[] b312 = new int[l312];
                int i312 = 0;
                int c312 = 0;
                for (int i = 0; i < l312; i++)
                {
                    double el312;
                    Console.WriteLine($"Enter {i} element");
                    double.TryParse(Console.ReadLine(), out el312);
                    a312[i] = el312;
                    if (el312 < 0)
                    {
                        b312[i312] = i;
                        i312++;
                    }
                }
                foreach (int x in b312)
                    Console.Write("{0:} ", x);
                Console.WriteLine();
                Console.WriteLine(i312);
                for (int i = 0; i < i312; i++)
                {
                    for (int j = b312[i] - c312; j < l312 - 1; j++)
                    {
                        a312[j] = a312[j + 1];
                    }
                    c312++;
                }
                for (int i = 0; i < l312 - i312; i++)
                    Console.Write("{0:} ", a312[i]);
                Console.WriteLine();
            }
            #endregion
            #region Task 3.13
            {
                int l313;
                int n313 = 0;
                double k313 = -100000;
                Console.WriteLine("Enter lenght of 3.13 massive");
                bool success313 = int.TryParse(Console.ReadLine(), out l313);
                if (success313)
                {
                    double[] a313 = new double[l313];
                    for (int i = 0; i < l313; i++)
                    {
                        double el313;
                        Console.WriteLine($"Enter {i} element");
                        double.TryParse(Console.ReadLine(), out el313);
                        a313[i] = el313;
                    }
                    Array.Sort(a313);
                    foreach (int x in a313)
                        Console.Write("{0:} ", x);
                    Console.WriteLine();
                    for (int i = 0; i < l313 - 1; i++)
                    {
                        if (a313[i] == a313[i + 1])
                        {
                            int z313 = 1;
                            while (i + z313 != l313)
                            {
                                if (a313[i] == a313[i + z313])
                                {
                                    a313[i + z313] = k313;
                                    z313 += 1;
                                }
                                else
                                    break;
                            }
                        }
                    }
                    Array.Sort(a313);
                    Array.Reverse(a313);
                    foreach (int x in a313)
                        Console.Write("{0:} ", x);
                    Console.WriteLine();
                    for (int k = 0; k < l313; k++)
                    {
                        if (a313[k] == k313)
                        {
                            n313 = k;
                            break;
                        }
                    }
                    if (n313 != 0)
                    {
                        for (int l = 0; l < n313; l++)
                            Console.Write("{0:} ", a313[l]);
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("No repeats");
                }
            }
            #endregion
            #region Task 1
            {
                int x1;
                Console.WriteLine("Enter el which I need to find");
                bool succes1 = int.TryParse(Console.ReadLine(), out x1);
                if (succes1)
                {
                    int l1;
                    Console.WriteLine("Enter lenght ");
                    bool success1 = int.TryParse(Console.ReadLine(), out l1);
                    if (success1)
                    {
                        int[] a1 = new int[l1];
                        for (int i = 0; i < l1; i++)
                        {
                            int el1;
                            Console.WriteLine($"Enter {i} element");
                            int.TryParse(Console.ReadLine(), out el1);
                            a1[i] = el1;
                        }
                        Array.Sort(a1);
                        int i1 = 0, i2 = l1 - 1;
                        int k = (i1 + i2) / 2;
                        while (a1[k] != x1)
                        {
                            if (x1 < a1[k]) i2 = k - 1;
                            else i1 = k + 1;
                            k = (i1 + i2) / 2;
                            if (i1 > i2) break;
                        }
                        if (i1 > i2) Console.WriteLine("Unlucky");
                        else Console.WriteLine("Lucky");
                    }
                }
            }
            #endregion
            #region Task 2
            {
                int l2;
                int k = 0, j = 0;
                Console.WriteLine("Enter lenght of A massive");
                bool success2 = int.TryParse(Console.ReadLine(), out l2);
                if (success2)
                {
                    int n2;
                    Console.WriteLine("Enter lenght of B massive");
                    bool succes2 = int.TryParse(Console.ReadLine(), out n2);
                    if (success2)
                    {
                        double[] a2 = new double[l2];
                        double[] b2 = new double[n2];
                        double[] c2 = new double[n2 + l2];
                        for (int i = 0; i < l2; i++)
                        {
                            double el2;
                            Console.WriteLine($"Enter {i} el of a massive");
                            double.TryParse(Console.ReadLine(), out el2);
                            a2[i] = el2;
                        }
                        foreach (double x in a2)
                            Console.Write("{0:} ", x);
                        Console.WriteLine();
                        for (int i = 0; i < n2; i++)
                        {
                            double en2;
                            Console.WriteLine($"Enter {i} el of b massive");
                            double.TryParse(Console.ReadLine(), out en2);
                            b2[i] = en2;
                        }
                        foreach (double x in b2)
                            Console.Write("{0:} ", x);
                        Console.WriteLine();
                        if (l2 > n2)
                        {
                            for (int i = 0; i < n2 * 2; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    c2[i] = a2[j];
                                    j++;
                                }
                                else if (i % 2 != 0)
                                {
                                    c2[i] = b2[k];
                                    k++;
                                }
                            }
                            for (int i = n2 * 2, j1 = n2; (i < n2 + l2 && j1 < l2); i++, j1++)
                            {
                                c2[i] = a2[j1];
                            }
                        }
                        else
                        {
                            for (int i = 0; i < l2 * 2; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    c2[i] = a2[j];
                                    j++;
                                }
                                else if (i % 2 != 0)
                                {
                                    c2[i] = b2[k];
                                    k++;
                                }
                            }
                            if (k + j < l2 + n2)
                            {
                                for (int i = l2 * 2, j1 = l2; (i <= n2 + l2 && j1 <= l2); i++, j1++)
                                {
                                    c2[i] = b2[j];
                                }
                            }
                        }
                        foreach (int x in c2)
                            Console.Write("{0:} ", x);
                        Console.WriteLine();
                    }
                }
            }
            #endregion
            #region Task 3
            {
                int k3 = 0, j3 = 0;
                int l3;
                Console.WriteLine("Enter lenght of massive a");
                bool success3 = int.TryParse(Console.ReadLine(), out l3);
                if (success3)
                {
                    int n3;
                    Console.WriteLine("Enter lenght of massive b");
                    bool succes3 = int.TryParse(Console.ReadLine(), out n3);
                    if (succes3)
                    {
                        double[] a3 = new double[l3];
                        double[] b3 = new double[n3];
                        double[] c3 = new double[n3 + l3];
                        for (int i = 0; i < l3; i++)
                        {
                            double el3;
                            Console.WriteLine($"Enter {i} for a");
                            double.TryParse(Console.ReadLine(), out el3);
                            a3[i] = el3;
                        }
                        for (int i = 0; i < n3; i++)
                        {
                            double el3;
                            Console.WriteLine($"Enter {i} for b");
                            double.TryParse(Console.ReadLine(), out el3);
                            b3[i] = el3;
                        }
                        Array.Sort(a3);
                        Array.Sort(b3);
                        Array.Reverse(a3);
                        Array.Reverse(b3);
                        foreach (int x in a3)
                            Console.Write("{0:} ", x);
                        Console.WriteLine();
                        foreach (int x in b3)
                            Console.Write("{0:} ", x);
                        Console.WriteLine();
                        for (int i = 0; i < l3 + n3; i++)
                        {
                            if (k3 < l3 && j3 < n3)
                            {
                                if (a3[k3] >= b3[j3])
                                {
                                    c3[i] = a3[k3];
                                    k3++;
                                }
                                else
                                {
                                    c3[i] = b3[j3];
                                    j3++;
                                }
                            }
                            else
                            {
                                if (k3 >= l3)
                                {
                                    c3[i] = b3[j3];
                                    j3++;
                                }
                                else if (j3 >= n3)
                                {
                                    c3[i] = a3[k3];
                                    k3++;
                                }
                            }
                        }
                        foreach (double x in c3)
                            Console.Write("{0:} ", x);
                        Console.WriteLine();
                    }
                }
            }
            #endregion
            #region Task 4
            {

                int n4;
                Console.WriteLine("Enter lenght of massive a");
                bool succes4 = int.TryParse(Console.ReadLine(), out n4);
                if (succes4)
                {
                    double[] a4 = new double[n4];
                    for (int i = 0; i < n4; i++)
                    {
                        double el4;
                        Console.WriteLine($"Enter {i} el");
                        double.TryParse(Console.ReadLine(), out el4);
                        a4[i] = el4;
                    }
                    foreach (double x in a4)
                        Console.Write("{0:} ", x);
                    Console.WriteLine("1st Massive");
                    for (int i = 0,j=n4-1; i < j ; i++,j--)
                    {
                        double p4 = a4[i];
                        a4[i] = a4[j];
                        a4[j] = p4;
                    }
                    foreach (double x in a4)
                        Console.Write("{0:} ", x);
                    Console.WriteLine("2nd Massive");
                }
            }
            #endregion
            #region Task 5
            {
                int n5, k5;
                Console.WriteLine("Enter lenght of massive n");
                bool success5 = int.TryParse(Console.ReadLine(), out n5);
                if (success5)
                {
                    double[] a5 = new double[n5];
                    int m5;
                    Console.WriteLine("Enter on how many possitions u'd like to move massive m");
                    bool sucess5 = int.TryParse(Console.ReadLine(), out m5);
                    double[] b5 = new double[m5];
                    if (sucess5)
                    {
                        for (int i = 0; i < n5; i++)
                        {
                            double el5;
                            Console.WriteLine($"Enter {i} el");
                            double.TryParse(Console.ReadLine(), out el5);
                            a5[i] = el5;
                        }
                        k5 = m5 - 1;
                        for (int i = n5 - 1; i > n5 - 1 - m5; i--)
                        {
                            b5[k5] = a5[i];
                            k5--;
                        }
                        foreach (int x in b5)
                            Console.Write("{0:} ", x);
                        Console.WriteLine();
                        int counter = 0;
                        for (int j = 0; j < m5; j++)
                        {
                            for (int i = n5 - m5 - 1 + counter; i >= counter; i--)
                            {
                                a5[i + 1] = a5[i];
                            }
                            counter++;
                        }
                        for (int i = 0, k = 0; i < m5 && k < m5; i++, k++)
                        {
                            a5[k] = b5[i];
                        }
                        foreach (int x in a5)
                            Console.Write("{0:} ", x);
                        Console.WriteLine();
                    }
                }
            }
            #endregion
        }
    }
}
