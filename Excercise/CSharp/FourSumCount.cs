using System;
using System.Collections.Generic;

namespace CSharp
{
    public class FourSumCount{
        public static void Execute()
        {
            int[] A = {-1,-1};
            int[] B = {-1,1};
            int[] C = {-1,1};
            int[] D = {1,-1};

            int result = Sum4Count(A,B,C,D);

            Console.WriteLine(result);
        }

        static public int Sum4Count(int[] A, int[] B, int[] C, int[] D) {
            int cnt = 0;

            var abResult = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    int result = A[i] + B[j];
                    if(abResult.ContainsKey(result))
                        abResult[result]++;
                    else
                        abResult.Add(result,1);
                }
            }

            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < D.Length; j++)
                {
                    int result = -(C[i] + D[j]);
                    if(abResult.ContainsKey(result))
                        cnt += abResult[result];
                }
            }
            return cnt;
        }
    }    
}