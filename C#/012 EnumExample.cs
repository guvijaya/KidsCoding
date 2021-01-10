using System;

namespace CSharp
{
    class EnumExample
    {
        enum Kids
        {
            Swetha = 2004,
            Shreya = 2005,
            Lalith = 2008,
            Vishal = 2008,
            Bathri = 2013
        }

        public static void Demo()
        {
            Kids y = Kids.Bathri;
            int z = (int)y;

            Console.WriteLine($"Kids name: {y}");
            Console.WriteLine($"Kids name as int: {z}");

            Console.WriteLine("Enter a key to get surprised!");
            var x = Console.ReadKey();

            string str = "I don't know the key";
            if (x.KeyChar == ' ')
                str = "Space";
            else if (x.KeyChar == '\t')
                str = "Tab";
            else if (x.KeyChar == '\r' || x.KeyChar == '\n')
                str = "Enter Key";
            else if (x.Key == ConsoleKey.PageUp)
                str = "You are the winner";
            else
                str = x.KeyChar.ToString();

            Console.WriteLine($"The key entered is [{str}]");
        }
    }
}