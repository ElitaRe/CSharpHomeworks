using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = (number / 100) % 10;
        if (thirdDigit == 7)
        {
            Console.WriteLine("The third digits IS seven!");
        }
        else
        {
            Console.WriteLine("The third digit IS NOT seven.");
        }
    }
}