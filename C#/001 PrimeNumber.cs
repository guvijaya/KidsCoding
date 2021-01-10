using System;

namespace CSharp
{
    class PrimeNumber
    {

        public static void Demo()
        {
            Console.WriteLine("Enter a number to check it is Prime or not?");
            int x = int.Parse(Console.ReadLine());

            if (IsPrime(x))
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
        }

        public static bool IsPrime(int num)
        {
            bool prime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
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

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    ans = i;
                    break;
                }
            }

            return ans;
        }
    }
}