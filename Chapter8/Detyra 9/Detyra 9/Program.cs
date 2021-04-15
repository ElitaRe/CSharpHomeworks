using System;

namespace Detyra_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string binnr = Console.ReadLine();
            string hexnr = Convert.ToInt32(binnr, 2).ToString("X");
            Console.WriteLine(binnr+" ne hexadecimal eshte "+ hexnr);
        }
    }
}
