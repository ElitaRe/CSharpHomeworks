using System;

namespace Detyra13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a bin number");
            string binnr = Console.ReadLine();
            int decnr = Convert.ToInt32(binnr, 2);
            Console.WriteLine(binnr + " ne decimal eshte " + decnr);
        }
    }
}