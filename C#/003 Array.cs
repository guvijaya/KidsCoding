using System;

namespace CSharp
{
    class ArrayExamples
    {
        public static void Demo()
        {
            // Declaring single dimention array
            int[] x = new int[] { 10, 20, 30, 40, 50 };

            // Using two dimention array
            int[,] arr2D = new int[,] { {1,2,3,4,5},
                                        {2,4,6,8,10},
                                        {3,9,12,15,18}
                                      };

            int[,] a2 = new int[2, 3];

            // Accessing individual elements
            a2[0, 0] = 10;
            a2[0, 1] = 170;
            a2[0, 2] = 90;

            a2[1, 0] = 5530;
            a2[1, 1] = 19848;
            a2[1, 2] = 9942;

            Console.WriteLine("Single Dimention Array");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            // 0th dimention - x
            Console.WriteLine($" GetLength(0): {arr2D.GetLength(0)}");

            // 1st dimentions length - y
            Console.WriteLine($" GetLength(1): {arr2D.GetLength(1)}");

            // Total number of elements
            Console.WriteLine($" Length : {arr2D.Length}");

            Console.WriteLine("Double Dimention Array");
            PrintArray(a2);
        }

        private static void PrintArray(int[,] arr2D)
        {
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    Console.Write($" {arr2D[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public static void Demo2()
        {
            const int ARRAY_SIZE = 5;

            string[] StudentNames;
            StudentNames = new string[ARRAY_SIZE];

            // 0, 1, 2, 3, 4
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.Write($"Enter {i + 1} Student Name:");
                StudentNames[i] = Console.ReadLine();
            }

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                // 100, 105, 110, 115, 120
                Console.WriteLine($"{i + 1001}. {StudentNames[i]} ");
            }
        }
    }
}