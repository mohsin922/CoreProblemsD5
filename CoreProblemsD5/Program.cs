using System;

class Harmonic
{

	// Function to find N-th Harmonic Number
	static double nthHarmonic(int N)
	{
		// H1 = 1
		float harmonic = 1;

		
		for (int i = 2; i <= N; i++)
		{
			harmonic += (float)1 / i;
		}

		return harmonic;
	}

	
	static public void Main()
	{
		Console.WriteLine("Enter the Nth number");
		int N = Convert.ToInt32( Console.ReadLine());

		Console.Write("Nth number harmonic value is : " +nthHarmonic(N));
	}
}

