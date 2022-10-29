class Homew4
{
    
    static void Main()
    {
        
        Console.WriteLine("введите номер задания (1,5,8,9,12,13)");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb == 1)
        {
            Console.WriteLine("введите массив!");
            string[] temp1 = Console.ReadLine().Split(" ");
            int l1 = temp1.Length;
            double[] ma1 = new double[l1];
            double max1 = -1000000;
            bool e = true;
            for (int i1 = 0; i1 < l1; i1++)
            {
                e = double.TryParse(temp1[i1], out double xx);
                if (e == true)
                {
                    ma1[i1] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                        }
            }
            if (e == true)
            {
                double[] masx1 = new double[l1];
                int c1 = 0;
                for (int im1 = 0; im1 < l1; im1++)
                {
                    if (ma1[im1] > max1)
                    {
                        max1 = ma1[im1];
                        //Console.WriteLine($" max - > {max1}, ind-> {im1}");
                        c1 = 0;
                        masx1[c1] = im1;
                    }
                    else if (ma1[im1] == max1)
                    {
                        c1 += 1;
                        masx1[c1] = im1;

                    }
                }
                for (int imi1 = 0; imi1 < (c1 + 1); imi1++)
                    Console.WriteLine(masx1[imi1]);
            }
        }
        else if (numb == 5)
        {
            int partition<T>(T[] m, int a, int b) where T : IComparable<T>
            {
                int i = a;
                for (int j = a; j <= b; j++)       
                {
                    if (m[j].CompareTo(m[b]) <= 0)
                    {
                        T t = m[i];m[i] = m[j];m[j] = t;
                        i++;
                    }
                }
                return i - 1;                        
            }

            void quicksort<T>(T[] m, int a, int b) where T : IComparable<T>
            {                                        
                if (a >= b) return;
                int c = partition(m, a, b);
                quicksort(m, a, c - 1);
                quicksort(m, c + 1, b);
            }
            Console.WriteLine("введите массив!");
            string[] temp5 = Console.ReadLine().Split(" ");
            int l5 = temp5.Length;
            double[] ma5 = new double[l5];
            double[] chet5 = new double[l5];
            bool u = true;
            int c1 = 0;
            for (int i5 = 0; i5 < l5; i5++)
            {


                u = double.TryParse(temp5[i5], out double xx);
                if (u == true)
                {
                    ma5[i5] = xx;
                    if (i5 % 2 == 0)
                    {
                        chet5[c1] = ma5[i5];
                        //Console.WriteLine($"{chet5[c1]} + {ma5[i5]}");

                        c1++;
                    }
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            }
            //for (int ixxc5 = 0; ixxc5 < c1; ixxc5++) Console.WriteLine(chet5[ixxc5]);
            //Console.WriteLine('-');

            quicksort<double>(chet5, 0, c1 - 1);            
            
            //for (int ixx5 = 0; ixx5 < c1; ixx5++) Console.WriteLine(chet5[ixx5]);

            int c = 0;
            for (int ix51 = 0; ix51 < l5; ix51+=2)
            {
                ma5[ix51] = chet5[c];
                c++;
            }
            for (int ix5 = 0; ix5 < l5; ix5++) Console.WriteLine(ma5[ix5]);


        }
        else if (numb == 8)
        {
            Console.WriteLine("введите массив!");
            string[] temp8 = Console.ReadLine().Split(" ");
            int l8 = temp8.Length;
            double[] ma8 = new double[l8];
            List<double> den = new List<double>();
            List<int> ind = new List<int>();
            bool s = true;
            for (int i8 = 0; i8 < l8; i8++)
            {
                s = double.TryParse(temp8[i8], out double xx);
                if (s == true)
                {
                    ma8[i8] = xx;
                    if (ma8[i8] < 0)

                    {
                        den.Add(ma8[i8]);
                        ind.Add(i8);
                    }
                }
                else
                {

                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (s == true)
            {
                if (!ind.Any())
                {
                    for (int p8 = 0; p8 < l8; p8++) Console.WriteLine(ma8[p8]);
                }
                else
                {
                    den.Sort();
                    int c8 = 0;

                    //Console.WriteLine(
                    int lind = den.Count;
                    //Console.WriteLine(ind[0]);
                    //for (int o8 = 0; o8 < lind; o8++) Console.WriteLine(den[o8]);
                    int endind = ind[lind - 1];
                    //Console.WriteLine(endind);

                    for (int j8 = 0; j8 < l8; j8++)
                    {
                        // Console.WriteLine($" {j8} -> {ind[c8]}");
                        if ((j8 == ind[c8]) && (j8 < (endind + 1)))
                        {
                            ma8[j8] = den[c8]; //меняем элемент массива
                            c8++;
                            //Console.WriteLine("1");
                        }
                    }
                    for (int z8 = 0; z8 < l8; z8++) Console.WriteLine(ma8[z8]);

                }
            }
        }

        else if (numb == 9)
        {
           Console.WriteLine("введите массив!");
            string[] tempx = Console.ReadLine().Split(" ");
            int lx = tempx.Length;
            double[] maxx = new double[lx];
            List<double> denx = new List<double>();
            List<int> indx = new List<int>();
            bool h = true;
            for (int i8x = 0; i8x < lx; i8x++)
            {
                h = double.TryParse(tempx[i8x], out double xx);
                if (h == true)
                {
                    maxx[i8x] = xx;
                    
                }
                else
                {

                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (h == true)
            {
                if (!indx.Any())
                {
                    double t = maxx[0];
                    int c1 = 1;
                    int c2 = 0;
                    int cmax = 1;
                    for (int i8x = 1; i8x < lx; i8x++)
                    {
                        double r = maxx[i8x];
                        if (r > t)
                        {
                            c2 = 1;
                            c1++;
                        }
                       else if (r < t)
                        {
                            //Console.WriteLine(c1);
                            c1 = 0;
                            c2++;
                        }
                        else if (r == t) { }
                        t = maxx[i8x];

                        if (c1 > cmax) cmax = c1;
                        if (c2 > cmax) cmax = c2;
                    }
                    if (cmax != 0) Console.WriteLine(cmax + 1);
                    else Console.WriteLine(cmax);
                }
                else
                {
                    Console.WriteLine('-');
                
                }
            }
        }
        else if (numb == 12)
        {
            double[] ma2 = new double[12];
            Console.WriteLine("введите массив(12 элементов)! через enter");
            bool w = true;
            for (int i2 = 0; i2 < 12; i2++)
            {
                w = double.TryParse(Console.ReadLine(), out double xx);
                if (w == true)
                {
                    ma2[i2]=xx;
                }
                else {

                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (w == true)
            {
                int n = 12;
                for (int i = n - 1; i >= 0; i--)
                {
                    if (ma2[i] < 0)
                    {
                        n--;
                        for (int j = i; j < n; j++) ma2[j] = ma2[j + 1];// сдвигаем элементы правее i влево
                    }
                }
                Console.WriteLine("-");
                for (int z2 = 0; z2 < n; z2++) Console.WriteLine(ma2[z2]);
            }
        }
        else if (numb == 13)
        {
            string[] temp3 = Console.ReadLine().Split(" ");
            int l3 = temp3.Length;
            double[] ma3 = new double[l3];
            bool p = true;
            for (int i3 = 0; i3 < l3; i3++)
            {
                p = double.TryParse(temp3[i3], out double xx);
                if (p == true)
                {
                    ma3[i3] = xx;
                }
                else
                {

                    Console.WriteLine("введите заново");
                    break;
                }

            }
            if (p == true)
            {
                for (int i3 = l3 - 1; i3 >= 0; i3--)
                {
                    int c3 = 0;
                    double xe = ma3[i3];
                    for (int j3 = 0; j3 < l3; j3++)
                    {
                        //Console.WriteLine($"{j3} - {i3}");
                        if ((ma3[i3] == ma3[j3]))
                            c3++;
                    }
                    if (c3 > 1)
                    {

                        for (int k3 = l3 - 1; k3 >= 0; k3--)
                        {
                            //Console.WriteLine($"m3[k3]-> {ma3[k3]},   m3[i3] -> {ma3[i3]}, k3 -> {k3}, l3-> {l3}, c3 -> {c3} ");
                            if (xe == ma3[k3])
                            {
                                l3--;
                                for (int je3 = k3; je3 < l3; je3++) ma3[je3] = ma3[je3 + 1];// сдвигаем элементы правее i влево
                            }
                        }
                    }
                    //for (int t3 = 0; t3 < l3; t3++) Console.WriteLine(ma3[t3]);



                }
                Console.WriteLine("-");
                for (int z3 = 0; z3 < l3; z3++) Console.WriteLine(ma3[z3]);
            }

        }
    }
}
