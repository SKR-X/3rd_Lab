using System;

namespace _3_Lab {
    class Program {
        static void Main(string[] args) {
            // Support Function --------------

            static double[] inputDoubleArray(int preferrablyLength = 0) {
                Console.WriteLine("Enter nums with spaces between, example: 3 5 2 -1 3 1");

                string[] strNums = Console.ReadLine().Split();
                double[] nums = new double[strNums.Length];

                for (int i = 0; i < strNums.Length; i++) {
                    if (!double.TryParse(strNums[i], out nums[i])) {
                        Console.WriteLine("One of the elements is not a number");
                        return null;
                    }
                }

                if (nums.Length != preferrablyLength && preferrablyLength != 0) {
                    Console.WriteLine();
                }

                return nums;
            }

            static void printAnswer(string task, double[] result) {
                Console.WriteLine($"Task {task} answer:");
                Console.WriteLine(String.Join(" ", result));
                return;
            }

            static void checkLength<T>(T[] nums, int preferrablyLength) {
                if (nums.Length != preferrablyLength) {
                    Console.WriteLine($"The number of elements is different from {preferrablyLength}");
                }
            }

            // Level 1 -----------------------

            static void task_1_6() {
                double[] nums = inputDoubleArray();

                if (nums == null) {
                    return;
                }

                checkLength(nums, 6);

                double suma = nums.Sum() * 1.0;

                for (int i = 0; i < nums.Length; i++) {
                    nums[i] = Math.Round(nums[i] / suma, 2);
                }

                printAnswer("1.6", nums);
            }

            static void task_1_10() {
                double[] nums = inputDoubleArray();
                int count = 0;

                if (nums == null) {
                    return;
                }


                checkLength(nums, 6);


                Console.WriteLine("Enter p and q with space between, example: 11 44");
                string[] strNums = Console.ReadLine().Split();

                if (strNums.Length != 2) {
                    Console.WriteLine();
                    return;
                }

                if (!double.TryParse(strNums[0], out double p)) {
                    Console.WriteLine();
                    return;
                }

                if (!double.TryParse(strNums[1], out double q)) {
                    Console.WriteLine();
                    return;
                }

                for (int i = 0; i < nums.Length; i++) {
                    if (p < nums[i] && nums[i] < q) {
                        count++;
                    }
                    
                }

                Console.WriteLine($"Task 1.10 answer:");
                Console.WriteLine($"{count} elements between p and q");

            }

            static void task_1_11() {
                double[] nums = inputDoubleArray(10);
                int[] posInd = new int[nums.Length];
                int posSize = 0;

                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] >= 0) {
                        posInd[posSize] = i;
                        posSize++;
                    }
                }

                double[] answer = new double[posSize];

                for (int i = 0; i < posSize; i++) {
                    answer[i] = nums[posInd[i]];
                }

