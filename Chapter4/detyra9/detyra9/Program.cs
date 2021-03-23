using System;

public class Program
{
    public static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        int forthNumber;
        int fifthNumber;
        Console.WriteLine("Input the first number:");
        string a = Console.ReadLine();
        if (!int.TryParse(a, out firstNumber))
        {
            Console.WriteLine("Value is not a number, try again");
            a = Console.ReadLine();

        }
        Console.WriteLine("Input the second number:");
        string b = Console.ReadLine();
        if (!int.TryParse(b, out secondNumber))
        {
            Console.WriteLine("Value is not a number, try again");
            b = Console.ReadLine();
        }
        Console.WriteLine("Input the third number:");
        string c = Console.ReadLine();
        if (!int.TryParse(c, out thirdNumber))
        {
            Console.WriteLine("Value is not a number, try again");
            c = Console.ReadLine();
        }
        Console.WriteLine("Input the forth number:");
        string d = Console.ReadLine();
        if (!int.TryParse(d, out forthNumber))
        {
            Console.WriteLine("Value is not a number, try again");
            d = Console.ReadLine();
        }
        Console.WriteLine("Input the fifth number:");
        string e = Console.ReadLine();
        if (!int.TryParse(e, out fifthNumber))
        {
            Console.WriteLine("Value is not a number, try again");
            e = Console.ReadLine();
        }
        Console.WriteLine($"The sum of the number is: {Sum1(firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber)}");
    }
    static int Sum1(int a, int b, int c, int d, int e)
    {
        return a + b + c + d + e;
    }
}