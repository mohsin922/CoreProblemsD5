using System;
namespace PowerOf2
{

    public class PowersOf2
    {

        public static Boolean isInputValid(int num)
        {
            return num >= 0 && num <= 31;
        }

        public static void powerOf2(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2 power " + i + " is: " + Math.Pow(2, i));
            }
        }

        public static void Main(String[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter the value of N: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (!isInputValid(n))
                {
                    Console.WriteLine("Entered number is invalid");
                }
                else
                {
                    powerOf2(n);
                    break;

                }
            }
        }
    }
}
