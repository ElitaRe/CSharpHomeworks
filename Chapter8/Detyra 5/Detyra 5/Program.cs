using System;

namespace Detyra_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string binnr = Console.ReadLine();
            int decnr = Convert.ToInt32(binnr, 2);
            Console.WriteLine(binnr + " ne decimal eshte " + decnr);
        }
    }
}
