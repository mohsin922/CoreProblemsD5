using System;
namespace CoreProblems
{
    public class LargestNum
    {

        public static void largestOfThreeNumbers(int largestNumber, int num1, int num2, int num3)
        {
            if (num1 > largestNumber) largestNumber = num1;
            if (num2 > largestNumber) largestNumber = num2;
            if (num3 > largestNumber) largestNumber = num3;
            Console.WriteLine("The largest number among the three numbers is : " + largestNumber);
        }

        public static void Main(String[] args)
        {

            
            Console.WriteLine("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            largestOfThreeNumbers(0, num1, num2, num3);
        }
    }
}