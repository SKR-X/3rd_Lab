using System;

namespace _1st_Lesson
{
    
    class Program
    {
        static string ListToString(List<double> L)
        {
            string s = "";
            foreach (double v in L)
            {
                s += v.ToString();
                s += " ";
            }
            return s;
        }
        static void exercise_1_6()
        {
            string error = "ошибка 1_6";
            double L = 0;
            int n = 5;
            //List<double> x = new List<double>();
            Console.WriteLine($"ведите {n} значений");
            for (int i = 0; i < n; ++i)
            {
                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                L += a * a;
            }
            L = Math.Sqrt(L);
            Console.WriteLine(L);
        }
        static void exercise_1_10()
        {
            string error = "ошибка 1_10";
            int n = 10;
            double P, Q;
            int ans = 0;
            //List<double> x = new List<double>();

            Console.WriteLine($"ведите P и Q (P<Q)");

            if (!Input.CheckRead(out P, error) || !Input.CheckRead(out Q, error))
            {
                return;
            }
            if(P >= Q)
            {
                Console.WriteLine("неверные значения P и Q");
                return;
            }

            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {
                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                if(a >= Q && a <= P) ans++;
            }

            Console.WriteLine(ans);
        }
        static void exercise_1_11()
        {
            string error = "ошибка 1_11";
            int n = 10;
            int ans = 0;

            List<double> x = new List<double>();

            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {
                
                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                if (a > 0)
                {
                    x.Add(a);
                }
            }

            foreach(double a in x)
            {
                Console.WriteLine(a);
            }
        }
        static void exercise_1_12()
        {
            string error = "ошибка 1_12";
            double ans = 0;
            int ansI = -1, n = 8;

            //List<double> x = new List<double>();

            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                if (a < 0)
                {
                    ansI = i + 1;
                    ans = a;
                }
            }

            if(ansI == -1)
            {
                Console.WriteLine($" нет отрицательных");
                return;
            } 

            Console.WriteLine($" {ansI} {ans} ");
        }
        static void exercise_1_13()
        {
            string error = "ошибка 1_13";
            int n = 10;

            List<double> x1 = new List<double>(), x2 = new List<double>();

            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }
                
