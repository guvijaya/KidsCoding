using System;

namespace CSharp
{
    public class MaximalRectangle
    {
        public static void Execute()
        {
            int[][] data = new int[5][];

            data[0] = new int[] { 0, 0, 0, 0, 0 };
            data[1] = new int[] { 0, 1, 1, 1, 0 };
            data[2] = new int[] { 0, 1, 0, 1, 0 };
            data[3] = new int[] { 0, 1, 1, 1, 0 };
            data[4] = new int[] { 0, 0, 0, 0, 0 };

            Print(data);

            Console.WriteLine($"\n {GetArea(data)}");
        }

        public static int GetArea(int[][] data)
        {
            int rows = data.Length;
            int columns = data[0].Length;

            if(rows == 0 || columns == 0)
                return 0;

            int area = 0;

            int[][] dp = new int[rows][];

            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[columns];
            }

            for(int i = 0; i < rows; ++i){
                for(int j = 0; j < columns; ++j){
                    int temp = i;
                    while(temp < rows && data[temp][j] == 1){
                        // Count all consicutive 1s in column
                        ++dp[i][j];
                        ++temp;
                    }   
                }
            }
            
            Console.WriteLine("First Scan");
            Print(dp);

            for(int i = 0; i < rows; ++i){
                for(int j = 0; j < columns; ++j){
                    int temp = j;
                    int len = dp[i][j];
                    while(temp < columns && dp[i][temp] > 0){
                        len = len < dp[i][temp] ? len : dp[i][temp];
                        ++temp;
                        area = area > len * (temp-j) ? area : len * (temp-j);
                    }
                    area = area > len*(temp-j) ? area :  len*(temp-j);
                }
            }

            Console.WriteLine();
            Print(dp);
            return area;        
        }

        public static int Print(int[][] data)
        {
            int rows = data.Length;
            int columns = data[0].Length;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{data[i][j]} ");
                }
            }

            return 0;
        }
    }
}