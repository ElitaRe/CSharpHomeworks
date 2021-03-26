using System;

public class Program
{
	public static void Main()
	{
		int x = int.Parse(Console.ReadLine());
		int y = int.Parse(Console.ReadLine());
		int R = 5;

		if ((x * x) + (y * y) <= R * R && (x < -1 || y < 1))
		{
			Console.WriteLine("Point {{{0} , {1}}} is inside the circle with radius {1} and outside of rectangle.", x, y, R);
		}
		else
		{
			Console.WriteLine("Point {{{0} , {1}}} is outside the circle with radius {1}.", x, y, R);
		}
	}
}
