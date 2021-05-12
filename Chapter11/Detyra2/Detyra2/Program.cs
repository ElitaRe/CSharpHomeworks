using System;

class GFG
{

	public static void Main()
	{
		Random rand1 = new Random();

		Console.WriteLine("Printing 10 random numbers between 100 and 200");
		for (int i = 1; i <= 10; i++)
			Console.WriteLine( rand1.Next(100, 200));
	}
}
