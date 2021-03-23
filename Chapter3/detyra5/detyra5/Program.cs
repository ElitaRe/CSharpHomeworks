using System;

class Trapezoid
{
    static void Main()
    {
        Console.WriteLine("Base a");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Base b");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Height");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;
        Console.WriteLine("The area of your trapezoid is: {0}", area);
    }
}