                if(i%2 == 1)
                {
                    x1.Add(a);
                }
                else
                {
                    x2.Add(a);
                }
            }

            string s1 = "", s2 = "";
            foreach (double a in x1)
            {
                s1 += a.ToString();
                s1 += " ";
            }

            foreach (double a in x2)
            {
                s2 += a.ToString();
                s2 += " ";
            }

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }


        static void exercise_2_5()
        {
            string error = "ошибка 2_5";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if(n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений");
            int maxI = 0, minI = 0;
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);

                if(a > x[maxI])
                {
                    maxI = i;
                }

                if (a < x[minI])
                {
                    minI = i;
                }
            }

            string s = "ans : ";
            for(int i = Math.Min(minI,maxI); i <= Math.Max(minI, maxI); ++i)
            {
                if (x[i] >= 0) continue;
                ans.Add(x[i]);
            }
            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_2_6()
        {
            string error = "ошибка 2_6";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений");
            double sum = 0;
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);
                sum += a;
            }
            double mid = sum / n;
            int midI = 0;
            
            for (int i = 0; i < x.Count(); ++i)
            {
                if (Math.Abs(mid - x[midI]) > Math.Abs(mid - x[i]))
                {
                    midI = i;
                }
            }

            Console.WriteLine("ведите P");
            double P;
            if (!Input.CheckRead(out P, error))
            {
                return;
            }

            string s = "ans : ";
            for(int i = 0; i < x.Count(); ++i)
            {
                ans.Add(x[i]);
                if(i == midI)
                {
                    ans.Add(P);
                }
            }
            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_2_9()
        {
            string error = "ошибка 2_9";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений");
            int maxI = 0, minI = 0;
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);

                if (a > x[maxI])
                {
                    maxI = i;
                }

                if (a < x[minI])
                {
                    minI = i;
                }
            }
            double sum = 0;
            int kol = 0;
            string s = "ans : ";
            for (int i = Math.Min(minI, maxI); i <= Math.Max(minI, maxI); ++i)
            {
                kol++;
                sum += x[i];
            }
            double sr = sum / kol;
            s += sr.ToString();
            Console.WriteLine(s);
        }
        static void exercise_2_10()
        {
            string error = "ошибка 2_10";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений");
            int minI = -1;
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);

                if(a >= 0)
                {
                    if(minI == -1 || a < x[minI])
                    {
                        minI = i;
                    }
                }
            }

            string s = "ans : ";
            for (int i = 0; i < x.Count(); ++i) 
            {
                if (i == minI) continue;
                ans.Add(x[i]); 
            }
            
            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_2_11()
        {
            string error = "ошибка 2_11";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений");
            int lastI = -1;
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);

                if (a >= 0)
                {
                    lastI = i;
                }
            }
            Console.WriteLine("ведите P");
            double P;
            if (!Input.CheckRead(out P, error))
            {
                return;
            }
            string s = "ans : ";
            for (int i = 0; i < x.Count(); ++i)
            {
                
                ans.Add(x[i]);
                if (i == lastI)
                {
                    ans.Add(P);
                }
            }

            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_2_13()
        {
            string error = "ошибка 2_11";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений");
            int maxI = 0;
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);

                if (i % 2 == 0) 
                {
                    if (x[maxI] < a)
                    {
                        maxI = i;
                    }
                }
            }
            
            string s = "ans : ";
            for (int i = 0; i < x.Count(); ++i)
            {
                if (i == maxI)
                {
                    ans.Add(maxI);
                }
                else
                {
                    ans.Add(x[i]);
                }
            }

            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_2_15()
        {
            string error = "ошибка 2_15";
            int n,m,k;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            Console.WriteLine($"ведите m (m >= 0)");
            if (!Input.CheckRead(out m, error))
            {
                return;
            }
            if (m < 0)
            {
                Console.WriteLine("неправильное m");
                return;
            }
            Console.WriteLine($"ведите k (k < n && k >= 0)");
            if (!Input.CheckRead(out k, error))
            {
                return;
            }
            if (k < 0 || k >= n)
            {
                Console.WriteLine("неправильное k");
                return;
            }
            List<double> A = new List<double>(), B = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений");
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                A.Add(a);

            }
            Console.WriteLine($"ведите {m} значений");
            for (int i = 0; i < m; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                B.Add(a);

            }

            string s = "ans : ";
            for (int i = 0; i < A.Count(); ++i)
            {
                ans.Add(A[i]);
                if(i == k)
                {
                    foreach(double a in B)
                    {
                        ans.Add(a);
                    }
                }
            }

            s += ListToString(ans);
            Console.WriteLine(s);
        }


        static void exercise_3_1()
        {

            string error = "ошибка 3_1";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений");
            int maxI = 0;
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);

                if (x[maxI] < a)
                {
                    maxI = i;
                }

            }

            string s = "ans : ";
            for (int i = 0; i < x.Count(); ++i)
            {
                if (x[i] == x[maxI])
                {
                    ans.Add(i);
                }
            }

            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_3_5()
        {

            string error = "ошибка 3_5";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x1 = new List<double>(), x2 = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                if (i % 2 == 0)
                {
                    x2.Add(a);
                }
                else
                {
                    x1.Add(a);
                }
            }

            x2.Sort();

            string s = "ans : ";
            for (int i = 0; i < x2.Count(); ++i)
            {
                ans.Add(x2[i]);
                if (i < x1.Count())
                {
                    ans.Add(x1[i]);
                }
            }

            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_3_8()
        {

            string error = "ошибка 3_8";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x1 = new List<double>(), x2 = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                if (a < 0)
                {
                    x1.Add(-1);
                    x2.Add(a);
                }
                else
                {
                    x1.Add(a);
                }
            }

            x2.Sort();
            x2.Reverse();

            string s = "ans : ";
            int sh = 0;
            for (int i = 0; i < x1.Count(); ++i)
            {
                if (x1[i] == -1)
                {
                    ans.Add(x2[sh]);
                    sh++;
                }
                else
                {
                    ans.Add(x1[i]);
                }
            }

            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_3_9()
        {

            string error = "ошибка 3_9";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x = new List<double>();

            Console.WriteLine($"ведите {n} значений");
            int max1 = 1, max2 = 1, sh1 = 1, sh2 = 1;
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);
            }

            for (int i = 0; i < x.Count() - 1; ++i)
            {
                if (x[i] < x[i + 1])
                {
                    sh1++;
                    max2 = Math.Max(max2, sh2);
                    sh2 = 1;
                    continue;
                }

                if (x[i] > x[i + 1])
                {
                    sh2++;
                    max1 = Math.Max(max1, sh1);
                    sh1 = 1;
                    continue;
                }
                max1 = Math.Max(max1, sh1);
                max2 = Math.Max(max2, sh2);
                sh1 = 1;
                sh2 = 1;
            }
            int ans = Math.Max(max1, max2);
            string s = "ans : ";
            s += ans.ToString();
            Console.WriteLine(s);
        }
        static void exercise_3_12()
        {

            string error = "ошибка 3_12";
            int n = 12;

            List<double> x = new List<double>(), ans = new List<double>();

            Console.WriteLine($"ведите {n} значений"); ;
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);
            }

            for (int i = 0; i < x.Count() ; ++i)
            {
                if (x[i] >= 0)
                {
                    ans.Add(x[i]);
                }
            }

            string s = "ans : ";
            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_3_13()
        {

            string error = "ошибка 3_13";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x = new List<double>();
            Dictionary<double,bool> check = new Dictionary<double,bool>();
            Console.WriteLine($"ведите {n} значений");
            int max1 = 1, max2 = 1, sh1 = 1, sh2 = 1;
            for (int i = 0; i < n; ++i)
            {

                double a;
                if (!Input.CheckRead(out a, error))
                {
                    return;
                }
                if (!check.ContainsKey(a))
                {
                    x.Add(a);
                    check.Add(a, true);
                }
            }
  
            string s = "ans : ";

            s += ListToString(x);
            Console.WriteLine(s);
        }

        static void exercise_0_11()
        {
            string error = "ошибка 0_11";
            int n;
            double x;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }
            Console.WriteLine($"ведите x");
            if (!Input.CheckRead(out x, error))
            {
                return;
            }

            List<double> A = new List<double>();
            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {
                double a;

                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                A.Add(a);
            }
            A.Sort();
            int l = 0, r = A.Count()-1 ,ans = -1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (A[mid] == x)
                {
                    ans = mid;
                    break;
                }
                if (A[mid] < x)
                {
                    l = mid + 1;
                }
                if (A[mid] > x)
                {
                    r = mid - 1;
                }
            }

            string s = "ans : ";
            if (ans >= 0)
            {
                s += ans.ToString();
            }
            else
            {
                s += "-";
            }
            Console.WriteLine(s);
        }
        static void exercise_0_12()
        {
            string error = "ошибка 0_12";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> A = new List<double>(), B = new List<double>(), ans = new List<double>();
            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {
                double a;

                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                A.Add(a);
            }

            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {
                double a;

                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                B.Add(a);
            }

            for (int i = 0; i < n; ++i)
            {
                ans.Add(A[i]);
                ans.Add(B[i]);
            }

            string s = "ans : ";
            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_0_13()
        {
            string error = "ошибка 0_13";
            int n,m;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            Console.WriteLine($"ведите m (m >= 0)");
            if (!Input.CheckRead(out m, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное m");
                return;
            }
            List<double> A = new List<double>(), B = new List<double>(), ans = new List<double>();
            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {
                double a;

                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                A.Add(a);
            }
            Console.WriteLine($"ведите {m} значений");
            for (int i = 0; i < m; ++i)
            {
                double a;

                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                B.Add(a);
            }

            A.Sort();
            B.Sort();
            int sh1 = 0, sh2 = 0;
            while(sh1 < A.Count() || sh2 < B.Count())
            {

                if(sh1 == A.Count())
                {
                    ans.Add(B[sh2]);
                    sh2++;
                    continue;
                }

                if (sh2 == B.Count())
                {
                    ans.Add(A[sh1]);
                    sh1++;
                    continue;
                }
                //Console.WriteLine($"{sh1} , {sh2}");
                if (A[sh1] <= B[sh2])
                {
                    ans.Add(A[sh1]);
                    sh1++;
                }
                else
                {
                    ans.Add(B[sh2]);
                    sh2++;
                }
            }

            string s = "ans : ";
            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void exercise_0_14()
        {
            string error = "ошибка 0_14";
            int n;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }

            List<double> x = new List<double>();
            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {
                double a;

                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);
            }

            x.Reverse();

            string s = "ans : ";
            s += ListToString(x);
            Console.WriteLine(s);
        }
        static void exercise_0_15()
        {
            string error = "ошибка 0_15";
            int n,k;
            Console.WriteLine($"ведите n (n >= 0)");
            if (!Input.CheckRead(out n, error))
            {
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("неправильное n");
                return;
            }
            Console.WriteLine($"ведите k");
            if (!Input.CheckRead(out k, error))
            {
                return;
            }
            List<double> x = new List<double>(), ans = new List<double>();
            Console.WriteLine($"ведите {n} значений");

            for (int i = 0; i < n; ++i)
            {
                double a;

                if (!Input.CheckRead(out a, error))
                {
                    return;
                }

                x.Add(a);
            }

            k %= n;
            if (k < 0)
            {
                k=Math.Abs(k);
                for (int i = k; i < x.Count(); ++i)
                {
                    ans.Add(x[i]);
                }
                for (int i = 0; i < k; ++i)
                {
                    ans.Add(x[i]);
                }
            }
            else
            {
                for (int i = x.Count() - k; i < x.Count(); ++i)
                {
                    ans.Add(x[i]);
                }
                for (int i = 0; i < x.Count() - k; ++i)
                {
                    ans.Add(x[i]);
                }
            }
            string s = "ans : ";
            s += ListToString(ans);
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            #region exercise 1_6
            exercise_1_6();
            #endregion

            #region exercise 1_10
            exercise_1_10();
            #endregion

            #region exercise 1_11
            exercise_1_11();
            #endregion

            #region exercise 1_12
            exercise_1_12();
            #endregion

            #region exercise 1_13
            exercise_1_13();
            #endregion

            #region exercise 2_5
            exercise_2_5();
            #endregion

            #region exercise 2_6
            exercise_2_6();
            #endregion

            #region exercise 2_9
            exercise_2_9();
            #endregion

            #region exercise 2_10
            exercise_2_10();
            #endregion

            #region exercise 2_11
            exercise_2_11();
            #endregion

            #region exercise 2_13
            exercise_2_13();
            #endregion

            #region exercise 2_15
            exercise_2_15();
            #endregion

            #region exercise 3_1
            exercise_3_1();
            #endregion

            #region exercise 3_5
            exercise_3_5();
            #endregion

            #region exercise 3_8
            exercise_3_8();
            #endregion

            #region exercise 3_9
            exercise_3_9();
            #endregion

            #region exercise 3_12
            exercise_3_12();
            #endregion

            #region exercise 3_13
            exercise_3_13();
            #endregion

            #region exercise 0_11
            exercise_0_11();
            #endregion

            #region exercise 0_12
            exercise_0_12();
            #endregion

            #region exercise 0_13
            exercise_0_13();
            #endregion

            #region exercise 0_14
            exercise_0_14();
            #endregion

            #region exercise 0_15
            exercise_0_15();
            #endregion
        }
    }

    static class Input
    {
        const string EndString = "";
        
        static public bool Read(out double x)
        {
            string s;
            s = Console.ReadLine();

            if (!double.TryParse(s, out x))
            {
                return false;
            }
            return true;
        }
        static public bool Read(out int x)
        {
            string s;
            s = Console.ReadLine();

            if (!int.TryParse(s, out x))
            {
                return false;
            }
            return true;
        }
        static public bool Read(out int x, out bool fl)
        {
            fl = false;
            string s;
            s = Console.ReadLine();
            if (s == EndString) fl = true;
            if (!int.TryParse(s, out x))
            {
                return fl;
            }
            return true;
        }
        static public bool Read(out double x, out bool fl)
        {
            fl = false;
            string s;
            s = Console.ReadLine();
            if (s == EndString) fl = true;
            if (!double.TryParse(s, out x))
            {
                return fl;
            }
            return true;
        }

        static public bool CheckRead(out double x, string Erorr = "ошибка", string? ans = null)
        {
            bool fl;
            if (!Read(out x, out fl))
            {
                Console.WriteLine(Erorr);
                return false;
            }

            if (fl)
            {
                if (ans != null)
                {
                    Console.WriteLine(ans);
                }
                return false;
            }
            return true;
        }
        static public bool CheckRead(out int x, string Erorr = "ошибка", string? ans = null)
        {
            bool fl;
            if (!Read(out x, out fl))
            {
                Console.WriteLine(Erorr);
                return false;
            }

            if (fl)
            {
                if (ans != null)
                {
                    Console.WriteLine(ans);
                }
                return false;
            }
            return true;
        }
    }

}