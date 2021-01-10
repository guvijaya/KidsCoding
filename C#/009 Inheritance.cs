using System;

namespace CSharpExample2
{
    // Base Class
    class Rectangle
    {
        protected int length;
        protected int width;

        public virtual int Length
        {
            get { return length; }
            set { length = value; }
        }

        public virtual int Width
        {
            get { return width; }
            set { width = value; }
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

    // Derived Class
    class Square : Rectangle
    {
        public int Side
        {
            get { return Width; }
            set
            {
                width = value;
                length = value;
            }
        }

        public override int Length
        {
            get { return length; }
            set
            {
                length = value;
                width = value;
            }
        }

        public override int Width
        {
            get { return width; }
            set
            {
                width = value;
                length = value;
            }
        }

        // public static Square Add(Square x, Square y)
        public static Square operator +(Square x, Square y)
        {
            Square z = new Square();
            z.Side = x.Side + y.Side;
            return z;
        }
    }
}