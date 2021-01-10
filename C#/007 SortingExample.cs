using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpExample
{
    class SortingExample
    {

        public static void Demo()
        {
            // Declare variables
            const int ARRAY_SIZE = 20;
            int[] nums = new int[ARRAY_SIZE];

            // Assign random values
            Random rand = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++) nums[i] = Math.Abs(rand.Next() % 100);

            // Print them
            for (int i = 0; i < ARRAY_SIZE; i++) Console.Write($" {nums[i]}");

            // SORTING
            for (int curpos = 0; curpos < ARRAY_SIZE; curpos++)
            {
                // minpos = Find minimum number's possition
                int minPos = curpos;
                for (int i = curpos; i < ARRAY_SIZE; i++)
                    if (nums[i] < nums[minPos]) minPos = i;

                // swap nums[curpos]  and nums[minpos]
                int t = nums[curpos];
                nums[curpos] = nums[minPos];
                nums[minPos] = t;
            }

            //Print sorted numbers
            Console.WriteLine("\r\nSorted Numbers are:");
            for (int i = 0; i < ARRAY_SIZE; i++)
                Console.Write($" {nums[i]}");
        }
    }
}