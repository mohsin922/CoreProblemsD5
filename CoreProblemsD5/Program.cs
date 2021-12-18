using System;

public class QuotientNRemainder
{

    public static void quotient(int dividend, int divisor)
    {
        int ans = dividend / divisor;
        Console.WriteLine("The quotient is : " + ans);
    }

    public static void remainder(int dividend, int divisor)
    {
        int ans = dividend % divisor;
        Console.WriteLine("The remainder is : " + ans);
    }
    public static void Main(String[] args)
    {


        Console.WriteLine("Enter the number for Dividend : ");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number for Divisor : ");
        int divisor = Convert.ToInt32(Console.ReadLine());
        quotient(dividend, divisor);
        remainder(dividend, divisor);

    }
}