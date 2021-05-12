using System;
public class Demo
{
    public static void Main()
    {
        Console.WriteLine("Enter the year");
        int year = Int32.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Leap Year!");
        }
        else
        {
            Console.WriteLine("Not a Leap Year!");
        }
    }
}