using System;
using System.Collections.Generic;

namespace CSharp
{
    public class SpiralMatrix
    {
        public static void Execute()
        {
            int[,] input = { { 1, 2, 3, 40, 400  },
                             { 4, 5, 6, 60, 600 },
                             { 7, 8, 9, 90, 900 }
                           };

            Console.WriteLine("\nInput:");            
            for (int i = 0; i < input.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write($" {input[i,j],-3}");
                }
            }

            var ret = Spiral(input);

            Console.WriteLine("\nOutput:");  
            foreach (var item in ret)
                Console.Write($" {item,-3}");
        }

        static List<int> Spiral(int[,] input)
        {
            int left = 0;
            int right = input.GetLength(1)-1;

            int top = 0;            
            int bottom = input.GetLength(0)-1;

            List<int> ans = new List<int>();

            while (top <= bottom && left <= right) {
                for (int c = left; c <= right; c++) 
                    ans.Add(input[top,c]);

                for (int r = top + 1; r <= bottom; r++) 
                    ans.Add(input[r,right]);
                    
                if (top < bottom && left < right) {
                    for (int c = right - 1; c > left; c--) 
                        ans.Add(input[bottom,c]);

                    for (int r = bottom; r > top; r--) 
                        ans.Add(input[r,left]);
                }
                top++;
                bottom--;
                left++;
                right--;
            }
            return ans;
        }
    }
}