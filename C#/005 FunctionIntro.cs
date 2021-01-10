using System;

namespace CSharpExample
{
    // Base Class
    public class FunctionIntro
    {
        public static void Demo()
        {
            SayHello();
            DoSomething(100);
            int ans = Add(45, 28);
            Console.WriteLine(ans);
            Console.WriteLine($"Random { GetRandom(0, 10) }");
            Console.WriteLine($"Random Month: { GetRandomMonth() }");
        }
        public static void SayHello()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("       Hello         ");
            Console.WriteLine("*********************");
        }
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
            int small = GetRandom(1, 13);
            string randMonth;

            switch (small)
            {
                case 1: randMonth = "January"; break;
                case 2: randMonth = "February"; break;
                case 3: randMonth = "March"; break;
                case 4: randMonth = "April"; break;
                case 5: randMonth = "May"; break;
                case 6: randMonth = "June"; break;
                case 7: randMonth = "July"; break;
                case 8: randMonth = "August"; break;
                case 9: randMonth = "September"; break;
                case 10: randMonth = "October"; break;
                case 11: randMonth = "November"; break;
                case 12: randMonth = "December"; break;
                default: randMonth = "Unknown"; break;
            }

            return randMonth;
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
    }
}