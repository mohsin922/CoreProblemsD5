using System;
namespace LEAPYEAR
{


    public class LeapYear
    {



        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap Year ", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap Year ", year);

            }
        }
    }

}
