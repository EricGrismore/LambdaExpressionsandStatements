using System;
using System.Security.Cryptography.X509Certificates;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] nums = new int[10];
            //Decided to go with random numbers
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(1, 100);
            }

            //sum of the two
            var sum = (int x, int y) => x + y;

            //them multiply
            var multiple = (int x, int y) => x * y;

            //finds the smaller value
            var smallerValue = (int a, int b) =>
            {
                if (a < b)
                    return a;
                else
                    return b;
            };



            for (int x = 0; x < nums.Length - 1; x++)
            {
                
                Console.WriteLine($"Numbers you are using: {nums[x]}  and  {nums[x + 1]}");
                //sum
                Console.WriteLine($"The combined total of them is: {sum(nums[x], nums[x + 1])}");
                //multiple
                Console.WriteLine($"The multiplication of the two is: {multiple(nums[x], nums[x + 1])}");
                //found smaller number
                Console.WriteLine($"The smaller value is: {smallerValue(nums[x], nums[x + 1])}");

                Console.WriteLine();
            }

        }
    }
}
