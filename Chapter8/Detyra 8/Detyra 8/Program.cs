using System;

namespace Detyra_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number: ");
            string hexnr = Console.ReadLine();
            string binnr = Convert.ToString(Convert.ToInt32(hexnr, 16), 2);
            Console.WriteLine(hexnr+" ne binar eshte "+binnr);
        }
    }
}
