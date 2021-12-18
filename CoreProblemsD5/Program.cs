using System;

public class PrimeFactors
{

    public static void primeFactors(int num)
    {
        for (int i = 2; i <= num; i++)
        {
            while (num % i == 0)
            {
                Console.WriteLine(i);
                num = num / i;
            }
        }
    }
    public static void Main(String[] args)
    {

        Console.WriteLine("Enter the number : ");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prime factors  of " + input + " are : ");
        primeFactors(input);
    }
}