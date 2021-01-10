using System;

namespace CSharpExample
{
    // Base Class
    public class InheritanceDemo
    {

        public static void DemoOp()
        {
            var x = new CSharpExample2.Square();
            var y = new CSharpExample2.Square();
            x.Side = 8;
            y.Side = 7;

            int i = 6;
            int j = 10;
            Console.WriteLine(i + j);

            // var z = x.Add(y);
            var z = x + y;

            Console.WriteLine(z.GetArea());
        }

        public static void Demo()
        {
            try
            {
                var x = new CSharpExample.Square(5);
                var y = new CSharpExample.Square(15);
                var z = new CSharpExample.Square(25);

                Console.WriteLine(CSharpExample.Square.ObjectCount);

                Console.WriteLine(x.GetArea());
                Console.WriteLine(y.GetArea());
                Console.WriteLine(z.GetArea());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}