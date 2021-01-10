using System;

namespace CSharp
{
    public class ArraySum
    {
        public static void Execute()
        {
            int[] input = {1,2,3,4};

            foreach (var item in input)
                Console.Write($" {item}");

            var output = ProductExceptSelfv2(input);
            
            Console.WriteLine("\nResult:");            
            foreach (var item in output)
                Console.Write($" {item}");
        }

        
        public static int[] ProductExceptSelfv2(int[] nums) {
           int[] output = new int[nums.Length];

           int[] left = new int[nums.Length];
           int[] right = new int[nums.Length];

           left[0] = 1;
           for(int i=1;i<nums.Length;i++)
            left[i] = left[i-1] * nums[i-1];

           right[nums.Length-1] = 1;
           for(int i=nums.Length-2;i>=0;i--)
            right[i] = right[i+1] * nums[i+1];

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = left[i] * right[i];                
            }

            Console.WriteLine("\nLeft Array: ");
            foreach (var item in left)
                Console.Write($"{item} ");
            
            Console.WriteLine("\nRight Array: ");
            foreach (var item in right)
                Console.Write($"{item} ");
            
            return output;
        }

        public static int[] ProductExceptSelf(int[] nums) {
           int[] output = new int[nums.Length];

           for(int i=0 ;i < nums.Length; i++)
           {
               output[i] = 1;
               for(int j=0;j< nums.Length; j++)
                if(i!=j)
                    output[i] *= nums[j];
           }

           return output;
        }
    }
}