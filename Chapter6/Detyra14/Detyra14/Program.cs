using System;
public class ConversionExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int decnr = int.Parse(Console.ReadLine());
        string hexnr = Convert.ToString(decnr, 16);
        Console.WriteLine("Numri " + decnr + " i kthyer ne hex eshte " + hexnr);
    }
}