using System;

namespace CSharp
{
    public class VishalClass
    {
        // 15 - 25
        // 10
        // 0 to 9
        // 15 to 24
        public static int GetRandom(int startNum, int endNum)
        {
            int range = endNum - startNum;

            Random r = new Random();
            int vishalrand = r.Next();
            int small = (vishalrand % range) + startNum;

            return small;
        }

        public static string GetRandomMonth()
        {
            int small = GetRandom(1,13);
            string randMonth;

            switch (small)
            {
                case 1: randMonth = "January"; break;
                case 2: randMonth = "February"; break;
                case 3: randMonth ="March"; break;
                case 4: randMonth ="April"; break;
                case 5: randMonth ="May"; break;
                case 6: randMonth ="June"; break;
                case 7: randMonth ="July"; break;
                case 8: randMonth ="August"; break;
                case 9: randMonth ="September"; break;
                case 10: randMonth ="October"; break;
                case 11: randMonth ="November"; break;
                case 12: randMonth ="December"; break;
                default: randMonth ="Unknown"; break;
            }

            return randMonth;
        }

        public static bool IsPrime(int num)
        {
            bool prime = true;

            for(int i=2; i<num; i++)
            {
                if(num % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;
        }

        public static int Divisable(int num)
        {
            int ans = 1;

            for(int i=2; i<num; i++)
            {
                if(num % i == 0)
                {
                    ans = i;
                    break;
                }
            }

            return ans;
        }

        //<Return Type> <Function Name> ( <parameter type> <Parameter Name> )
        public static void DoSomething(int value)
        {
            Console.WriteLine();
            Console.WriteLine($"The value is : {value}");
            Console.WriteLine();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        // Function Definition
        public static void SayHello()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("       Hello         ");
            Console.WriteLine("*********************");
        }
    }
}