using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Please enter your number:");
        double n = double.Parse(Console.ReadLine());

        bool result = (n % 5 == 0) && (n % 7 == 0);
        Console.WriteLine("The number {0} can be divided by 5 and 7? ANSWER: {1}", n, result);
    }
}