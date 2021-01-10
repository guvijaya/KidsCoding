using System;

namespace CSharp
{
    public class FindContentChildren
    {
        public static void Execute()
        {
            int[] gread = { 1, 2, 3 };
            int[] size = { 1, 1 };
            int s = solve(gread, size);
            Console.WriteLine(s);
        }

        static public int solve(int[] g, int[] s)
        {
            {
                int cnt = 0;

                Array.Sort(g);
                Array.Sort(s);

                int child = 0;
                int cookie = 0;

                while (child < g.Length && cookie < s.Length)
                {
                    if (g[child] <= s[cookie])
                    {
                        child++;
                        cnt++;
                    }
                    cookie++;
                }

                return cnt;
            }
        }
    }
}