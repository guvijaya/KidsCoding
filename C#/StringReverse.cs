using System;

namespace CSharp
{
    class StringReverse
    {
        public static string Reverse(string name)
        {
            char[] nameChArr = name.ToCharArray();

            // Reverse the Array
            for (int i = 0; i < (nameChArr.Length / 2); i++)
            {
                char tmp = nameChArr[i];
                nameChArr[i] = nameChArr[nameChArr.Length - 1 - i];
                nameChArr[nameChArr.Length - 1 - i] = tmp;
            }

            var n1 = new string(nameChArr); // char array to string

            return n1;
        }

        public static void Printing(string name)
        {
            char[] nameChArr = name.ToCharArray();

            Console.WriteLine("Forward");
            for (int i = 0; i < nameChArr.Length; i++)
                Console.Write($" {nameChArr[i]}");

            Console.WriteLine("\nReverse");
            for (int i = nameChArr.Length - 1; i >= 0; i--)
                Console.Write($" {nameChArr[i]}");
        }

        public static void Demo()
        {
            Console.WriteLine("Enter a string");

            // String 
            string name = Console.ReadLine();
            var ans = Reverse(name);
            Console.WriteLine(ans);

            Printing(name);
        }
    }
}