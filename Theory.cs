using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace _3rd_Lab
{
    class Theory
    {

        static void Main(string[] args)
        {

            static double[] double_array(string str_, int size, ref bool flag)
            {

                double[] fin_arr = new double[size];
                string[] array_1 = str_.Split(' ');
                for (int i = 0; i < size; i++)
                {
                    if (!(array_1.Length == size & double.TryParse(array_1[i], out fin_arr[i])))
                    {
                        Console.WriteLine("input error");
                        flag = true;
                        double[] arr = { };
                        return arr;
                    }
                }
                return fin_arr;
            }
            static double[] min_value_index(double[] array)
            {
                double smallest_value = array[0];
                int smallest_index = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < smallest_value)
                    {
                        smallest_value = array[i];
                        smallest_index = i;
                    }
                }
                double[] fin_array = { smallest_value, smallest_index };
                return fin_array;
            }
            static double[] max_value_index(double[] array)
            {
                double biggest_value = array[0];
                int biggest_index = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > biggest_value)
                    {
                        biggest_value = array[i];
                        biggest_index = i;
                    }
                }
                double[] fin_array = { biggest_value, biggest_index };
                return fin_array;
            }

            static double BinarySearch(double[] array, double key)
            {
                int left = 0;
                int right = array.Length;
                int mid = 0;

                while (!(left >= right))
                {
                    mid = left + (right - left) / 2;

                    if (array[mid] == key)
                        return mid;

                    if (array[mid] > key)
                        right = mid;
                    else
                        left = mid + 1;
                }

                return -(1 + left);
            }

            static void task_1_6()
            {
                bool flag = false;
                int n = 5;
                double s = 0;
                Console.WriteLine("enter data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                foreach (double elem in array_in_use)
                {
                    s += elem * elem;
                }
                Console.WriteLine(Math.Sqrt(s));
            }
            static void task_1_10()
            {
                bool flag = false;
                int n = 10;
                double p;
                double q;
                int result = 0;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                Console.WriteLine("enter P:");
                bool res_1 = double.TryParse(Console.ReadLine(), out p);
                Console.WriteLine("enter Q:");
                bool res_2 = double.TryParse(Console.ReadLine(), out q);
                if (!(res_1 & res_2 & p < q))
                {
                    Console.WriteLine("input error");
                    return;
                }
                foreach (double elem in array_in_use)
                {
                    if (elem > p & elem < q) result++;
                }
                Console.WriteLine($"quality:{result} ");
            }
            static void task_1_11()
            {
                bool flag = false;
                int n = 10;
                int result = 0;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                foreach (double elem in array_in_use)
                {
                    if (elem > 0) result++;                 
                }
                double[] array_ = new double[result];
                for (int i = 0,j=0; i < array_in_use.Length; i++)
                {
                    if (array_in_use[i] > 0)
                    {
                        array_[j] = array_in_use[i];
                        j++;
                    }
                }
                Console.WriteLine("result array:");
                foreach (double elem in array_)
                {                   
                    Console.Write($"{elem}\t");
                }
            }//fixed
            static void task_1_12()
            {
                bool flag = false;
                int n = 8;
                double result = 0;
                int index = 0;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                for (int i = array_in_use.Length - 1; i >= 0; i--)
                {
                    if (array_in_use[i] < 0)
                    {
                        result = array_in_use[i];
                        index = i;
                    }
                }
                if (result == 0)
                {
                    Console.WriteLine("only positive numbers or zero");
                    return;
                }
                Console.WriteLine($"result:{result}\nindex:{index}");

            }
            static void task_1_13()
            {
                bool flag = false;
                int n = 10;
                double[] chet_array = new double[5];
                double[] ne_chet_array = new double[5];
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                for (int i = 0, chet_ind = 0, ne_chet_ind = 0; i < array_in_use.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        chet_array[chet_ind] = array_in_use[i];
                        chet_ind++;
                    }
                    else
                    {
                        ne_chet_array[ne_chet_ind] = array_in_use[i];
                        ne_chet_ind++;
                    }
                }
                Console.WriteLine("chet indexes:");
                foreach (double elem in chet_array)
                {
                    Console.Write($"{elem}\t");
                }
                Console.WriteLine();
                Console.WriteLine("nechet indexes:");
                foreach (double elem in ne_chet_array)
                {
                    Console.Write($"{elem}\t");
                }
            }
            

            static void task_2_5()
            {
                bool flag = false;
                int n;
                int quality = 0;
                Console.WriteLine("enter n:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                double max_elem = max_value_index(array_in_use)[0];
                double min_elem = min_value_index(array_in_use)[0];
                double[] res_array = new double[n];
                for (int i = 0, b = 0; i < array_in_use.Length; i++)
                {
                    if (array_in_use[i] < 0 & array_in_use[i] > min_elem & array_in_use[i] < max_elem)
                    {
                        res_array[b] = array_in_use[i];
                        b++;
                        quality++;
                    }
                }
                Console.WriteLine("result array:");
                for (int i = 0; i < quality; i++)
                {

                    Console.Write($"{res_array[i]}\t");
                }

            }
            static void task_2_6()
            {
                bool flag = false;
                int n;
                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine() + " 0";

                double[] array_in_use = double_array(str_, n + 1, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                double p;
                double s = 0;
                Console.WriteLine("enter P:");
                bool res_2 = double.TryParse(Console.ReadLine(), out p);
                if (!(res_2)) return;
                foreach (double elem in array_in_use)
                {
                    s += elem;
                }
                double average_ = s / (array_in_use.Length - 1);
                Console.WriteLine($"average:{average_}");
                double the_closest = array_in_use[0];
                int the_closest_ind = 0;

                for (int i = 1; i < array_in_use.Length; i++)
                {
                    if (Math.Abs(average_ - the_closest) > Math.Abs(average_ - array_in_use[i]))
                    {
                        the_closest = array_in_use[i];
                        the_closest_ind = i;
                    }
                }
                for (int i = array_in_use.Length - 1; i > the_closest_ind; i--)
                {
                    array_in_use[i] = array_in_use[i - 1];
                }
                array_in_use[the_closest_ind + 1] = p;

                foreach (double elem in array_in_use)
                {
                    Console.Write($"{elem}\t");
                }

            }
            static void task_2_9()
            {
                bool flag = false;
                int n;
                int quality = 0;
                Console.WriteLine("enter n:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                double max_elem = max_value_index(array_in_use)[0];
                double min_elem = min_value_index(array_in_use)[0];
                double s = 0;
                for (int i = 0; i < array_in_use.Length; i++)
                {
                    if (array_in_use[i] > min_elem & array_in_use[i] < max_elem)
                    {
                        s += array_in_use[i];
                        quality++;
                    }
                }
                double average = s / quality;
                Console.WriteLine($"result:{average}");


            }
            static void task_2_10() 
            {
                bool flag = false;
                int n;
                int quality = 0;
                int the_minimal_index=0;
                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                foreach (double elem in array_in_use)
                {
                    if (elem > 0) quality++;
                }
                double[] positive_array = new double[quality];
                for (int i = 0, b = 0; i < array_in_use.Length; i++)
                {
                    if (array_in_use[i] > 0)
                    {
                        positive_array[b] = array_in_use[i];
                        b++;
                    }
                    if(i == array_in_use.Length - 1)
                    {
                        double the_minimal_value = min_value_index(positive_array)[0];
                        the_minimal_index = Array.IndexOf(array_in_use, the_minimal_value);
                    }
                }
                
                
                for (int i = the_minimal_index; i < array_in_use.Length - 1; i++)
                {
                    array_in_use[i] = array_in_use[i + 1];
                }
                for (int i = 0; i < array_in_use.Length - 1; i++)
                {
                    Console.Write($"{array_in_use[i]}\t");
                }

            }//fixed but i didn't entirely understand
            static void task_2_11()
            {
                int n;
                bool flag = false;
                double result = 0;
                int index = 0;
                double p;
                bool f = true;
                Console.WriteLine("enter P:");
                bool res_2 = double.TryParse(Console.ReadLine(), out p);
                if (!(res_2)) return;
                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine() + " 0";
                double[] array_in_use = double_array(str_, n + 1, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                for (int i = array_in_use.Length - 1; i >= 0; i--)
                {
                    if (array_in_use[i] > 0 & f)
                    {
                        result = array_in_use[i];
                        index = i;
                        f = false;
                        i = array_in_use.Length - 1;
                    }
                    else if (!f) ;//cicle just need
                    else continue;
                    if (i > index)
                    {
                        array_in_use[i] = array_in_use[i - 1];
                    }
                }              
                array_in_use[index + 1] = p;

                foreach (double elem in array_in_use)
                {
                    Console.Write($"{elem}\t");
                }


            }//fixed
            static void task_2_13()
            {
                bool flag = false;
                int n;
                double index = 0;
                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                for (int i = 0; i < array_in_use.Length; i++)
                {
                    double max_ind = max_value_index(array_in_use)[1];
                    if (i % 2 == 0)
                    {
                        index = max_ind;
                        break;
                    }
                }                             
                array_in_use[(int)index] = index;
                foreach (double elem in array_in_use)
                {
                    Console.Write($"{elem}\t");
                }
            }//fixed
            static void task_2_15()
            {
                bool flag = false;
                int n;
                int m;
                int k;
                Console.WriteLine("enter k:");
                bool res_2 = int.TryParse(Console.ReadLine(), out k);
                if (!(res_2 & k >= 0)) return;
                Console.WriteLine("enter m for array B :");
                bool res_ = int.TryParse(Console.ReadLine(), out m);
                if (!(res_ & m > 0)) return;
                Console.WriteLine("enter array B data:");
                string str_b = Console.ReadLine();
                double[] array_b = double_array(str_b, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }

                Console.WriteLine("enter n for array A :");
                bool res = int.TryParse(Console.ReadLine(), out n);
                n += m;
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array A data:");
                string str_ = Console.ReadLine();
                for (int i = 0; i < m; i++)
                {
                    str_ += " 0";
                }
                double[] array_a = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                for (int i = n - m - 1, j = 0; i > k; i--, j--)
                {

                    array_a[n - 1 + j] = array_a[i];

                }
                for (int i = k + 1, j = 0; i <= k + m; i++, j++)
                {

                    array_a[i] = array_b[j];

                }
                foreach (double elem in array_a)
                {
                    Console.Write($"{elem}\t");
                }



            }
            task_2_11();



            static void task_3_1()
            {
                bool flag = false;
                int n;
                Console.WriteLine("enter n:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                int[] indexes = new int[array_in_use.Length];
                double biggest_value = array_in_use[0];
                for (int i = 1,j =0; i < array_in_use.Length; i++)
                {
                    if (array_in_use[i] > biggest_value)
                    {
                        j = 0;
                        for (int k = 0; k < indexes.Length; k++)
                        {
                            indexes[k] = 0;
                        }
                        biggest_value = array_in_use[i];
                    }
                    if (array_in_use[i] == biggest_value )
                    {
                        
                        indexes[j] = i;
                        j++;
                    }
                                     
                }
                for (int i = 0; i < indexes.Length; i++)
                {
                    if (i != 0 & indexes[i] == 0) break;
                    Console.Write($"{indexes[i]}\t");
                }
                
                
            }//fixed
            static void task_3_5()
            {
                bool flag = false;
                int n;
                int n_for_chet = 0;
                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                n_for_chet = (n % 2 == 0) ? n / 2 : (n - 1) / 2 + 1;
                double[] chet_array = new double[n_for_chet];
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                for (int i = 0, chet_ind = 0; i < array_in_use.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        chet_array[chet_ind] = array_in_use[i];
                        chet_ind++;
                    }

                }
                Array.Sort(chet_array);
                Console.WriteLine("chet sorted array:");
                foreach (double elem in chet_array)
                {
                    Console.Write($"{elem}\t");
                }
                Console.WriteLine();
                for (int i = 0, j = 0; j < chet_array.Length; i += 2, j++)
                {
                    array_in_use[i] = chet_array[j];
                }
                Console.WriteLine("result array:");
                foreach (double elem in array_in_use)
                {
                    Console.Write($"{elem}\t");
                }


            }//ok
            static void task_3_8()
            {
                bool flag = false;
                int n;
                int quality = 0;
                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                foreach (double elem in array_in_use)
                {
                    if (elem < 0) quality++;
                }
                double[] negative_array = new double[quality];
                for (int i = 0, b = 0; i < array_in_use.Length; i++)
                {
                    if (array_in_use[i] < 0)
                    {
                        negative_array[b] = array_in_use[i];
                        b++;
                    }
                }
                Array.Sort(negative_array);
                Array.Reverse(negative_array);
                Console.WriteLine("negative sorted array");
                foreach (double elem in negative_array)
                {
                    Console.Write($"{elem}\t");
                }
                for (int i = 0, j = 0; j < negative_array.Length; i++)
                {
                    if (array_in_use[i] < 0)
                    {
                        array_in_use[i] = negative_array[j];
                        j++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("result array:");
                foreach (double elem in array_in_use)
                {
                    Console.Write($"{elem}\t");
                }
            }//ok
            static void task_3_9()
            {
                bool flag = false;
                int n;
                int quality_1 = 1;
                int quality_2 = 1;
                int fin_q_1 = 1;
                int fin_q_2 = 1;
                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                for (int i = 0; i < array_in_use.Length - 1; i++)
                {
                    if (array_in_use[i + 1] > array_in_use[i])
                    {
                        quality_1++;
                        if (quality_1 > fin_q_1)
                        { fin_q_1 = quality_1; }
                        continue;
                    }
                   
                    quality_1 = 1;
                                    
                }
                for (int i = 0; i < array_in_use.Length - 1; i++)
                {
                    if (array_in_use[i + 1] < array_in_use[i])
                    {
                        quality_2++;
                        if (quality_2 > fin_q_2) { 
                        fin_q_2 = quality_2;
                    }
                        continue;
                    }
                    
                        quality_2 = 1;
                    
                }





                if (quality_1 > fin_q_1)
                {
                    fin_q_1 = quality_1;
                }
                if (quality_2 > fin_q_2)
                {
                    fin_q_2 = quality_2;
                }


                if (fin_q_1 >= fin_q_2)
                {
                    Console.WriteLine($"the longest:{fin_q_1}");
                }
                else
                {
                    Console.WriteLine($"the longest:{fin_q_2}");
                }
            } //fixed
            static void task_3_12()
            {
                bool flag = false;
                int n = 12;
                int quality = 0;
                Console.WriteLine("enter array data(12):");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                foreach (double elem in array_in_use)
                {
                    if (elem >= 0) quality++;
                }
                double[] positive_array = new double[quality];
                for (int i = 0, b = 0; i < array_in_use.Length; i++)
                {
                    if (array_in_use[i] >= 0)
                    {
                        positive_array[b] = array_in_use[i];
                        b++;
                    }
                }
                Console.WriteLine("result array:");
                foreach (double elem in positive_array)
                {
                    Console.Write($"{elem}\t");
                }
            }
            static void task_3_13()
            {
                bool flag = false;
                int n;
                int quality = 0;
                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                Array.Sort(array_in_use);
                for (int i = 0; i < array_in_use.Length - 1; i++)
                {
                    if (array_in_use[i] == array_in_use[i + 1])
                        continue;
                    quality++;
                }
                double[] new_array = new double[quality];
                for (int i = 0, j = 0; i < array_in_use.Length - 1; i++)
                {
                    if (array_in_use[i] == array_in_use[i + 1])
                        continue;
                    new_array[j] = array_in_use[i + 1];
                    j++;
                }
                Console.WriteLine("result array:");
                foreach (double elem in new_array)
                {
                    Console.Write($"{elem}\t");
                }
            }// sort it is not useful, it will not work without it
            



            static void task11()
            {
                bool flag = false;
                int n;
                double key = 0;
                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("enter key:");
                bool res2 = double.TryParse(Console.ReadLine(), out key);
                if (!(res & n > 0 & res2)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                Console.WriteLine("result:");
                Console.WriteLine(BinarySearch(array_in_use, key));
            }
            static void task12()
            {
                bool flag = false;
                int n;
                int m;
                int quality = 0;
                Console.WriteLine("enter n for array_1:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array_1 data:");
                string str_ = Console.ReadLine();
                double[] array_in_use_1 = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                Console.WriteLine("enter m for array_2:");
                bool res1 = int.TryParse(Console.ReadLine(), out m);
                if (!(res1 & m > 0)) return;
                Console.WriteLine("enter array_2 data:");
                string str_1 = Console.ReadLine();
                double[] array_in_use_2 = double_array(str_1, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                double[] res_array = new double[n + m];
                for (int i = 0, j = 0; i < res_array.Length; i += 2, j++)
                {
                    res_array[i] = array_in_use_1[j];

                }
                for (int i = 1, j = 0; i < res_array.Length; i += 2, j++)
                {
                    res_array[i] = array_in_use_2[j];

                }
                Console.WriteLine("result array:");
                foreach (double elem in res_array)
                {
                    Console.Write($"{elem}\t");
                }
            }
            static void task13()
            {
                bool flag = false;
                int n;
                int m;
                int quality = 0;
                Console.WriteLine("enter n for array_1:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array_1(sorted po ubivaniu) data:");
                string str_ = Console.ReadLine();
                double[] array_in_use_1 = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                Console.WriteLine("enter m for array_2:");
                bool res1 = int.TryParse(Console.ReadLine(), out m);
                if (!(res1 & m > 0)) return;
                Console.WriteLine("enter array_2(sorted po ubivaniu) data:");
                string str_1 = Console.ReadLine();
                double[] array_in_use_2 = double_array(str_1, m, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                double[] res_array = new double[n + m];
                for (int i = 0; i < array_in_use_1.Length; i++)
                {
                    res_array[i] = -array_in_use_1[i];
                }
                for (int i = n, j = 0; i < n + m; i++, j++)
                {
                    res_array[i] = -array_in_use_2[j];
                }
                Array.Sort(res_array);
                for (int i = 0; i < res_array.Length; i++)
                {
                    res_array[i] = -res_array[i];
                }
                Console.WriteLine("result array:");
                foreach (double elem in res_array)
                {
                    Console.Write($"{elem}\t");
                }

            }
            static void task14()
            {
                bool flag = false;
                int n;

                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                for (int i = 0; i < array_in_use.Length / 2; i++)
                {
                    double memory = array_in_use[i];
                    array_in_use[i] = array_in_use[n - 1 - i];
                    array_in_use[n - 1 - i] = memory;
                }
                Console.WriteLine("result array:");
                foreach (double elem in array_in_use)
                {
                    Console.Write($"{elem}\t");
                }


            }
            static void task15()
            {
                bool flag = false;
                int n;
                int quality;
                Console.WriteLine("enter n for array:");
                bool res = int.TryParse(Console.ReadLine(), out n);
                if (!(res & n > 0)) return;
                Console.WriteLine("enter array data:");
                string str_ = Console.ReadLine();
                Console.WriteLine("enter positions quality:");
                bool res_ = int.TryParse(Console.ReadLine(), out quality);
                if (!(res_ & quality<n-1)) return;
                double[] array_in_use = double_array(str_, n, ref flag);
                if (flag)
                {
                    Console.WriteLine("input error");
                    return;
                }
                double[] first_elements = new double[array_in_use.Length - quality];
                for (int i = 0; i < first_elements.Length; i++)
                {
                    first_elements[i] = array_in_use[i];
                }
                

                for (int i = 0, j = 0; i < quality; i++, j++)
                {
                    array_in_use[i] = array_in_use[n-quality+j];
                }
               

                for (int i = quality,j=0; i <n; i++,j++)
                {
                    array_in_use[i] = first_elements[j];
                }

                Console.WriteLine("result array:");
                foreach (double elem in array_in_use)
                {
                    Console.Write($"{elem}\t");
                }
            }
            



        }
    }
}  
