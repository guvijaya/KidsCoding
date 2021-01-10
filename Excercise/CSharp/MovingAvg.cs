using System;

namespace CSharp
{
    public class MovingAvg
    {
        public static void Execute()
        {
            var x = new MovingAverage(3);

            Console.WriteLine(x.Next(10));
            Console.WriteLine(x.Next(20));
            Console.WriteLine(x.Next(30));
            Console.WriteLine(x.Next(40));
            Console.WriteLine(x.Next(50));
        }

        public class MovingAverage
        {
            int ElementCount;
            int Index = 0;
            int[] Data;
            int Total;

            /** Initialize your data structure here. */
            public MovingAverage(int size)
            {
                Total = 0;
                Index = 0;
                Data = new int[size];
                ElementCount = 0;
            }

            public double Next(int val)
            {
                Total -= Data[Index];
                Total += val;
                Data[Index++] = val;
                if (Index == Data.Length)
                    Index = 0;

                if (ElementCount < Data.Length)
                    ElementCount++;

                return Total / ElementCount;
            }
        }

        /**
         * Your MovingAverage object will be instantiated and called as such:
         * MovingAverage obj = new MovingAverage(size);
         * double param_1 = obj.Next(val);
         */
    }
}