                printAnswer("1.11", answer);
            }

            static void task_1_12() {
                double[] nums = inputDoubleArray();

                if (nums == null) {
                    return;
                }

                checkLength(nums, 8);

                int ind = 0;
                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] < 0) {
                        ind = i;
                    }
                }


                Console.WriteLine($"Task 1.12 answer:");
                Console.WriteLine($"Value: {nums[ind]}, Number: {ind + 1}");
            }

            static void task_1_13() {
                double[] nums = inputDoubleArray();

                if (nums == null) {
                    return;
                }

                checkLength(nums, 10);

                double[] oddNums;
                if (nums.Length % 2 == 0) {
                    oddNums = new double[nums.Length / 2];
                } else {
                    oddNums = new double[nums.Length / 2 + 1];
                }
                double[] evenNums = new double[nums.Length / 2];

                for (int i = 0; i < nums.Length; i++) {
                    if ((i % 2) == 1) {
                        evenNums[i / 2] = nums[i];
                    } else {
                        oddNums[i / 2] = nums[i];
                    }
                }

                Console.WriteLine($"Task 1.13 answer:");
                Console.WriteLine($"Odd positions nums: {String.Join(" ", oddNums)}");
                Console.WriteLine($"Even positions nums: {String.Join(" ", evenNums)}");
            }


            // Level 2 -----------------------
            
            static void task_2_5() {
                double[] nums = inputDoubleArray();
                int[] negInd = new int[nums.Length];
                int negSize = 0;

                if (nums == null) {
                    return;
                }

                double max = nums[0], min = nums[0];
                int maxInd = 0, minInd = 0;

                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] > max) {
                        maxInd = i;
                        max = nums[i];
                    }
                    if (nums[i] < min) {
                        minInd = i;
                        min = nums[i];
                    }
                }

                for (int i = Math.Min(minInd, maxInd); i < Math.Max(minInd, maxInd); i++) {
                    if (nums[i] < 0) {
                        negInd[negSize] = i;
                        negSize++;
                    }
                }

                double[] answer = new double[negSize];

                for (int i = 0; i < negSize; i++) {
                    answer[i] = nums[negInd[i]];
                }

                printAnswer("2.5", answer);

            }


            static void task_2_6() {
                double[] nums = inputDoubleArray();

                if (!double.TryParse(Console.ReadLine(), out double p)) {
                    return;
                }

                double average = nums.Average();

                int ind = 0;
                double diff = Math.Abs(average - nums[0]);
                for (int i = 0; i < nums.Length; i++) {
                    if (diff > Math.Abs(average - nums[i])) {
                        diff = Math.Abs(average - nums[i]);
                        ind = i;
                    }
                }

                Array.Resize<double>(ref nums, nums.Length + 1);

                for (int i = nums.Length - 1; i > ind; i--) {
                    nums[i] = nums[i - 1];
                }

                nums[ind + 1] = p;

                printAnswer("2.6", nums);
            }

            static void task_2_9() {
                double[] nums = inputDoubleArray();

                double max = nums.Max(), min = nums.Min();

                int maxInd = Array.IndexOf(nums, nums.Max());
                int minInd = Array.IndexOf(nums, nums.Min());
                int firstInd = Math.Min(maxInd, minInd);
                int secondInd = Math.Max(minInd, maxInd);

                double sumOfElements = 0;

                for (int i = Math.Min(maxInd, minInd) + 1; i < Math.Max(minInd, maxInd); i++) {
                    sumOfElements += nums[i];
                }

                if (secondInd - firstInd <= 1) {
                    Console.WriteLine(0);
                    return;
                }
                Console.WriteLine(sumOfElements / (secondInd - firstInd - 1));
            }

            static void task_2_10() {
                double[] nums = inputDoubleArray();

                int ind = 0;
                double min = Math.Pow(10, 10);

                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] < min && nums[i] > 0) {
                        min = nums[i];
                        ind = i;
                    }
                }

                double[] result = new double[nums.Length - 1];
                int curInd = 0;
                for (int i = 0; i < nums.Length; i++) {
                    if (i != ind) {
                        result[curInd] = nums[i];
                        curInd++;
                    }
                }
                printAnswer("2.10", result);

            }

            static void task_2_11() {
                double[] nums = inputDoubleArray();

                if (!double.TryParse(Console.ReadLine(), out double p)) {
                    return;
                }
                 

                int ind = 0;
                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] > 0) {
                        ind = i;
                    }
                }

                Array.Resize<double>(ref nums, nums.Length + 1);

                for (int i = nums.Length - 1; i > ind; i--) {
                    nums[i] = nums[i - 1];
                }

                nums[ind + 1] = p;

                printAnswer("2.11", nums);
            }

            static void task_2_13() { 
                double[] nums = inputDoubleArray();

                int ind = 0;
                double max = 0;
                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] > max && nums[i] % 2 == 0) {
                        ind = i;
                        max = nums[i];
                    }
                }

                nums[ind] = ind;
                printAnswer("2.13", nums);
            }

            static void task_2_15() {
                double[] a = inputDoubleArray();
                double[] b = inputDoubleArray();

                if (!int.TryParse(Console.ReadLine(), out int k)) {
                    return;
                }

                Array.Resize<double>(ref a, a.Length + b.Length);
                
                for (int i = a.Length - 1; i > a.Length - b.Length - 1; i--) {
                    a[i] = a[i - b.Length];
                }

                for (int i = 0; i < b.Length; i++) {
                    a[k + i] = b[i];
                }

                printAnswer("2.15", a);
            }


            // Level 3 -----------------------
            
            static void task_3_1() {
                double[] nums = inputDoubleArray();

                double[] answer = new double[nums.Length];
                int ind = 0;
                int answerSize = 0;
                double maxElem = answer[0];

                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] > maxElem) {
                        answer = new double[nums.Length];
                        ind = 1;
                        answer[ind - 1] = i;
                        answerSize = 1;
                        maxElem = nums[i];

                    }else if (nums[i] == maxElem) {
                        answer[ind] = i;
                        answerSize++;
                        ind += 1;
                    }
                }

                printAnswer("3.1", answer);
            }

            static void task_3_5() {
                double[] nums = inputDoubleArray();

                for (int i = 0; i < nums.Length; i += 2) {
                    for (int j = i + 2; j < nums.Length; j += 2) {
                        if (nums[i] > nums[j]) {
                            double temp = nums[i];
                            nums[i]= nums[j];
                            nums[j]= temp;
                        }
                    }
                }

                printAnswer("3.5", nums);
            }

            static void task_3_8() {
                double[] nums = inputDoubleArray();
                int[] negInd = new int[nums.Length];
                int negCurInd = 0;
                int negSize = 0;

                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] < 0) {
                        negInd[negCurInd] = i;
                        negCurInd++;
                        negSize++;
                    }
                }

                for (int i = 0; i < negSize; i++) { 
                    for (int j = i + 1; j < negSize; j++) {
                        if (nums[negInd[i]] < nums[negInd[j]]) {
                            double temp = nums[negInd[i]];
                            nums[negInd[i]] = nums[negInd[j]];
                            nums[negInd[j]] = temp;
                        }
                    }
                }

                printAnswer("3.8", nums);
            }

            static void task_3_9() {
                double[] nums = inputDoubleArray();
                bool isInc = true;

                int maxLen = 0;
                int curLen = 1;

                for (int i = 1; i < nums.Length; i++) {
                    if (nums[i - 1] <= nums[i]) {
                        if (isInc) {
                            curLen++;
                        } else {
                            maxLen = Math.Max(maxLen, curLen);
                            curLen = 2;
                            isInc = true;
                        }
                    } else if(nums[i - 1] >= nums[i]) {
                        if (!isInc) {
                            curLen++;
                        } else {
                            maxLen = Math.Max(maxLen, curLen);
                            curLen = 2;
                            isInc = false;
                        }
                    }
                }


                Console.WriteLine($"Task 3.9 answer:");
                Console.WriteLine(Math.Max(maxLen, curLen));
            }

            static void task_3_12() {
                double[] nums = inputDoubleArray(12);
                int[] posInd = new int[nums.Length];
                int posSize = 0;

                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] >= 0) {
                        posInd[posSize] = i;
                        posSize++;
                    }
                }

                double[] answer = new double[posSize];

                for (int i = 0; i < posSize; i++) {
                    answer[i] = nums[posInd[i]];
                }

                printAnswer("3.12", answer);

            }

            static void task_3_13() {
                double[] nums = inputDoubleArray();
                int[] ansInd = new int[nums.Length];
                int ansSize = 0;

                for (int i = 0; i < nums.Length; i++) {
                    bool flag = true;

                    for (int j = 0; j < i; j++) {
                        if (nums[i] == nums[j]) {
                            flag = false;
                        }
                    }

                    if (flag) {
                        ansInd[ansSize] = i;
                        ansSize++;
                    }                    
                }


                double[] answer = new double[ansSize];
                for (int i = 0; i < ansSize; i++) {
                    answer[i] = nums[ansInd[i]];
                }

                printAnswer("3.13", answer);
            }

            // 11-15 end of theory -----------

            static void task_0_11() {
                double[] nums = inputDoubleArray();
                
                if (!double.TryParse(Console.ReadLine(), out double n)) {
                    return;
                }


                Console.WriteLine($"Task 0.11 answer:");

                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] == n) {
                        Console.WriteLine(i);
                        return;
                    }
                }

                Console.WriteLine(-1);
            }

            static void task_0_12() {
                double[] a = inputDoubleArray();
                double[] b = inputDoubleArray();
                double[] c = new double[a.Length + b.Length];

                for (int i = 0; i < a.Length; i++) {
                    c[2 * i] = a[i];
                    c[2 * i + 1] = b[i];
                }

                printAnswer("0.12", c);
            }

            static void task_0_13() {
                double[] a = inputDoubleArray();
                double[] b = inputDoubleArray();
                int indA = 0, indB = 0;
                double[] c = new double[a.Length + b.Length];

                for (int i = 0; i < c.Length; i++) {
                    if (indA == a.Length) {
                        c[i] = b[indB];
                        indB++;
                        continue;
                    }
                    if (indB == b.Length) {
                        c[i] = a[indA];
                        indA++;
                        continue;
                    }
                    if (a[indA] > b[indB]) {
                        c[i] = a[indA];
                        indA++;
                    } else {
                        c[i] = b[indB];
                        indB++;
                    }
                }

                printAnswer("0.13", c);
            }

            static void task_0_14() {
                double[] nums = inputDoubleArray();

                for (int i = 0; i < nums.Length / 2; i++) {
                    double temp = nums[i];
                    nums[i] = nums[nums.Length - i - 1];
                    nums[nums.Length - i - 1] = temp;
                }

                printAnswer("0.14", nums);
            }

            static void task_0_15() {
                double[] nums = inputDoubleArray();
                double[] answer = new double[nums.Length];
                int curInd = 0;

                if (!int.TryParse(Console.ReadLine(), out int n)) {
                    return;
                }

                for (int i = nums.Length - (n % nums.Length); i < nums.Length; i++) {
                    answer[curInd] = nums[i];
                    curInd++;
                }

                for (int i = 0; i < nums.Length - (n % nums.Length); i++) {
                    answer[curInd] = nums[i];
                    curInd++;
                }

                printAnswer("0.15", answer);

            }


            // -------------------------------

            task_0_15();

        }
    }
}
