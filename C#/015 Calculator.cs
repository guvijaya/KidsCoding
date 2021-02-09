using System;

namespace CSharp
{
  
  public class Calculator
  {
      public static void Calc()
      {
        Console.WriteLine("If you want to Add click +");
        string strkey = Console.ReadLine();
        Char key = strkey[0];

        if(key == '+')
        {
            add();
        }
      }
    public static void add()
    {
       
       Console.WriteLine("Enter a number to add");
       string strnum1 = Console.ReadLine();
       
       Console.WriteLine("Enter a number to add");
       string strnum2 = Console.ReadLine();

       int a = int.Parse(strnum1);
       int b = int.Parse(strnum2);
       int result = a + b;

       Console.WriteLine(result);
        
    }

  }

}