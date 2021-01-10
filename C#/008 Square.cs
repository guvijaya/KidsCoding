using System;

namespace CSharpExample
{
    class Rectangle
    {
        public int Length;
        public int Width;

        // Constructor in Python it is called __init___
        public Rectangle(int l, int w)
        {
            Length = l;
            Width = w;
        }

        public int GetArea()
        {
            return Length * Width;
        }

        public int GetPerimeter()
        {
            return 2 * (Length + Width);
        }
    }

    class Square
    {
        private static int objectCount = 0;

        public static int ObjectCount
        {
            get { return objectCount; }
        }

        // Instance member creates a copy for each object
        // Class variable
        private int side;

        public int GetSide()
        {
            return side;
        }

        public void SetSide(int value)
        {
            if (value < 0)
                throw new Exception("The value cannot be negative");

            if (value > 100)
                throw new Exception("The value cannot be more than 100");

            side = value;
        }

        // Properties
        public int SideProperties
        {
            get
            {
                return side;
            }

            set
            {
                if (value < 0)
                    throw new Exception("The value cannot be negative");

                side = value;
            }
        }

        public Square(int s)
        {
            objectCount++;
            this.side = s;
            // It is called whenever an 
            // instance is create
        }

        // Static member common for the class
        public static string Message = "This is SQUARE";

        public int GetArea()
        {
            return this.side * this.side;
        }

        public int GetCircumference()
        {
            return 4 * side;
        }

        public static void Test()
        {
            Console.WriteLine("I am public static void");
            PriTest(); // Private can be called only inside the class
        }

        private static void PriTest()
        {
            Console.WriteLine("I am private static void2");
        }
    }
}


