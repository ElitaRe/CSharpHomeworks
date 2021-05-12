using System;
public class Example3
{
    static void Main(string[] args)
    {
        Console.Write("Enter year: ");
        int year = Int32.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = Int32.Parse(Console.ReadLine());
        Console.Write("Enter day: ");
        int day = Int32.Parse(Console.ReadLine());


        DateTime ditaesotme = new DateTime(year,month,day);
        Console.WriteLine(ditaesotme.ToString("ddddd"));
    }
}
