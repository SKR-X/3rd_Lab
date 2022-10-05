using System;
using System.Collections.Generic;

namespace _3rd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region First level
            Console.WriteLine("--- Level I ----------------------------------\n");

            #region Task 6
            Console.WriteLine("Task 6:\n");

            int[] vectorCoordinates = new int[] { 2, 6, 8, 1, 3 };
            double vectorLength = vectorCoordinates[0] * vectorCoordinates[0]
                + vectorCoordinates[1] * vectorCoordinates[1]
                + vectorCoordinates[2] * vectorCoordinates[2]
                + vectorCoordinates[3] * vectorCoordinates[3]
                + vectorCoordinates[4] * vectorCoordinates[4];
            vectorLength = Math.Sqrt(vectorLength);

            Console.WriteLine("Vector coordinates: ({0}, {1}, {2}, {3}, {4})",
                vectorCoordinates[0],
                vectorCoordinates[1],
                vectorCoordinates[2],
                vectorCoordinates[3],
                vectorCoordinates[4]);
            Console.WriteLine($"Vector length: {Math.Round(vectorLength, 3)}");
            #endregion

            #region Task 10
            Console.WriteLine("\nTask 10:\n");

            double p = 0, q = 0;
            int[] numbers = new int[10] { 14, 113, 7, -2, 39, -78, 0, 11, 5, 8 };
            int elementsBetween = 0;

            Console.Write("Initial array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.Write("Enter P: ");
            if (!double.TryParse(Console.ReadLine(), out p))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }

            Console.Write("Enter Q: ");
            if (!double.TryParse(Console.ReadLine(), out q))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (p >= q)
            {
                Console.WriteLine("P should be less than Q!");
                return;
            }

            foreach (var number in numbers)
            {
                if (number >= p && number <= q)
                    elementsBetween++;
            }

            Console.WriteLine($"Elements between: {elementsBetween}");
            #endregion

            #region Task 11
            Console.WriteLine("\nTask 11:\n");

            numbers = new int[10] { -55, -44, -33, -22, -11, 11, 22, 33, 44, 55 };
            int[] positiveNumbers = null;

            int positiveNumbersCount = 0;
            int index = 0;

            foreach (var number in numbers)
            {
                if (number >= 0)
                    positiveNumbersCount++;
            }

            positiveNumbers = new int[positiveNumbersCount];
            foreach (var number in numbers)
            {
                if (number >= 0)
                {
                    positiveNumbers[index] = number;
                    index++;
                }
            }

            Console.WriteLine("Initial array:\t{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}",
                numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6],
                numbers[7], numbers[8], numbers[9]);
            Console.WriteLine("Result array:\t{0}, {1}, {2}, {3}, {4}",
                positiveNumbers[0], positiveNumbers[1], positiveNumbers[2], positiveNumbers[3], positiveNumbers[4]);
            #endregion

            #region Task 12
            Console.WriteLine("\nTask 12:\n");

            numbers = new int[8] { -17, 6, 0, -23, 4, 55, -160, 78 };
            int lastNegativeNumberIndex = -1;

            Console.Write("Initial array:\t");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{numbers[i]} ");
                if (numbers[i] < 0)
                    lastNegativeNumberIndex = i;
            }

            Console.WriteLine();

            if (lastNegativeNumberIndex == -1)
                Console.WriteLine("There's no negative elements in the array");
            else
                Console.WriteLine($"Last negative element: {numbers[lastNegativeNumberIndex]} (with number {lastNegativeNumberIndex + 1})");
            #endregion

            #region Task 13
            Console.WriteLine("\nTask 13:\n");

            numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] oddIndexes = new int[5];
            int[] evenIndexes = new int[5];

            int oddIndex = 0;
            int evenIndex = 0;

            bool isOdd = true;

            foreach (var number in numbers)
            {
                if (isOdd)
                {
                    oddIndexes[oddIndex] = number;
                    oddIndex++;
                }
                else
                {
                    evenIndexes[evenIndex] = number;
                    evenIndex++;
                }

                isOdd = !isOdd;
            }

            Console.Write("Initial array:\t ");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.Write("Odd indexes: ");
            foreach (var odd in oddIndexes)
                Console.Write($"{odd} ");
            Console.WriteLine();

            Console.Write("Even indexes: ");
            foreach (var even in evenIndexes)
                Console.Write($"{even} ");
            Console.WriteLine();
            #endregion

            #endregion

            #region Second level
            Console.WriteLine("\n--- Level II ----------------------------------");

            #region Task 5
            Console.WriteLine("\nTask 5:\n");

            int n = 0;
            int min, max = 0;
            int minIndex = 0, maxIndex = 0;
            int[] negativeNumbersBetween;
            Random random = new Random();

            Console.Write("Enter an array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            numbers = new int[n];
            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 6);
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();

            min = numbers[0];
            max = numbers[0];

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }

            // Get new array length
            n = Math.Abs(maxIndex - minIndex) - 1;
            if (n <= 0)
                Console.WriteLine("There's no elements between min and max");
            else
            {
                negativeNumbersBetween = new int[n];
                Console.Write("Result array:\t");

                // Swap values to start from beginning
                if (minIndex > maxIndex)
                {
                    maxIndex += minIndex;
                    minIndex = maxIndex - minIndex;
                    maxIndex = maxIndex - minIndex;
                }

                int k = 0;
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    if (numbers[i] < 0)
                    {
                        negativeNumbersBetween[k] = numbers[i];
                        Console.Write($"{negativeNumbersBetween[k]} ");
                        k++;
                    }
                }

                Console.WriteLine();
            }
            #endregion

            #region Task 6
            Console.WriteLine("\nTask 6:\n");

            int P = 999;
            double avg = 0;
            double currentDistance = 0; // Between average value and current array element
            double minDistance = 0;
            int minDistanceIndex = 0;

            Console.Write("Enter an array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            numbers = new int[n];
            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine($"\nP: {P}");

            foreach (var number in numbers)
                avg += number;
            avg /= n;

            Console.WriteLine($"Average value: {Math.Round(avg, 3)}");

            minDistance = Math.Abs(avg - numbers[0]);
            minDistanceIndex = 0;

            // Finding the nearest element to the average value
            for (int i = 1; i < n; i++)
            {
                currentDistance = Math.Abs(avg - numbers[i]);
                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                    minDistanceIndex = i;
                }
            }

            if (minDistanceIndex == n - 1)
                numbers[0] = P;
            else
                numbers[minDistanceIndex + 1] = P;

            Console.Write("Result array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            #endregion

            #region Task 9
            Console.WriteLine("\nTask 9:\n");

            // Ask for array length
            Console.Write("Enter an array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            // Initialize array
            numbers = new int[n];
            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            min = numbers[0];
            max = numbers[0];

            // Find min and max elements
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }

            // Swap values to start from beginning
            if (minIndex > maxIndex)
            {
                maxIndex += minIndex;
                minIndex = maxIndex - minIndex;
                maxIndex = maxIndex - minIndex;
            }

            // Find average value
            avg = 0;
            elementsBetween = 0;

            for (int i = minIndex + 1; i < maxIndex; i++)
            {
                avg += numbers[i];
                elementsBetween++;
            }

            if (elementsBetween == 0)
                Console.WriteLine("There's no elements between");
            else
            {
                avg /= elementsBetween;
                Console.WriteLine($"Average value: {Math.Round(avg, 6)}");
            }

            #endregion

            #region Task 10
            Console.WriteLine("\nTask 10:\n");

            int positiveMin;
            int positiveMinIndex = 0;
            int[] reducedArray;

            // Ask for array length
            Console.Write("Enter an array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            // Initialize array
            numbers = new int[n];
            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            positiveMin = numbers[0];

            // Find positive minimum
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] >= 0)
                {
                    if (numbers[i] < positiveMin || positiveMin < 0)
                    {
                        positiveMin = numbers[i];
                        positiveMinIndex = i;
                    }
                }
            }

            if (positiveMin < 0)
                Console.WriteLine("There's no positive elements in the array");
            else
            {
                reducedArray = new int[n - 1];
                int k = 0;

                Console.Write("Result array:\t");
                for (int i = 0; i < n; i++)
                {
                    if (i == positiveMinIndex)
                        continue;
                    reducedArray[k] = numbers[i];
                    Console.Write($"{reducedArray[k]} ");
                    k++;
                }
                Console.WriteLine();
            }

            #endregion

            #region Task 11
            Console.WriteLine("\nTask 11:\n");

            int lastPositiveIndex = 0;

            // Ask for array length
            Console.Write("Enter an array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            // Initialize array
            numbers = new int[n];
            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine($"\nP:{P}");

            // Find last positive element
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] >= 0)
                    lastPositiveIndex = i;
            }

            if (lastPositiveIndex + 1 == n)
                numbers[0] = P;
            else
                numbers[lastPositiveIndex + 1] = P;

            Console.Write("Result array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            #endregion

            #region Task 13
            Console.WriteLine("\nTask 13:\n");

            // Ask for array length
            Console.Write("Enter an array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            // Initialize array
            numbers = new int[n];
            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            max = numbers[2];
            maxIndex = 2;

            for (int i = 0; i < n; i += 2)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }
            }

            numbers[maxIndex] = maxIndex;

            Console.Write("Result array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            #endregion

            #region Task 15
            Console.WriteLine("\nTask 15:\n");

            int kIndex = 0, m = 0;
            int[] arrayBetween;
            int[] resultArray;

            // Ask for array length
            Console.Write("Enter first array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            Console.Write("Enter second array length: ");
            if (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (m <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            Console.Write("Enter k [0 < k <= n]: ");
            if (!int.TryParse(Console.ReadLine(), out kIndex))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (kIndex > n || kIndex < 0)
            {
                Console.WriteLine("K value must be not negative and less than n");
                return;
            }

            // Initialize array
            numbers = new int[n];
            Console.Write("Array A:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            arrayBetween = new int[m];
            Console.Write("Array B:\t");
            for (int i = 0; i < m; i++)
            {
                arrayBetween[i] = random.Next(-10, 11);
                Console.Write($"{arrayBetween[i]} ");
            }
            Console.WriteLine();

            resultArray = new int[n + m];

            int resultArrayIndex = 0;
            int firstArrayIndex = 0;

            Console.Write("Result array:\t");
            // Insert first half of array
            for (; firstArrayIndex < kIndex; firstArrayIndex++)
            {
                resultArray[resultArrayIndex] = numbers[firstArrayIndex];
                Console.Write($"{resultArray[resultArrayIndex]} ");

                resultArrayIndex++;
            }

            // Insert array between
            for (int j = 0; j < m; j++)
            {
                resultArray[resultArrayIndex] = arrayBetween[j];
                Console.Write($"{resultArray[resultArrayIndex]} ");
                resultArrayIndex++;

            }

            // Insert second half of array
            for (; firstArrayIndex < n; firstArrayIndex++)
            {
                resultArray[resultArrayIndex] = numbers[firstArrayIndex];
                Console.Write($"{resultArray[resultArrayIndex]} ");
                resultArrayIndex++;
            }

            Console.WriteLine();

            #endregion

            #endregion

            #region Third level
            Console.WriteLine("\n--- Level III ----------------------------------");

            #region Task 1
            Console.WriteLine("\nTask 1:\n");

            List<int> indexesOfMaximums;

            // Ask for array length
            Console.Write("Enter an array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            // Initialize array
            numbers = new int[n];
            indexesOfMaximums = new List<int>();

            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            // Find all maximums
            max = numbers[0];
            indexesOfMaximums.Add(0);

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] == max)
                    indexesOfMaximums.Add(i);
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    indexesOfMaximums.Clear();
                    indexesOfMaximums.Add(i);
                }
            }

            Console.Write("Maximums indexes: ");
            foreach (var number in indexesOfMaximums)
                Console.Write($"{number} ");
            Console.WriteLine();

            #endregion

            #region Task 5
            Console.WriteLine("\nTask 5:\n");

            // Ask for array length
            Console.Write("Enter an array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            // Initialize array
            numbers = new int[n];

            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            // Sort even elements of the array
            for (int i = 0; i < n - 1; i += 2)
            {
                min = numbers[i];
                minIndex = i;

                for (int j = i + 2; j < n; j += 2)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                        minIndex = j;
                    }
                }

                numbers[minIndex] = numbers[i];
                numbers[i] = min;
            }

            Console.Write("Result array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.Write("Even elements:\t");
            for (int i = 0; i < n; i += 2)
                Console.Write($"{numbers[i]} ");
            Console.WriteLine();
            #endregion

            #region Task 8
            Console.WriteLine("\nTask 8:\n");

            // Ask for array length
            Console.Write("Enter an array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            // Initialize array
            numbers = new int[n];

            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            // Sort negative elements of the array
            for (int i = 0; i < n - 1; i++)
            {
                if (numbers[i] < 0)
                {
                    max = numbers[i];
                    maxIndex = i;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (numbers[j] < 0 && numbers[j] > max)
                        {
                            max = numbers[j];
                            maxIndex = j;
                        }
                    }

                    numbers[maxIndex] = numbers[i];
                    numbers[i] = max;
                }
            }

            Console.Write("Result array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.Write("Negative elements: ");
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < 0)
                    Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            #endregion

            #region Task 9
            Console.WriteLine("\nTask 9:\n");

            int currentSequenceLength = 1;
            int maxSequenceLength = 1;

            // Step of arithmetic progression
            int step = 0;
            // Ratio of geometric progression
            double ratio = 0;

            // Tests
            numbers = new int[] { 1, 2, 5, 9, 4, 2, -5, -8, -11, 3 };
            
            n = numbers.Length;

            if (n == 0)
            {
                Console.WriteLine("Array can not be empty!");
                return;
            }

            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
                Console.Write($"{numbers[i]} ");
            Console.WriteLine();

            // Find max length of sequences
            if (n > 1)
            {
                int previousStep = numbers[1] - numbers[0];
                double previousRatio = (double)numbers[1] / numbers[0];
                currentSequenceLength++;

                // -1 -> arithmetic, 1 -> geometric, 0 -> any
                int sequenceKind = 0;

                for (int i = 1; i < n - 1;)
                {
                    int currentNumber = numbers[i];
                    int nextNumber = numbers[i + 1];

                    step = nextNumber - currentNumber;
                    ratio = (double)nextNumber / currentNumber;

                    if (step == previousStep && ratio == previousRatio)
                    {
                        sequenceKind = 0;
                        currentSequenceLength++;
                    }
                    else if (step == previousStep)
                    {
                        if (sequenceKind == 1)
                        {
                            sequenceKind = -1;
                            currentSequenceLength = 1;
                        }
                        else if (sequenceKind == 0)
                            sequenceKind = -1;

                        currentSequenceLength++;
                    }
                    else if (ratio == previousRatio)
                    {
                        if (sequenceKind == -1)
                        {
                            sequenceKind = 1;
                            currentSequenceLength = 1;
                        }
                        else if (sequenceKind == 0)
                            sequenceKind = 1;

                        currentSequenceLength++;
                    }
                    else
                    {
                        if (currentSequenceLength > maxSequenceLength)
                            maxSequenceLength = currentSequenceLength;

                        previousStep = step;
                        previousRatio = ratio;
                        currentSequenceLength = 1;
                        continue;
                    }

                    if (currentSequenceLength > maxSequenceLength)
                        maxSequenceLength = currentSequenceLength;

                    previousStep = step;
                    previousRatio = ratio;
                    i++;
                }
            }

            Console.WriteLine($"Max sequence length: {maxSequenceLength}");
            #endregion

            #region Task 12
            Console.WriteLine("\nTask 12:\n");

            // Ask for array length
            Console.Write("Enter an array length: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Array length must be greater than zero!");
                return;
            }

            // Initialize array
            numbers = new int[n];

            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-10, 11);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            // Delete negative elements
            Queue<int> positiveNums = new Queue<int>();
            foreach (var number in numbers)
            {
                if (number > 0)
                    positiveNums.Enqueue(number);
            }

            Console.Write("Result array:\t");
            foreach (var number in positiveNums)
                Console.Write($"{number} ");
            Console.WriteLine();
            #endregion

            #region Task 13
            Console.WriteLine("\nTask 13:\n");

            // Initialize array
            numbers = new int[] { 10, 3, 3, 6, 3, 6 };
            n = numbers.Length;

            Console.Write("Initial array:\t");
            for (int i = 0; i < n; i++)
                Console.Write($"{numbers[i]} ");
            Console.WriteLine();

            // Delete equal elements
            Queue<int> uniqueNumbers = new Queue<int>(); 
            foreach (var number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Enqueue(number);
            }

            Console.Write("Result array:\t");
            foreach (var number in uniqueNumbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            #endregion

            #endregion

            #region Extra alorithms
            Console.WriteLine("\n--- Extra alorithms ----------------------------------");

            #region Binary search
            Console.WriteLine("\nBinary search:\n");

            int x = 0;
            int i1 = 0, i2 = 0;
            int midIndex = 0;

            // Initialize the array
            numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Initial array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.Write("Enter x: ");
            if (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }

            i2 = numbers.Length - 1;

            while (true)
            {
                midIndex = (i1 + i2) / 2;

                if (i2 < i1)
                {
                    Console.WriteLine("The array doesn't contain x");
                    break;
                }

                if (x == numbers[midIndex])
                {
                    Console.WriteLine($"x was found at index {midIndex}");
                    break;
                }
                else if (x < numbers[midIndex])
                {
                    i2 = midIndex - 1;
                    continue;
                }
                else if (x > numbers[midIndex])
                {
                    i1 = midIndex + 1;
                    continue;
                }
            }


            #endregion

            #region Arrays union
            Console.WriteLine("\nArrays union:\n");

            // Initialize arrays
            int[] firstArray = new int[] { 1, 3, 5 };
            int[] secondArray = new int[] { 2, 4, 6, 8, 10 };

            Console.Write("First array:\t");
            foreach (var number in firstArray)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.Write("Second array:\t");
            foreach (var number in secondArray)
                Console.Write($"{number} ");
            Console.WriteLine();

            resultArray = new int[firstArray.Length + secondArray.Length];

            // Unite the arrays
            if (firstArray.Length >= secondArray.Length)
                n = firstArray.Length;
            else
                n = secondArray.Length;

            index = 0;

            for (int i = 0; i < n; i++)
            {
                if (i < firstArray.Length)
                {
                    resultArray[index] = firstArray[i];
                    index++;
                }

                if (i < secondArray.Length)
                {
                    resultArray[index] = secondArray[i];
                    index++;
                }
            }

            Console.Write("Result array:\t");
            foreach (var number in resultArray)
                Console.Write($"{number} ");
            Console.WriteLine();
            #endregion

            #region Sorted arrays union
            Console.WriteLine("\nSorted arrays union:\n");

            // Initialize the arrays
            firstArray = new int[] { 55, 44, 33, 22, 11 };
            secondArray = new int[] { 39, 37, 28 };

            Console.Write("First array:\t");
            foreach (var number in firstArray)
                Console.Write($"{number} ");
            Console.WriteLine();

            Console.Write("Second array:\t");
            foreach (var number in secondArray)
                Console.Write($"{number} ");
            Console.WriteLine();

            resultArray = new int[firstArray.Length + secondArray.Length];

            // Unite sorted arrays
            i1 = i2 = 0;
            index = 0;

            bool continueCycle = true;

            while (continueCycle)
            {
                while (firstArray[i1] >= secondArray[i2])
                {
                    resultArray[index] = firstArray[i1];
                    i1++;
                    index++;

                    if (i1 >= firstArray.Length)
                    {
                        continueCycle = false;
                        break;
                    }
                }

                if (!continueCycle)
                    break;

                while (secondArray[i2] >= firstArray[i1])
                {
                    resultArray[index] = secondArray[i2];
                    i2++;
                    index++;

                    if (i2 >= secondArray.Length)
                    {
                        continueCycle = false;
                        break;
                    }
                }
            }

            if (firstArray.Length <= secondArray.Length)
            {
                for (; i2 < secondArray.Length; i2++)
                {
                    resultArray[index] = secondArray[i2];
                    index++;
                }
            }
            else
            {
                for (; i1 < firstArray.Length; i1++)
                {
                    resultArray[index] = firstArray[i1];
                    index++;
                }
            }

            Console.Write("Result array:\t");
            foreach (var number in resultArray)
                Console.Write($"{number} ");
            Console.WriteLine();
            #endregion

            #region Array inversion
            Console.WriteLine("\nArray inversion:\n");

            // Initialize the array
            numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            n = numbers.Length;

            Console.Write("Initial array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            // Invert the array
            int swapNumber = 0;

            for (int i = 0; i < n / 2; i++)
            {
                swapNumber = numbers[n - (i + 1)];
                numbers[n - (i + 1)] = numbers[i];
                numbers[i] = swapNumber;
            }

            Console.Write("Result array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();
            #endregion

            #region Cycle shift I
            Console.WriteLine("\nCycle shift I:\n");

            m = 0;

            // Initialize the array
            numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.Write("Initial array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            // Ask for m value
            Console.Write("Enter m: ");

            if (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (m < 0)
            {
                Console.WriteLine("Value of m can't be negative!");
                return;
            }

            // Normalize cycle shift
            if (m > numbers.Length)
                m = m % numbers.Length;

            int[] cycleShiftedNumbers = new int[m];
            index = cycleShiftedNumbers.Length - 1;
            int backwardIndex;

            for (backwardIndex = numbers.Length - 1; backwardIndex >= numbers.Length - m; backwardIndex--)
            {
                cycleShiftedNumbers[index] = numbers[backwardIndex];
                index--;
            }

            for (; backwardIndex >= 0; backwardIndex--)
                numbers[backwardIndex + m] = numbers[backwardIndex];

            for (int i = 0; i < cycleShiftedNumbers.Length; i++)
                numbers[i] = cycleShiftedNumbers[i];

            Console.Write("Result array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();
            #endregion

            #region Cycle shift II
            Console.WriteLine("\nCycle shift II:\n");

            m = 0;

            // Initialize the array
            numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.Write("Initial array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();

            // Ask for m value
            Console.Write("Enter m: ");

            if (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (m < 0)
            {
                Console.WriteLine("Value of m can't be negative!");
                return;
            }

            // Normalize cycle shift
            if (m > numbers.Length)
                m = m % numbers.Length;

            int shiftedNumber = 0;
            for (int i = 0; i < m; i++)
            {
                shiftedNumber = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 2; j >= 0; j--)
                    numbers[j + 1] = numbers[j];
                numbers[0] = shiftedNumber;
            }

            Console.Write("Result array:\t");
            foreach (var number in numbers)
                Console.Write($"{number} ");
            Console.WriteLine();
            #endregion

            #endregion
        }
    }
}
