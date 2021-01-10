using System;

namespace CSharpExample
{
    // Base Class
    public class ExceptionsExample
    {
        public static void Demo()
        {
            int a = 10;

            Console.WriteLine("Enter the number to divide:");
            try
            {
                int b = int.Parse(Console.ReadLine());

                // code....
                Console.WriteLine(a / b);
                // other code
            }
            catch (DivideByZeroException abc)
            {
                try
                {
                    Console.WriteLine("Looks like input is incorrect");
                    Console.WriteLine(abc.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error while handling exception {e.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}