using System;
using System.Collections;

namespace CSharp
{
    class InWordsClass
    {
        public static void Demo()
        {
            int n3 = 472;
            string w3 = InWordsFor3Digit(n3);
            Console.WriteLine(n3);
            Console.WriteLine(w3);

            int num = 563464;
            string word = InWordsLong(num);
            Console.WriteLine(num);
            Console.WriteLine(word);
        }

        public static string InWordsLong(int num)
        {
            string[] pos = new string[] { " Hundred ", " Thousand ", " Million ", " Billion ", " Trillion " };
            if (num < 1000)
            {
                return InWordsFor3Digit(num);
            }
            else if (num < 1000000)
            {
                int part1 = (int)(num / 1000);
                int part2 = num % 1000;
                return InWordsFor3Digit(part1) + pos[1] + InWordsFor3Digit(part2);
            }
            else if (num < 1000000000)
            {
                int part1 = (int)(num / 1000000);
                int part2 = (int)(num / 1000) % 1000;
                int part3 = num % 1000;

                //Console.WriteLine($" Part1={part1} Part2={part2} Part3={part3}");                
                return InWordsFor3Digit(part1) + pos[2] + InWordsFor3Digit(part2) + pos[1] + InWordsFor3Digit(part3);
            }
            else
            {
                return "I don't know";
            }
        }
        private static string InWordsFor3Digit(int num)
        {
            string[] words = new string[] {"Zero","One", "Two", "Three", "Four", "Five"
                                         , "Six", "Seven", "Eight", "Nine", "Ten"
                                         , "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen"
                                         , "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

            // string[] words = new string[] {"பூஜ்ஜியம்","ஒன்று","இரண்டு","மூன்று","நான்கு","ஐந்து"
            //                                 ,"ஆறு","ஏழு","எட்டு","ஒன்பது","பத்து","பதிணொன்று","பன்னிரண்டு","பதிமூன்று"
            //                                 ,"பதிநான்கு","பதினைந்து","பதினாறு","பதினேழு"
            //                                 ,"பதினெட்டு","பத்தொன்பது"};

            var tens = new string[] {"","","Twenty", "Thirty", "Fourty", "Fifty","Sixty"
                                    ,"Seventy", "Eighty" ,"Ninety"};

            var hundreds = new string[] { "Hundred" };

            if (num >= 0 && num < 20)
            {
                return words[num];
            }
            else if (num < 100)
            {
                int digit1 = (int)(num / 10);
                int digit2 = num % 10;

                string ans = tens[digit1];
                if (digit2 != 0)
                    ans = ans + " " + words[digit2];
                return ans;
            }
            else //100, 101, ... 158.... 999
            {
                int digit1 = (int)(num / 100);
                int digit2 = (int)(num / 10) % 10;
                int digit3 = num % 10;

                string ans = words[digit1] + " " + hundreds[0] + " and " + tens[digit2];
                if (digit3 != 0)
                    ans = ans + " " + words[digit3];

                return ans;
            }
        }
    }
}