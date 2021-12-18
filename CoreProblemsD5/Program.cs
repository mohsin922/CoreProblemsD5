using System;
namespace CoreProblems
{
    public class EvenOrOdd
    {

        public static void check(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("The number " + n + " is even");
            }
            else
            {
                Console.WriteLine("The number " + n + " is odd");
            }
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            check(num);
        }
    }
}