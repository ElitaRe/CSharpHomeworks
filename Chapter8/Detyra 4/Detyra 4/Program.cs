using System;

namespace Detyra_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int decnr = int.Parse(Console.ReadLine());
            string binnr = Convert.ToString(decnr, 2);
            Console.WriteLine("Numri " + decnr + " i kthyer ne binar eshte " + binnr);
        }
    }
}
