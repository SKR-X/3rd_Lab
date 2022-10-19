using System;


namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto used to test the tasks faster, not as a part of the program
            //goto task_10_lv1;
            //goto task_11_lv1;
            //goto task_13_lv1;

            //goto task_5_lv2;
            //goto task_6_lv2;
            //goto task_9_lv2;
            //goto task_10_lv2;
            //goto task_11_lv2;
            //goto task_13_lv2;
            //goto task_15_lv2;

            //goto task_1_lv3;
            //goto task_5_lv3;
            //goto task_8_lv3;
            //goto task_9_lv3;
            //goto task_12_lv3;
            //goto task_13_lv3;

            //goto alg_11;
            //goto alg_12;
            //goto alg_13;
            //goto alg_14;
            //goto alg_15;

        task_6_lv1:
            #region task 6 lv1
            Console.WriteLine("Task 6 (level 1)");
            double[] lst = new double[5];
            bool try_x;
            double x;

            Console.WriteLine("Enter the coordinates.");
            for (int i = 0; i <= 4; i++)
            {
                try_x = double.TryParse(Console.ReadLine(), out x);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
                lst[i] = x;
            }

            double l = 0;
            foreach (double val in lst)
            {
                l += val * val;
            }

            Console.WriteLine($"L = {Math.Sqrt(l):f4}.");
            Console.ReadLine();

        #endregion

        task_10_lv1:
            #region task 10 lv1
            Console.WriteLine("Task 10 (level 1)");

            lst = new double[10];
            Console.WriteLine($"Enter the values of the array.");
            for (int i = 0; i <= 9; i++)
            {
                try_x = double.TryParse(Console.ReadLine(), out x);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
                lst[i] = x;
            }

            Console.WriteLine("Enter P value.");
            double p;
            try_x = double.TryParse(Console.ReadLine(), out p);
            if (!try_x)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter Q value (must be greater than P).");
            double q;
            try_x = double.TryParse(Console.ReadLine(), out q);
            if ((!try_x) || (q <= p))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }
            //Console.WriteLine($"{p}, {q}");

            int count = 0;
            foreach(double val in lst)
            {
                //Console.Write($"{val} ");
                if ((val > p) && (val < q))
                {
                    count++;
                }
            }

            Console.WriteLine($"There is(are) {count} element(s) between P and Q.");
            Console.ReadLine();
        #endregion

        task_11_lv1:
            #region task 11 lv1
            Console.WriteLine("Task 11 (level 1)");

            lst = new double[10];
            Console.WriteLine($"Enter the values of the array.");
            for (int i = 0; i <= 9; i++)
            {
                try_x = double.TryParse(Console.ReadLine(), out x);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
                lst[i] = x;
            }

            double[] lst2 = new double[10];
            int i2 = 0;
            foreach (double val in lst)
            {
                if (val > 0)
                {
                    lst2[i2] = val;
                    i2++;
                }
            }

            Console.WriteLine("Here is your new array:");

            /*foreach (double val in lst2)
            {
                Console.WriteLine(val);
            }*/

            for (int i = 0; i < i2; i++)
            {
                Console.Write($"{lst2[i]}  ");
            }
            Console.ReadLine();
        #endregion

        task_12_lv1:
            #region task 12 lv1
            Console.WriteLine("Task 12 (level 1)");

            lst = new double[8];
            Console.WriteLine($"Enter the values of the array.");
            for (int i = 0; i <= 7; i++)
            {
                try_x = double.TryParse(Console.ReadLine(), out x);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
                lst[i] = x;
            }

            for (int i = 7; i >= 0; i--)
            {
                if (lst[i] < 0)
                {
                    Console.WriteLine($"The last negative value in the array is {lst[i]}. It's number in the array is {i + 1}.");
                    break;
                }
            }

            Console.ReadLine();
        #endregion

        task_13_lv1:
            #region task 13 lv1
            Console.WriteLine("Task 13 (level 1)");

            lst = new double[10];
            Console.WriteLine($"Enter the values of the array.");
            for (int i = 0; i <= 9; i++)
            {
                try_x = double.TryParse(Console.ReadLine(), out x);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
                lst[i] = x;
            }

            lst2 = new double[5];
            double[] lst3 = new double[5];
            for (int i = 0; i <= 9; i++)
            {
                if (i % 2 == 0)
                {
                    lst2[i / 2] = lst[i];
                }

                else
                {
                    lst3[i / 2] = lst[i];
                }
            }

            Console.WriteLine("Here are your new arrays:");
            foreach (double val in lst2)
            {
                Console.Write($"{val}  ");
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (double val in lst3)
            {
                Console.Write($"{val}  ");
            }

            Console.ReadLine();
        #endregion


        task_5_lv2:
            #region task 5 lv2
            Console.WriteLine("Task 5 (level 2)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            string input = Console.ReadLine();
            string[] lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            double min = lst2[0], max = lst2[0];
            int min_ind = 0, max_ind = 0;

            for (int i = 1; i < lst2.Length; i++)
            {
                if (lst2[i] < min)
                {
                    min = lst2[i];
                    min_ind = i;
                }
                else if (lst2[i] > max)
                {
                    max = lst2[i];
                    max_ind = i;
                }
            }

            Console.WriteLine($"max: {max}; index: {max_ind}");
            Console.WriteLine($"min: {min}; index: {min_ind}");
            Console.WriteLine();

            int left = Math.Min(min_ind, max_ind);
            int right = Math.Max(min_ind, max_ind);

            if (right - left <= 1)
            {
                Console.WriteLine("Can't create new array.");
                Console.ReadLine();
                return;
            }

            count = 0;
            lst = new double[right - left - 1];
            for (int i = left + 1; i < right; i++)
            {
                if (lst2[i] < 0)
                {
                    lst[count] = lst2[i];
                    //Console.WriteLine(lst[count]);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Can't create new array.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Here is your new array:");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{lst[i]}  ");
            }

            Console.ReadLine();
        #endregion

        task_6_lv2:
            #region task 6 lv2
            Console.WriteLine("Task 6 (level 2)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            double ave = 0;
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
                ave += lst2[i];
            }
            ave = ave / lst2.Length;
            Console.WriteLine($"The average is {ave}.");

            double min_diff = Math.Abs(ave - lst2[0]);
            min_ind = 0;

            for (int i = 1; i < lst2.Length; i++)
            {
                if (Math.Abs(ave - lst2[i]) < min_diff)
                {
                    min_diff = Math.Abs(ave - lst2[i]);
                    min_ind = i;
                }
            }

            Console.WriteLine($"The closest to average is {lst2[min_ind]}; index: {min_ind}");
            Console.WriteLine();

            Console.WriteLine("Enter the P value.");
            try_x = double.TryParse(Console.ReadLine(), out p);
            if (!try_x)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst = new double[lst2.Length + 1];

            for (int i = lst.Length - 1; i >= 0; i--)
            {
                if (i > min_ind + 1)
                {
                    lst[i] = lst2[i - 1];
                }
                else if (i == min_ind + 1)
                {
                    lst[i] = p;
                }
                else
                {
                    lst[i] = lst2[i];
                }
            }

            Console.WriteLine("Here is your new array:");
            foreach (double val in lst)
            {
                Console.Write($"{val}  ");
            }

            Console.ReadLine();
        #endregion

        task_9_lv2:
            #region task 9 lv2
            Console.WriteLine("Task 9 (level 2)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            min = lst2[0];
            max = lst2[0];
            min_ind = 0;
            max_ind = 0;

            for (int i = 1; i < lst2.Length; i++)
            {
                if (lst2[i] < min)
                {
                    min = lst2[i];
                    min_ind = i;
                }
                else if (lst2[i] > max)
                {
                    max = lst2[i];
                    max_ind = i;
                }
            }

            Console.WriteLine($"max: {max}; index: {max_ind}");
            Console.WriteLine($"min: {min}; index: {min_ind}");
            Console.WriteLine();

            left = Math.Min(min_ind, max_ind);
            right = Math.Max(min_ind, max_ind);

            if (right - left <= 1)
            {
                Console.WriteLine("Can't calculate the value.");
                Console.ReadLine();
                return;
            }

            count = 0;
            ave = 0;
            lst = new double[right - left - 1];
            for (int i = left + 1; i < right; i++)
            {
                ave += lst2[i];
            }


            Console.WriteLine($"The average value is {ave / lst.Length}.");

            Console.ReadLine();
        #endregion

        task_10_lv2:
            #region task 10 lv2
            Console.WriteLine("Task 10 (level 2)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            min_ind = -1;
            min = 0;
            
            for (int i = min_ind + 1; i < lst2.Length; i++)
            {
                if ((lst2[i] > 0) && ((lst2[i] < min) || (min_ind == 0)))
                {
                    min = lst2[i];
                    min_ind = i;
                }
            }
            if (min_ind == -1)
            {
                Console.WriteLine("No positive values to delete in the array.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine($"min positive: {min}; index: {min_ind}");
            Console.WriteLine();

            Console.WriteLine("Here is your new array:");

            for (int i = 0; i < lst2.Length; i++)
            {
                if (i != min_ind)
                {
                    Console.Write($"{lst2[i]}  ");
                }
            }

            Console.ReadLine();
        #endregion

        task_11_lv2:
            #region task 11 lv2
            Console.WriteLine("Task 11 (level 2)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            int ind = -1;
            double last_pos = 0;
            for (int i = lst2.Length - 1; i >= 0; i--)
            {
                if (lst2[i] > 0)
                {
                    last_pos = lst2[i];
                    ind = i;
                    break;
                }
            }

            if (ind == -1)
            {
                Console.WriteLine("No positive values in the array.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"The last positive value is {last_pos}; index: {ind}");
            Console.WriteLine();

            Console.WriteLine("Enter the P value.");
            try_x = double.TryParse(Console.ReadLine(), out p);
            if (!try_x)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst = new double[lst2.Length + 1];

            for (int i = lst.Length - 1; i >= 0; i--)
            {
                if (i > ind + 1)
                {
                    lst[i] = lst2[i - 1];
                }
                else if (i == ind + 1)
                {
                    lst[i] = p;
                }
                else
                {
                    lst[i] = lst2[i];
                }
            }

            Console.WriteLine("Here is your new array:");
            foreach (double val in lst)
            {
                Console.Write($"{val}  ");
            }

            Console.ReadLine();
        #endregion

        task_13_lv2:
            #region task 13 lv2
            Console.WriteLine("Task 13 (level 2)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            max = lst2[0];
            max_ind = 0;

            for (int i = 2; i < lst2.Length; i+= 2)
            {
                if (lst2[i] > max)
                {
                    max = lst2[i];
                    max_ind = i;
                }
            }

            Console.WriteLine($"The max value with even index is {max}; index: {max_ind}");
            Console.WriteLine();

            lst2[max_ind] = max_ind;

            Console.WriteLine("Here is your new array:");

            foreach (double val in lst2)
            {
                Console.Write($"{val}  ");
            }

            Console.ReadLine();
        #endregion

        task_15_lv2:
            #region task 15 lv2
            Console.WriteLine("Task 15 (level 2)");
            Console.WriteLine("Enter the values of the array A.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            double[] lst_a = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst_a[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Enter the values of the array B.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            double[] lst_b = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst_b[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Enter the k value.");
            int k;
            try_x = int.TryParse(Console.ReadLine(), out k);
            if ((!try_x) || (k >= lst_a.Length - 1))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            double[] lst_ab = new double[lst_a.Length + lst_b.Length];
            for (int i = 0; i < lst_ab.Length; i++)
            {
                if (i <= k)
                {
                    lst_ab[i] = lst_a[i];
                }
                else if ((i >= k + 1) && (i < k + 1 + lst_b.Length))
                {
                    lst_ab[i] = lst_b[i - k - 1];
                }
                else
                {
                    lst_ab[i] = lst_a[i - lst_b.Length];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new array:");

            foreach (double val in lst_ab)
            {
                Console.Write($"{val}  ");
            }

            Console.ReadLine();
        #endregion


        task_1_lv3:
            #region task 1 lv3
            Console.WriteLine("Task 1 (level 3)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            lst = new double[lst2.Length];
            max = lst2[0];
            count = 1;

            for (int i = 1; i < lst2.Length; i++)
            {
                if (lst2[i] > max)
                    {
                        max = lst2[i];
                        lst = new double[lst2.Length];
                        lst[0] = i;
                        count = 1;
                    } 
                else if (lst2[i] == max)
                {
                    lst[count] = i;
                    count += 1;
                }
            }

            Console.WriteLine("Here is your new array:");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{lst[i]}  ");
            }

            Console.ReadLine();
        #endregion

        task_5_lv3:
            #region task 5 lv3
            Console.WriteLine("Task 5 (level 3)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            lst = new double[(lst2.Length + 1) / 2];
            for (int i = 0; i < lst2.Length; i ++)
            {
                if (i % 2 == 0)
                {
                    lst[i / 2] = lst2[i];
                }
            }

            Array.Sort(lst);

            Console.WriteLine();
            Console.WriteLine("Here is your new array:");

            for (int i = 0; i < lst2.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{lst[i / 2]}  ");
                }
                else
                {
                    Console.Write($"{lst2[i]}  ");
                }
            }

            Console.ReadLine();
        #endregion

        task_8_lv3:
            #region task 8 lv3
            Console.WriteLine("Task 8 (level 3)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            count = 0;

            lst = new double[lst2.Length];
            for (int i = 0; i < lst2.Length; i++)
            {
                if (lst2[i] < 0)
                {
                    lst[i] = lst2[i];
                    count += 1;
                }
            }

            count -= 1;
            Array.Sort(lst);

            Console.WriteLine();
            Console.WriteLine("Here is your new array:");

            for (int i = 0; i < lst2.Length; i++)
            {
                if (lst2[i] < 0)
                {
                    Console.Write($"{lst[count]}  ");
                    count -= 1;
                }
                else
                {
                    Console.Write($"{lst2[i]}  ");
                }
            }

            Console.ReadLine();
        #endregion

        task_9_lv3:
            #region task 9 lv3
            Console.WriteLine("Task 9 (level 3)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            int max_len = 1, cur_len = 1;
            
            for (int i = 1; i < lst2.Length; i++)
            {
                if (lst2[i] > lst2[i - 1])
                {
                    cur_len += 1;
                    if (cur_len > max_len)
                    {
                        max_len = cur_len;
                    }
                }
                else
                {
                    cur_len = 1;
                }
            }

            cur_len = 1;

            for (int i = 1; i < lst2.Length; i++)
            {
                if (lst2[i] < lst2[i - 1])
                {
                    cur_len += 1;
                    if (cur_len > max_len)
                    {
                        max_len = cur_len;
                    }
                }
                else
                {
                    cur_len = 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The max length is {max_len}.");

            Console.ReadLine();
        #endregion

        task_12_lv3:
            #region task 12 lv3
            Console.WriteLine("Task 12 (level 3)");
            Console.WriteLine("Enter the values of the array (length = 12).");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length != 12)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            count = 0;
            foreach (double val in lst2)
            {
                if (val < 0)
                {
                    count++;
                }
            }

            lst = new double[lst2.Length - count];
            count = 0;

            for (int i = 0; i < lst2.Length; i++)
            {
                if (lst2[i] >= 0)
                {
                    lst[count] = lst2[i];
                    count += 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new array:");

            foreach (double val in lst)
            {
                Console.Write($"{val}  ");
            }

            Console.ReadLine();
        #endregion

        task_13_lv3:
            #region task 13 lv3
            Console.WriteLine("Task 13 (level 3)");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            count = 0;

            lst = new double[lst2.Length];
            bool in_lst;

            foreach (double val in lst2)
            {
                in_lst = false;
                foreach (double val2 in lst)
                {
                    if (val2 == val)
                    {
                        in_lst = true;
                        break;
                    }
                }

                if (!in_lst)
                {
                    lst[count] = val;
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new array:");

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{lst[i]}  ");
            }

            Console.ReadLine();
            #endregion

        alg_11:
            #region alg 11
            Console.WriteLine("Algorithm 11");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            Array.Sort(lst2);

            Console.WriteLine("Enter x value.");
            try_x = double.TryParse(Console.ReadLine(), out x);

            if (!try_x)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            int L = 0, R = lst2.Length - 1, m = -1;
            while (R - L > 1)
            {
                m = (L + R) / 2;
                if (lst2[m] == x)
                {
                    Console.WriteLine();
                    Console.WriteLine($"index of x value in the array is {m}.");
                    Console.ReadLine();
                    return;
                }
                else if (lst2[m] > x)
                {
                    R = m;
                }
                else
                {
                    L = m;
                }
            }

            Console.WriteLine();
            Console.WriteLine("X is not in the array.");
            Console.ReadLine();
            return;
            #endregion

        alg_12:
            #region alg 12
            Console.WriteLine("Algorithm 12");
            Console.WriteLine("Enter the values of the array A.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            double[] a = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out a[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Enter the values of the array B.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            double[] b = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out b[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            double[] c = new double[a.Length + b.Length];

            int min_length = Math.Min(a.Length, b.Length);

            for (int i = 0; i < min_length; i++)
            {
                c[2 * i] = a[i];
                c[2 * i + 1] = b[i];
            }

            int cur_ind;

            if (a.Length != b.Length)
            {
                cur_ind = min_length * 2;
                if (a.Length > b.Length)
                {
                    for (int i = min_length; i < a.Length; i++)
                    {
                        c[cur_ind] = a[i];
                        cur_ind++;
                    }
                }
                else
                {
                    for (int i = min_length; i < b.Length; i++)
                    {
                        c[cur_ind] = b[i];
                        cur_ind++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new array:");

            foreach (double val in c)
            {
                Console.Write($"{val}  ");
            }

            Console.ReadLine();
        #endregion

        alg_13:
            #region alg 13
            Console.WriteLine("Algorithm 13");
            Console.WriteLine("Enter the values of the array A.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            a = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out a[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Enter the values of the array B.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            b = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out b[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            Array.Sort(a);
            Array.Sort(b);

            c = new double[a.Length + b.Length];

            for (int i = 0; i < c.Length; i++)
            {
                if (i < a.Length)
                {
                    c[i] = a[i];
                }
                else
                {
                    c[i] = b[i - a.Length];
                }
            }

            Array.Sort(c);

            Console.WriteLine();
            Console.WriteLine("Here is your new array:");

            foreach (double val in c)
            {
                Console.Write($"{val}  ");
            }

            Console.ReadLine();
        #endregion

        alg_14:
            #region alg 14
            Console.WriteLine("Algorithm 14");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            for (int i = 0; i < lst2.Length / 2; i++)
            {
                double temp = lst2[i];
                lst2[i] = lst2[lst2.Length - i - 1];
                lst2[lst2.Length - i - 1] = temp;
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new array:");

            foreach (double val in lst2)
            {
                Console.Write($"{val}  ");
            }

            Console.ReadLine();
            return;
        #endregion

        alg_15:
            #region alg 15
            Console.WriteLine("Algorithm 15");
            Console.WriteLine("Enter the values of the array.");
            Console.WriteLine("Format: a b c d...");

            input = Console.ReadLine();
            lst1 = input.Split();
            if (lst1.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            lst2 = new double[lst1.Length];
            for (int i = 0; i < lst1.Length; i++)
            {
                try_x = double.TryParse(lst1[i], out lst2[i]);
                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }
            }

            lst = new double[lst2.Length];

            Console.WriteLine("Enter n value.");
            int n;
            try_x = int.TryParse(Console.ReadLine(), out n);

            if (!try_x)
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            cur_ind = 0;
            for (int i = lst2.Length - (n % lst2.Length); i < lst2.Length; i++)
            {
                lst[cur_ind] = lst2[i];
                cur_ind++;
            }

            for (int i = 0; i < lst2.Length - (n % lst2.Length); i++)
            {
                lst[cur_ind] = lst2[i];
                cur_ind++;
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new array:");

            foreach (double val in lst)
            {
                Console.Write($"{val}  ");
            }

            Console.ReadLine();
            return;
            #endregion
        }
    }
}
