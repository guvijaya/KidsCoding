using System;

namespace CSharp
{
    class Program
    {
        public static void Sample()
        {
            Console.WriteLine("Shreya");
        }

        static void Main(string[] args)
        {
            // Calling a function
            // <ClassName>.<Function Name>();
            // VishalClass.SayHello();
            // VishalClass.DoSomething(5);
            // int x = 20;
            // VishalClass.DoSomething(x);
            // int ans = VishalClass.Add(20, 50);
            // Console.WriteLine(ans);

            // bool x = VishalClass.IsPrime(8);
            // Console.WriteLine(x);

            //  x = VishalClass.IsPrime(80);
            // Console.WriteLine(x);

            //  x = VishalClass.IsPrime(82321);
            // Console.WriteLine(x);

            //  x = VishalClass.IsPrime(8553);
            // Console.WriteLine(x);

            // Console.WriteLine(x);

            // Sample();
            // Sample();

            string s = VishalClass.GetRandomMonth();

            Console.WriteLine(s);

            Console.WriteLine($"R1 = {VishalClass.GetRandom(1,11)} R2 = {VishalClass.GetRandom(1,11)} ");
        }
    }
}
