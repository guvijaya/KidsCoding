using System;

namespace CSharp
{
    class ArrayStats
    {

        public static void Demo()
        {
            const int ARRAY_SIZE = 10;
            int[] nums = new int[ARRAY_SIZE];

            Random rand = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
                nums[i] = Math.Abs(rand.Next() % 100);

            for (int i = 0; i < ARRAY_SIZE; i++)
                Console.Write($" {nums[i]}");

            // nums - contains 100;
            // MAX
            int secondMax = int.MinValue;
            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            int count = 0;
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                sum = sum + nums[i];
                count = count + 1;

                if (max < nums[i])
                {
                    // Before changing the max
                    // Mark the existing max as send max
                    if (secondMax < max) secondMax = max;

                    max = nums[i];
                }

                if (secondMax < nums[i] && max > nums[i]) secondMax = nums[i];

                if (min > nums[i]) min = nums[i];
            }
            Console.WriteLine("");
            Console.WriteLine($"The max number is {max}");
            Console.WriteLine($"The 2nd max number is {secondMax}");
            Console.WriteLine($"The min number is {min}");
            Console.WriteLine($"The sum of number is {sum}");
            Console.WriteLine($"The avg of number is {(sum * 1.0) / count}");
        }
    }
}