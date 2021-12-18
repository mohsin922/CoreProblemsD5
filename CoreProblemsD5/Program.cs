using System;

namespace CoreProblemsD5
{

    public class PercentageOfHeadsNTails
    {
        
        public static  double flipCoin()
        {
            Random random = new Random();
            return random.NextDouble();
            
        }

        public static void Main(String[] args)
        {
            
            int totalDieRoll = 0;
            int headCount = 0;
            int tailCount = 0;
            


            Console.WriteLine("Enter the number of times to flip the coin : ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                double FlipCoin = flipCoin();
                totalDieRoll++;

                if (FlipCoin <= 0.5)
                {
                    headCount++;
                    Console.WriteLine("Heads");
                }
                else if (FlipCoin >= 0.5)
                {
                    tailCount++;
                    Console.WriteLine("Tails");
                }
            }

            double headPercentage = ((double)headCount / (double)totalDieRoll) * 100;
            Console.WriteLine("Head Percentage : " + headPercentage);
            double tailPercentage = ((double)tailCount / (double)totalDieRoll) * 100;
            Console.WriteLine("Tail Percentage : " + tailPercentage);

        }
    }
}
