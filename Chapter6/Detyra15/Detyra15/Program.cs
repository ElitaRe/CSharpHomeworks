using System;

namespace Detyra15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a hex number");
            string hexnr = Console.ReadLine();
            int decnr = Convert.ToInt32(hexnr, 16);
            Console.WriteLine(hexnr +" ne decimal eshte " + decnr);
        }
    }
}
