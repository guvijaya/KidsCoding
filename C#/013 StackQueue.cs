using System;
using System.Collections;

namespace CSharp
{
    class StackQueueExample
    {
        //using System.Collections;
        public static void Demo()
        {
            // Last in first out
            Stack x = new Stack();

            x.Push(100);
            x.Push(200);
            x.Push(300);
            x.Push(400);

            பதிவுசெய்(x.Pop());
            பதிவுசெய்(x.Pop());
            பதிவுசெய்(x.Pop());
            பதிவுசெய்(x.Pop());

            Console.WriteLine("Queue");

            // First in First Out
            Queue y = new Queue();

            y.Enqueue(100);
            y.Enqueue(200);
            y.Enqueue(400);
            y.Enqueue(50);

            பதிவுசெய்(y.Dequeue());
            பதிவுசெய்(y.Dequeue());
            பதிவுசெய்(y.Dequeue());
            பதிவுசெய்(y.Dequeue());
        }


        public static void பதிவுசெய்(object x)
        {
            Console.WriteLine(x);
        }

        public static void Print(object x)
        {
            Console.WriteLine(x);
        }

        public static void Print(double x)
        {
            Console.WriteLine(x);
        }

        public static void Print(int x)
        {
            Console.WriteLine(x);
        }

        public static void Print(string x)
        {
            Console.WriteLine(x);
        }

    }
}