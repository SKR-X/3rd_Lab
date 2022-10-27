using System;
using System.Net;
using System.Security.Cryptography;
using System.Xml;

class homew4lvl1
{
    static void Main()
    {

        Console.WriteLine("введите номер задания (6, 10, 11, 12, 13)");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb == 6)
        {
            #region Level1 Task6
            Console.WriteLine("пожалуйста! введите координаты вектора через пробел:");
            double[] ma1 = new double[5];
            double res1 = 0.0;
            string[] temp1 = (Console.ReadLine()).Split(' ');
            bool u = true;
            for (int i = 0; i < 5; i++)
            {
                u = double.TryParse(temp1[i], out double xx);
                if (u == true)
                {
                    ma1[i] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            
            }
            if (u == true)
            {
                ma1[i] = double.Parse(temp1[i]);
                for (int i1 = 0; i1 < 5; i1++) res1 += Math.Pow(ma1[i1], 2);
                //без цикла double res1 = Math.Pow(ma1[0] * ma1[0] + ma1[1] * ma1[1] + ma1[2] * ma1[2] + ma1[3] * ma1[3] + ma1[4] * ma1[4],0.5);
                Console.WriteLine($"длина вектора -> {Math.Pow(res1, 0.5)}");
                //for (int i = 0; i < 5; i++) Console.Write(" ", ma1[i]);
            }
            #endregion
        }
        else if (numb == 10)
        {
            #region Level1 Task10
            double[] ma2 = new double[10];
            Console.WriteLine("Пожалуйста! введите массив размером 10");
            string[] temp2 = (Console.ReadLine()).Split(' ');
            bool h = true;
            for (int i2 = 0; i2 < 10; i2++)
            {
                h = double.TryParse(temp2[i2], out double xx);
                if (h == true)
                {
                    ma2[i2] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (h == true)
            {
                Console.WriteLine("введите число P");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите число Q");
                double q = Convert.ToDouble(Console.ReadLine());
                if (p < q)
                {
                    //int i3 = 0;
                    int count = 0;
                    //bool start = false;
                    //задание сформулировано странно: можно подумать, что вводятся элементы массива, между которыми необходимо найти количество элементов
                    //тогда алгоритм должен быть таким:
                    //while (ma2[i3] != q)
                    //{
                      //  if (ma2[i3] == p) { start = true; }

                        //if ((start == true) && (ma2[i3] != p)) count += 1;
                        //i3++;
                    //}
                    // но с другой стороны p и q может быть промежутком (p;q)
                    //тогда алгоритм такой:
                    for (int i = 0; i < 10; i++)
                    {
                        if ((ma2[i] > p) && (ma2[i] < q)) count++;
                    }
                    Console.WriteLine($"количество элементов -> {count}");
                }
                else Console.WriteLine("p<q");
                
            }
            #endregion
        }
        else if (numb == 11)
        {
            #region Level1 Task11
            Console.WriteLine("введите массив размером 10");
            double[] ma11 = new double[10];
            
            int ix = 0;
            string[] temp11 = (Console.ReadLine()).Split(' ');
            bool j = true;
            int c = 0;
            for (int i11 = 0; i11 < 10; i11++)
            {
                j = double.TryParse(temp11[i11], out double xx);
                if (j == true)
                {
                    ma11[i11] = xx;
                    if (xx>0) c++;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (j == true)
            {
                double[] newma = new double[c];
                for (int i112 = 0; i112 < 10; i112++)
                {
                    if (ma11[i112] > 0)
                    {
                        newma[ix] = ma11[i112];
                        ix++;
                    }
                }
                for (int ixx = 0; ixx < ix; ixx++) Console.WriteLine(newma[ixx]);
            }
            #endregion
        }
        else if (numb == 12)
        {
            #region Level 1 Task12
            Console.WriteLine("введите массив с размером 8");
            double[] ma12 = new double[8];
            int findi = -1;
            string[] temp3 = ((Console.ReadLine()).Split(" "));
            bool g = true;
            for (int im = 0; im < 8; im++)
            {
                g = double.TryParse(temp3[im], out double xx);
                if (g == true)
                {
                    ma12[im] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (g == true)
            {
                for (int iend = 7; iend != 0; iend--)
                {
                    if (ma12[iend] < 0)
                    {
                        findi = iend;
                        break;
                    }
                }
                Console.WriteLine($"value -> {ma12[findi]} , number -> {findi + 1}");
            }
            #endregion
        }
        else if (numb == 13)
        {
            #region Level1 Task 13
            int index1 = 0;
            int index2 = 0;
            double[] ma13 = new double[10];
            Console.WriteLine("Пожалуйста! введите массив размером 10");
            string[] temp4 = (Console.ReadLine()).Split(' ');
            bool m = true;
            for (int i22 = 0; i22 < 10; i22++)
            {
                m = double.TryParse(temp4[i22], out double xx);
                if (m == true)
                {
                    ma13[i22] = xx;
                }
                else
                {
                    Console.WriteLine("введите заново");
                    break;
                }
            }
            if (m == true)
            {
                double[] manew1 = new double[5];
                double[] manew2 = new double[5];
                for (int iz = 0; iz < 10; iz++)
                {
                    if (iz % 2 == 0)
                    {
                        manew1[index1] = ma13[iz];
                        index1 += 1;
                    }
                    else
                    {
                        manew2[index2] = ma13[iz];
                        index2 += 1;
                    }
                }
                Console.WriteLine("массив с четными индексами элементов, считая от 0:");
                for (int ixx1 = 0; ixx1 < 5; ixx1++) Console.WriteLine(manew1[ixx1]);

                Console.WriteLine("массив с нечетными индексами элементов, считая от 0:");
                for (int ixx2 = 0; ixx2 < 5; ixx2++) Console.WriteLine(manew2[ixx2]);
            }
            #endregion
        }
        else Console.WriteLine("выберите еще раз");
    }
}
