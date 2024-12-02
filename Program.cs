using System;

namespace Day04_assign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*int[] arr1 = new int[5];
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int[] arr3 = new int[] { 6, 7, 8, 9, 10 };

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i + 1;
                Console.WriteLine($"arr1[{i}] = {arr1[i]}");
            }*/
            #endregion

            #region Q2
            /* 
                int[] arr1 = { 1, 2, 3 };
                int[] arr2 = arr1; 

                arr2[0] = 10;
                Console.WriteLine($"arr1[0]: {arr1[0]}");

                int[] arr3 = (int[])arr1.Clone(); 
                arr3[1] = 20; // Does not affect arr1
                Console.WriteLine($"arr1[1]: {arr1[1]}");
             */
            #endregion

            #region Q3
            int[,] grades = new int[3, 3];
            Console.WriteLine("Enter grades for 3 students (3 subjects each):");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Student {i + 1}, Subject {j + 1}: ");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nGrades:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{grades[i, j]} ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Q4
            int[] arr = { 5, 2, 8, 1, 9 };
            Array.Sort(arr);
            Console.WriteLine("After Sort: " + string.Join(", ", arr));
            Array.Reverse(arr);
            Console.WriteLine("After Reverse: " + string.Join(", ", arr));
            Console.WriteLine("Index of 8: " + Array.IndexOf(arr, 8));
            int[] copy = new int[5];
            Array.Copy(arr, copy, arr.Length);
            Console.WriteLine("Copied Array: " + string.Join(", ", copy));
            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine("After Clear: " + string.Join(", ", arr));
            #endregion

            #region Q5
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Using for loop:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Using foreach loop:");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Using while loop in reverse order:");
            int index = arr.Length - 1;
            while (index >= 0)
            {
                Console.WriteLine(arr[index]);
                index--;
            }
            #endregion

            #region Q6
            int number;
            do
            {
                Console.Write("Enter a positive odd number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0 && number % 2 != 0)
                {
                    Console.WriteLine($"You entered: {number}");
                    break;
                }
                Console.WriteLine("Invalid input. Try again.");
            } while (true);
            #endregion

            #region Q7
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Matrix format:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
            #endregion

            #region Q8
            Console.Write("Enter a month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            if (month == 1) Console.WriteLine("January");
            else if (month == 2) Console.WriteLine("February");
            else Console.WriteLine("Invalid month");

            switch (month)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("February"); break;
                default: Console.WriteLine("Invalid month"); break;
            }
            #endregion

            #region Q9
            int[] arr = { 10, 20, 30, 40, 50 };
            Array.Sort(arr);
            Console.WriteLine("After Sort: " + string.Join(", ", arr));
            int value = 30;
            Console.WriteLine($"Index of {value}: " + Array.IndexOf(arr, value));
            Console.WriteLine($"Last Index of {value}: " + Array.LastIndexOf(arr, value));
            #endregion

            #region Q10
            int[] arr = { 1, 2, 3, 4, 5 };

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum using for: " + sum);

            sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine("Sum using foreach: " + sum); 
            #endregion

        }
    }
}
