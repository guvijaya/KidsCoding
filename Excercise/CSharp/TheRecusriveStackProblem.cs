using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    public class TheRecusriveStackProblem
    {
        //https://www.youtube.com/watch?v=TUl1AsOfKP4&t=384s
        public static void Execute()
        {
            // (new parenthesis("()")).PrintScore();
            // (new parenthesis("()()")).PrintScore();
            // (new parenthesis("(()())")).PrintScore();
            // (new parenthesis("((()))")).PrintScore();
            (new parenthesis("((()())())")).PrintScore();
        }

        class parenthesis
        {
            int[] en;
            string str;
            public parenthesis(string s)
            {
                en = new int[s.Length];
                str = s;
            }

            int go(int lo, int hi)
            {                
                // When the width is just 2
                if (lo + 1 == hi) 
                {
                    Console.WriteLine($"Base - Low: {lo} High: {hi}");
                    return 1;
                }

                // if current low points to end index 2x
                int mid = en[lo];
                if (mid == hi) 
                {
                    Console.WriteLine($"Double Low: {lo} High: {hi}");
                    return 2 * go(lo + 1, hi - 1);
                }

                // divide
                Console.WriteLine($"Add Low: {lo} High: {hi}");
                return go(lo, mid) + go(mid + 1, hi);
            }

            public void PrintScore()
            {
                Console.WriteLine($" {str} : {GetScore()}");
            }

            public int GetScore()
            {
                var s = new Stack<int>();

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ')')
                    {
                        int t = s.Peek();
                        en[t] = i;
                        s.Pop();
                    }
                    else s.Push(i);
                }
            
                foreach (var item in en) Console.Write($" {item}");                    
                Console.WriteLine();
                return go(0,str.Length-1);
            }
        }
    }
}