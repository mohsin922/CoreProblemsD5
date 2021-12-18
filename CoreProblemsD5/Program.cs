using System;
namespace CoreProblems
{
    public class SwapTwoNum
    {

        public static void beforeSwap(int a, int b)
        {
            Console.WriteLine("Numbers before Swapping : " + a + "" + b);
        }

        public static void afterSwap(int a, int b)
        {
            int change;
            change = a;
            a = b;
            b = change;
            Console.WriteLine("Numbers after Swapping : " + a + "" + b);
        }
        public static void Main(String[] args)
        {

            
            Console.WriteLine("Enter the first number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            beforeSwap(a, b);
            afterSwap(a, b);
        }
    }
}