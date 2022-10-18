using System;

namespace _3rd_Lab
{
    class Programm
    {
        static void Main(string[] args)
        {
            #region 3.1.6

            double[] a = new double[] { 1, 2, 3, 4, 5 };
            int i;
            double L, S = 0;
            Console.WriteLine("array: ");
            for (i = 0; i < 5; i++)
            {
                S = S + a[i] * a[i];
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            L = Math.Sqrt(S);
            Console.WriteLine($"L={L}");

            #endregion

            #region 3.1.10

            double[] ar = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = 0;
            double P, Q;
            Console.WriteLine("enter P");
            double.TryParse(Console.ReadLine(), out P);
            Console.WriteLine("enter Q");
            double.TryParse(Console.ReadLine(), out Q);
            while (P >= Q)
            {
                Console.WriteLine("P < Q");
                Console.WriteLine("enter Q");
                double.TryParse(Console.ReadLine(), out Q);
            }
            foreach (double x in ar)
            {
                if (x > P && x < Q)
                {
                    n++;
                }
            }
            Console.WriteLine($"between P and Q - {n}");

            #endregion

            #region 3.1.11

            double[] arr = new double[] { -1, -2, 0, 3, 4, 5, 6, 7, 8, 9 };
            double[] brr = new double[10];
            int i_q, m = 0;
            Console.WriteLine("array 1: ");
            foreach (double x_q in arr)
            {
                Console.Write($"{x_q} ");
                if (x_q > 0)
                {
                    brr[m] = x_q;
                    m++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("array 2: ");
            for (i_q = 0; i_q < m; i_q++)
            {
                Console.Write($"{brr[i_q]} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.1.12

            double[] arra = new double[8] { -1, -2, -3, 4, 5, 6, 7, 8 };
            int i_w;
            double k = 0;
            Console.WriteLine("array: ");
            for (i_w = 0; i_w < 8; i_w++)
            {
                Console.Write($"{arra[i_w]} ");
                if (arra[i_w] < 0)
                {
                    k = arra[i_w];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"the last negative: {k}");

            #endregion

            #region 3.1.13

            double[] array = new double[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] array1 = new double[5];
            double[] array2 = new double[5];
            int l, v = 0;
            Console.WriteLine("array: ");
            for (l = 0; l < 10; l = l + 1)
            {
                Console.Write($"{array[l]} ");
            }
            for (l = 0; l < 9; l = l + 2)
            {
                array1[v] = array[l];
                array2[v] = array[l + 1];
                v++;
            }
            Console.WriteLine();
            Console.WriteLine("array1: ");
            foreach (double g1 in array1)
            {
                Console.Write($"{g1} ");
            }
            Console.WriteLine();
            Console.WriteLine("array2: ");
            foreach (double g2 in array2)
            {
                Console.Write($"{g2} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.2.5

            int n_e, i_e = 0, imin_e = 0, imax_e = 0, m_e, k_e = 0, A_e=0, B_e=0;
            double max_e, min_e;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_e);
            while (n_e <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_e);
            }
            double[] a_e = new double[n_e];
            Console.WriteLine($"enter {n_e} elements");
            for (i_e = 0; i_e < n_e; i_e++)
            {
                double.TryParse(Console.ReadLine(), out a_e[i_e]);
            }
            double[] b_e = new double[n_e];
            Console.WriteLine("array1: ");
            min_e = a_e[0];
            max_e = a_e[0];
            for (i_e = 0; i_e < n_e; i_e++)
            {
                Console.Write($"{a_e[i_e]} ");
                if (a_e[i_e] < min_e)
                {
                    min_e = a_e[i_e];
                    imin_e = i_e;
                }
                if (a_e[i_e] > max_e)
                {
                    max_e = a_e[i_e];
                    imax_e = i_e;
                }
            }
            Console.WriteLine();
            if (imax_e < imin_e)
            {
                A_e = imax_e;
                B_e = imin_e;
            }
            else if (imax_e > imin_e)
            {
                B_e = imax_e;
                A_e = imin_e;
            }
            for (m_e = A_e+1; m_e < B_e; m_e++)
            {
                if (a_e[m_e] < 0)
                {
                    b_e[k_e] = a_e[m_e];
                    k_e++;
                }
            }
            Console.WriteLine("array2: ");
            for (int ii = 0; ii < k_e; ii++)
            {
                Console.Write($"{b_e[ii]} ");
            }

            #endregion

            #region 3.2.6

            int n_r, i_r = 0, m_r = 0;
            double s_r = 0, sr_r, q_r;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_r);
            while (n_r <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_r);
            }
            double[] a_r = new double[n_r + 1];
            Console.WriteLine($"enter {n_r} elements");
            for (i_r = 0; i_r < n_r; i_r++)
            {
                double.TryParse(Console.ReadLine(), out a_r[i_r]);
            }
            double P_r;
            Console.WriteLine("enter P");
            double.TryParse(Console.ReadLine(), out P_r);
            Console.WriteLine("array: ");
            for (i_r = 0; i_r < n_r; i_r++)
            {
                Console.Write($"{a_r[i_r]} ");
                s_r = s_r + a_r[i_r];
            }
            sr_r = s_r / n_r;
            q_r = Math.Abs(a_r[0] - sr_r);
            for (i_r = 0; i_r < n_r; i_r++)
            {
                if (Math.Abs(a_r[i_r] - sr_r) < q_r)
                {
                    q_r = Math.Abs(a_r[i_r] - sr_r);
                    m_r = i_r;
                }
            }
            for (i_r = n_r - 1; i_r >= m_r + 1; i_r--)
            {
                a_r[i_r + 1] = a_r[i_r];
            }
            a_r[m_r + 1] = P_r;
            Console.WriteLine();
            Console.WriteLine("array with P: ");
            for (i_r = 0; i_r < n_r + 1; i_r++)
            {
                Console.Write($"{a_r[i_r]} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.2.9

            int n_t, i_t = 0, imin_t = 0, imax_t = 0, A_t = 0, B_t = 0;
            double s_t = 0, sr_t, min_t, max_t;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_t);
            while (n_t <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_t);
            }
            double[] a_t = new double[n_t];
            Console.WriteLine($"enter {n_t} elements");
            for (i_t = 0; i_t < n_t; i_t++)
            {
                double.TryParse(Console.ReadLine(), out a_t[i_t]);
            }
            min_t = a_t[0];
            max_t = a_t[0];
            Console.WriteLine("array: ");
            for (i_t = 0; i_t < n_t; i_t++)
            {
                Console.Write($"{a_t[i_t]} ");
                if (a_t[i_t] < min_t)
                {
                    min_t = a_t[i_t];
                    imin_t = i_t;
                }
                if (a_t[i_t] > max_t)
                {
                    max_t = a_t[i_t];
                    imax_t = i_t;
                }
            }
            if (imax_t < imin_t)
            {
                A_t = imax_t;
                B_t = imin_t;
            }
            else if (imax_t > imin_t)
            {
                B_t = imax_t;
                A_t = imin_t;
            }
            for (i_t = A_t + 1; i_t < B_t; i_t++)
            {
                s_t = s_t + a_t[i_t];
            }
            sr_t = s_t / (Math.Abs(imax_t - imin_t) - 1);
            Console.WriteLine();
            Console.WriteLine($"average between max and min - {sr_t}");

            #endregion

            #region 3.2.10

            int n_y, i_y = 0;
            double min_y = 0;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_y);
            while (n_y <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_y);
            }
            int imin_y = n_y - 1;
            double[] a_y = new double[n_y];
            Console.WriteLine($"enter {n_y} elements");
            for (i_y = 0; i_y < n_y; i_y++)
            {
                double.TryParse(Console.ReadLine(), out a_y[i_y]);
                if (a_y[i_y] > 0)
                {
                    min_y = a_y[i_y];
                    imin_y = i_y;
                }
            }
            Console.WriteLine("array: ");
            for (i_y = 0; i_y < n_y; i_y++)
            {
                Console.Write($"{a_y[i_y]} ");
                if (a_y[i_y] < min_y && a_y[i_y] > 0)
                {
                    min_y = a_y[i_y];
                    imin_y = i_y;
                }
            }
            Console.WriteLine();
            if (a_y[imin_y] > 0)
            {
                for (i_y = imin_y + 1; i_y < n_y; i_y++)
                {
                    a_y[i_y - 1] = a_y[i_y];
                }
                Console.WriteLine("new array: ");
                for (i_y = 0; i_y < n_y - 1; i_y++)
                {
                    Console.Write($"{a_y[i_y]} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("no positive elements");
            }

            #endregion

            #region 3.2.11

            int n_u, i_u = 0;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_u);
            while (n_u <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_u);
            }
            double[] a_u = new double[n_u + 1];
            Console.WriteLine($"enter {n_u} elements");
            for (i_u = 0; i_u < n_u; i_u++)
            {
                double.TryParse(Console.ReadLine(), out a_u[i_u]);
            }
            int ipos = n_u;
            double P_u;
            Console.WriteLine("enter P");
            double.TryParse(Console.ReadLine(), out P_u);
            Console.WriteLine("array: ");
            for (i_u = 0; i_u < n_u; i_u++)
            {
                Console.Write($"{a_u[i_u]} ");
                if (a_u[i_u] > 0)
                {
                    ipos = i_u;
                }
            }
            Console.WriteLine();
            if (a_u[ipos] > 0)
            {
                for (i_u = n_u - 1; i_u >= ipos + 1; i_u--)
                {
                    a_u[i_u + 1] = a_u[i_u];
                }
                a_u[ipos + 1] = P_u;
                Console.WriteLine("array with P: ");
                for (i_u = 0; i_u < n_u + 1; i_u++)
                {
                    Console.Write($"{a_u[i_u]} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("no positive elements");
            }

            #endregion

            #region 3.2.13

            int n_i, i_i = 0, imax_i = 0;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_i);
            while (n_i <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_i);
            }
            double[] a_i = new double[n_i];
            Console.WriteLine($"enter {n_i} elements");
            for (i_i = 0; i_i < n_i; i_i++)
            {
                double.TryParse(Console.ReadLine(), out a_i[i_i]);
            }
            double max_i = a_i[0];
            Console.WriteLine("array: ");
            for (i_i = 0; i_i < n_i; i_i++)
            {
                Console.Write($"{a_i[i_i]} ");
            }
            Console.WriteLine();
            for (i_i = 0; i_i < n_i; i_i = i_i + 2)
            {
                if (max_i < a_i[i_i])
                {
                    max_i = a_i[i_i];
                    imax_i = i_i;
                }
            }
            a_i[imax_i] = imax_i;
            Console.WriteLine("new array: ");
            for (i_i = 0; i_i < n_i; i_i++)
            {
                Console.Write($"{a_i[i_i]} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.2.15

            int n_o, m_o, i_o = 0, c_o = 0, k_o;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_o);
            while (n_o <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_o);
            }
            Console.WriteLine("enter m");
            int.TryParse(Console.ReadLine(), out m_o);
            while (m_o <= 0)
            {
                Console.WriteLine("m > 0! try another m");
                int.TryParse(Console.ReadLine(), out m_o);
            }
            double[] A = new double[n_o];
            double[] B = new double[m_o];
            Console.WriteLine($"enter {n_o} elements for array A");
            for (i_o = 0; i_o < n_o; i_o++)
            {
                double.TryParse(Console.ReadLine(), out A[i_o]);
            }
            Console.WriteLine($"enter {m_o} elements for array B");
            for (i_o = 0; i_o < m_o; i_o++)
            {
                double.TryParse(Console.ReadLine(), out B[i_o]);
            }
            Console.WriteLine("array A: ");
            for (i_o = 0; i_o < n_o; i_o++)
            {
                Console.Write($"{A[i_o]} ");
            }
            Console.WriteLine();
            Console.WriteLine("array B: ");
            for (i_o = 0; i_o < m_o; i_o++)
            {
                Console.Write($"{B[i_o]} ");
            }
            Console.WriteLine();
            Console.WriteLine("enter possible k");
            int.TryParse(Console.ReadLine(), out k_o);
            while (k_o > n_o || k_o < 0)
            {
                Console.WriteLine("k must be positive and k <= n! try another k");
                int.TryParse(Console.ReadLine(), out k_o);
            }
            double[] C = new double[m_o + n_o];
            Console.WriteLine("new array: ");
            for (i_o = 0; i_o < k_o; i_o++)
            {
                C[c_o] = A[i_o];
                Console.Write($"{C[c_o]} ");
                c_o++;
            }
            for (i_o = 0; i_o < m_o; i_o++)
            {
                C[c_o] = B[i_o];
                Console.Write($"{C[c_o]} ");
                c_o++;
            }
            for (i_o = k_o; i_o < n_o; i_o++)
            {
                C[c_o] = A[i_o];
                Console.Write($"{C[c_o]} ");
                c_o++;
            }
            Console.WriteLine();

            #endregion

            #region 3.3.1

            int n_p, i_p = 0, k_p = -1;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_p);
            while (n_p <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_p);
            }
            double[] a_p = new double[n_p];
            double[] b_p = new double[n_p];
            Console.WriteLine($"enter {n_p} elements");
            for (i_p = 0; i_p < n_p; i_p++)
            {
                double.TryParse(Console.ReadLine(), out a_p[i_p]);
            }
            double max_p = a_p[0];
            Console.WriteLine("array: ");
            for (i_p = 0; i_p < n_p; i_p++)
            {
                Console.Write($"{a_p[i_p]} ");
                if (a_p[i_p] > max_p)
                {
                    max_p = a_p[i_p];
                    b_p[0] = i_p;
                    k_p = 0;
                }
                else if (a_p[i_p] == max_p)
                {
                    k_p++;
                    b_p[k_p] = i_p;
                }
            }
            Console.WriteLine();
            Console.WriteLine("new array: ");
            for (i_p = 0; i_p <= k_p; i_p++)
            {
                Console.Write($"{b_p[i_p]} ");
            }

            Console.WriteLine();

            #endregion

            #region 3.3.5

            int n_l, i_l = 0, imin_l;
            double min_l;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_l);
            while (n_l <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_l);
            }
            double[] a_l = new double[n_l];
            Console.WriteLine($"enter {n_l} elements");
            for (i_l = 0; i_l < n_l; i_l++)
            {
                double.TryParse(Console.ReadLine(), out a_l[i_l]);
            }
            Console.WriteLine("array: ");
            for (i_l = 0; i_l < n_l; i_l++)
            {
                Console.Write($"{a_l[i_l]} ");
            }
            Console.WriteLine();
            for (i_l = 0; i_l < n_l - 1; i_l = i_l + 2)
            {
                min_l = a_l[i_l];
                imin_l = i_l;
                for (int j_l = i_l + 2; j_l < n_l; j_l = j_l + 2)
                {
                    if (a_l[j_l] < min_l)
                    {
                        min_l = a_l[j_l];
                        imin_l = j_l;
                    }
                }
                a_l[imin_l] = a_l[i_l];
                a_l[i_l] = min_l;
            }
            Console.WriteLine("new array: ");
            for (i_l = 0; i_l < n_l; i_l++)
            {
                Console.Write($"{a_l[i_l]} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.3.8 

            int n_k, i_k = 0, imax_k;
            double max_k;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_k);
            while (n_k <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_k);
            }
            double[] a_k = new double[n_k];
            Console.WriteLine($"enter {n_k} elements");
            for (i_k = 0; i_k < n_k; i_k++)
            {
                double.TryParse(Console.ReadLine(), out a_k[i_k]);
            }
            Console.WriteLine("array: ");
            for (i_k = 0; i_k < n_k; i_k++)
            {
                Console.Write($"{a_k[i_k]} ");
            }
            Console.WriteLine();
            for (i_k = 0; i_k < n_k - 1; i_k++)
            {
                if (a_k[i_k] < 0)
                {
                    max_k = a_k[i_k];
                    imax_k = i_k;
                    for (int j_k = i_k + 1; j_k < n_k; j_k++)
                    {
                        if (a_k[j_k] > max_k && a_k[j_k] < 0)
                        {
                            max_k = a_k[j_k];
                            imax_k = j_k;
                        }
                    }

                    a_k[imax_k] = a_k[i_k];
                    a_k[i_k] = max_k;
                }
            }
            Console.WriteLine("new array: ");
            for (i_k = 0; i_k < n_k; i_k++)
            {
                Console.Write($"{a_k[i_k]} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.3.9

            int n_j, i_j = 0, k_j = 0, maxk = 0, l_j = 0, maxl = 0;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_j);
            while (n_j <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_j);
            }
            double[] a_j = new double[n_j];
            Console.WriteLine($"enter {n_j} elements");
            for (i_j = 0; i_j < n_j; i_j++)
            {
                double.TryParse(Console.ReadLine(), out a_j[i_j]);
            }
            Console.WriteLine("array: ");
            for (i_j = 0; i_j < n_j; i_j++)
            {
                Console.Write($"{a_j[i_j]} ");
            }
            Console.WriteLine();
            for (i_j = 0; i_j < n_j - 1; i_j++)
            {
                if (a_j[i_j] < a_j[i_j + 1])
                {
                    k_j++;
                    l_j = 0;
                    if (k_j > maxk)
                    {
                        maxk = k_j;
                    }
                }
                else if (a_j[i_j] > a_j[i_j + 1])
                {
                    l_j++;
                    k_j = 0;
                    if (l_j > maxl)
                    {
                        maxl = l_j;
                    }
                }
                else
                {
                    k_j = 0;
                    l_j = 0;
                }

            }
            if (maxk > maxl)
            {
                Console.WriteLine($"max sequence length - {maxk + 1}");
            }
            else
            {
                Console.WriteLine($"max sequence length - {maxl + 1}");
            }

