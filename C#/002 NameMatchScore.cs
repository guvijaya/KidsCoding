using System;

namespace CSharp
{
    class NameMatchScore
    {
        public static void Demo()
        {
            Console.WriteLine("Enter your name:");
            var s1 = Console.ReadLine();

            Console.WriteLine("Enter your friend name:");
            var s2 = Console.ReadLine();

            int n1 = 0;
            int n2 = 0;

            foreach (var item in s1)
                n1 = n1 + (int)item;

            foreach (var item in s2)
                n2 = n2 + (int)item;

            Console.WriteLine($"You match rate is { (n1 + n2) % 100 }%");
        }
    }
}