            #endregion


            #region 3.3.12

            const int n_m = 12;
            int i_m = 0, len_m = 0;
            double[] a_m = new double[n_m + 1];
            Console.WriteLine($"enter {n_m} elements");
            for (i_m = 0; i_m < n_m; i_m++)
            {
                double.TryParse(Console.ReadLine(), out a_m[i_m]);
            }
            Console.WriteLine("array: ");
            for (i_m = 0; i_m < n_m; i_m++)
            {
                Console.Write($"{a_m[i_m]} ");
                if (a_m[i_m] >= 0)
                {
                    len_m++;
                }
            }
            Console.WriteLine();
            i_m = 0;
            int q_m = 0;
            while (q_m <len_m)
            {
                if (a_m[i_m] >= 0)
                {
                    a_m[q_m] = a_m[i_m];
                    q_m++;
                }
                i_m++;
            }
            Console.WriteLine("new array: ");
            for (i_m = 0; i_m < len_m; i_m++)
            {
                Console.Write($"{a_m[i_m]} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.3.13

            int n_n, i_n = 0, iii = 0, ii_n = 0, g_n = 0;
            Console.WriteLine("enter n");
            int.TryParse(Console.ReadLine(), out n_n);
            while (n_n <= 0)
            {
                Console.WriteLine("n > 0! try another n");
                int.TryParse(Console.ReadLine(), out n_n);
            }
            double[] a_n = new double[n_n + 1];
            double[] b_n = new double[n_n + 1];
            Console.WriteLine($"enter {n_n} elements");
            for (i_n = 0; i_n < n_n; i_n++)
            {
                double.TryParse(Console.ReadLine(), out a_n[i_n]);
            }
            int m_n = n_n;
            Console.WriteLine("array: ");
            for (i_n = 0; i_n < n_n; i_n++)
            {
                Console.Write($"{a_n[i_n]} ");
            }
            Console.WriteLine();
            for (i_n = 0; i_n < n_n; i_n++)
            {
                for (int j_n = i_n + 1; j_n < n_n + 1; j_n++)
                {

                    if (a_n[j_n] == a_n[i_n])
                    {
                        iii++;
                    }
                }
                if (iii > 0)
                {
                    b_n[ii_n] = a_n[i_n];
                    ii_n++;

                }
                iii = 0;
            }
            i_n = 0;
            while (i_n < n_n)
            {
                for (int c_n = 0; c_n < ii_n; c_n++)
                {
                    if (a_n[i_n] == b_n[c_n])
                    {
                        g_n++;
                        for (int j_n = i_n; j_n < n_n; j_n++)
                        {
                            a_n[j_n] = a_n[j_n + 1];
                        }
                        break;

                    }
                }
                if (g_n > 0)
                {
                    g_n = 0;
                    m_n--;
                }
                else
                {
                    i_n++;
                }

            }
            Console.WriteLine("new array: ");
            for (i_n = 0; i_n < m_n; i_n++)
            {
                Console.Write($"{a_n[i_n]} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.4.11

            const int n_b = 5;
            int i_b = 0;
            double[] a_b = new double[n_b] { 1, 2, 3, 4, 5 };
            double x_b;
            Console.WriteLine("enter x");
            double.TryParse(Console.ReadLine(), out x_b);
            Console.WriteLine("array: ");
            for (i_b = 0; i_b < n_b; i_b++)
            {
                Console.Write($"{a_b[i_b]} ");
            }
            Console.WriteLine();
            int i_b1 = 0, i_b2 = n_b - 1;
            i_b = (i_b1 + i_b2) / 2;
            while (i_b2 >= i_b1)
            {
                if (x_b == a_b[i_b])
                {
                    Console.WriteLine("yes");
                    break;
                }
                else if (x_b < a_b[i_b])
                {
                    i_b2 = i_b - 1;
                }
                else
                {
                    i_b1 = i_b + 1;
                }
                i_b = (i_b1 + i_b2) / 2;
            }
            if (i_b2 < i_b1)
            {
                Console.WriteLine("no");
            }

            #endregion

            #region 3.4.12

            const int n_v = 5, m_v = 3;
            int i_v = 0, k_v;
            double[] a_v = new double[n_v] { 1, 3, 5, 7, 8 };
            double[] b_v = new double[m_v] { 2, 4, 6};
            Console.WriteLine("array A: ");
            for (i_v = 0; i_v < n_v; i_v++)
            {
                Console.Write($"{a_v[i_v]} ");
            }
            Console.WriteLine();
            Console.WriteLine("array B: ");
            for (i_v = 0; i_v < m_v; i_v++)
            {
                Console.Write($"{b_v[i_v]} ");
            }
            Console.WriteLine();
            double[] c_v = new double[n_v + m_v];
            k_v = n_v;
            if (n_v >= m_v)
            {
                k_v = m_v;
            }
            for (i_v = 0; i_v < k_v; i_v++)
            {
                c_v[i_v * 2] = a_v[i_v];
                c_v[i_v * 2 + 1] = b_v[i_v];
            }
            if (n_v > m_v)
            {
                for (i_v = k_v; i_v < n_v; i_v++)
                {
                    c_v[i_v+ k_v] = a_v[i_v];
                }
            }
            else if (n_v < m_v)
            {
                for (i_v = k_v; i_v < m_v; i_v++)
                {
                    c_v[i_v + k_v] = b_v[i_v];
                }
            }
            Console.WriteLine("array C: ");
            for (i_v = 0; i_v < n_v + m_v; i_v++)
            {
                Console.Write($"{c_v[i_v]} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.4.13

            const int n_c = 5, m_c = 3;
            int i_c = 0, l_c = 0;
            double[] a_c = new double[n_c] { 8, 7, 5, 3, 1 };
            double[] b_c = new double[m_c] { 6, 4, 2 };
            Console.WriteLine("array A: ");
            for (i_c = 0; i_c < n_c; i_c++)
            {
                Console.Write($"{a_c[i_c]} ");
            }
            Console.WriteLine();
            Console.WriteLine("array B: ");
            for (i_c = 0; i_c < m_c; i_c++)
            {
                Console.Write($"{b_c[i_c]} ");
            }
            Console.WriteLine();
            double[] c_c = new double[n_c + m_c];
            int aa_c = 0, bb_c = 0;
            while (aa_c < n_c && bb_c < m_c && l_c < n_c + m_c)
            {
                if (a_c[aa_c] >= b_c[bb_c])
                {
                    while (a_c[aa_c] >= b_c[bb_c])
                    {
                        c_c[l_c] = a_c[aa_c];
                        l_c++;
                        aa_c++;
                        if (aa_c == n_c)
                        {
                            break;
                        }
                    }
                }
                else if (a_c[aa_c] <= b_c[bb_c])
                {
                    while (a_c[aa_c] <= b_c[bb_c])
                    {
                        c_c[l_c] = b_c[bb_c]; ;
                        l_c++;
                        bb_c++;
                        if (bb_c == m_c)
                        {
                            break;
                        }
                    }
                }
            }
            if (n_c > aa_c)
            {
                for (int j_c = aa_c; j_c < n_c; j_c++)
                {
                    c_c[l_c] = a_c[j_c];
                    l_c++;
                }
            }
            if (m_c > bb_c)
            {
                for (int j_c = bb_c; j_c < n_c + m_c; j_c++)
                {
                    c_c[l_c] = b_c[j_c];
                    l_c++;
                }

            }
            Console.WriteLine("array C: ");
            for (i_c = 0; i_c < n_c + m_c; i_c++)
            {
                Console.Write($"{c_c[i_c]} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.4.14

            const int n_x = 5;
            int i_x = 0;
            double k_x;
            double[] a_x = new double[n_x] { 8, 7, 5, 3, 1 };
            Console.WriteLine("array: ");
            for (i_x = 0; i_x < n_x; i_x++)
            {
                Console.Write($"{a_x[i_x]} ");
            }
            Console.WriteLine();
            for (i_x = 0; i_x < n_x / 2; i_x++)
            {
                k_x = a_x[i_x];
                a_x[i_x] = a_x[n_x - 1 - i_x];
                a_x[n_x - 1 - i_x] = k_x;
            }
            if (n_x % 2 == 0)
            {
                k_x = a_x[n_x / 2];
                a_x[n_x / 2] = a_x[n_x / 2 + 1];
                a_x[n_x / 2 + 1] = k_x;
            }
            Console.WriteLine("new array: ");
            for (i_x = 0; i_x < n_x; i_x++)
            {
                Console.Write($"{a_x[i_x]} ");
            }
            Console.WriteLine();

            #endregion

            #region 3.4.15

            const int n_z = 5, m_z = 2;
            int i_z = 0;
            double k_z;
            double[] a_z = new double[n_z] { 8, 7, 5, 3, 1 };
            Console.WriteLine("array: ");
            for (i_z = 0; i_z < n_z; i_z++)
            {
                Console.Write($"{a_z[i_z]} ");
            }
            Console.WriteLine();
            for (i_z = 0; i_z < m_z; i_z++)
            {
                k_z = a_z[n_z - 1];
                for (int j_z = n_z - 1; j_z > 0; j_z--)
                {
                    a_z[j_z] = a_z[j_z - 1];

                }
                a_z[0] = k_z;
            }
            Console.WriteLine("new array: ");
            for (i_z = 0; i_z < n_z; i_z++)
            {
                Console.Write($"{a_z[i_z]} ");
            }
            Console.WriteLine();
            
            #endregion       
        }
    }
}
