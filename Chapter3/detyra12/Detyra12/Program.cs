using System;

namespace _10.CheckIfaBitInIntIs0or1
{
    class Program
    {
        static void Main()
        {
            bool isDigit1 = false;
            byte p;
            int v;
            Console.Write("Enter the position of the bit p:");
            bool ispByte = byte.TryParse(Console.ReadLine(), out p);
            Console.Write("Enter the integer number v:");
            bool isvInt = int.TryParse(Console.ReadLine(), out v);

            if (ispByte && isvInt && p < 32)
            {
                int mask = 1 << p;
                if ((v & mask) == mask)
                {
                    isDigit1 = true;
                }
                Console.WriteLine("Is bit{0} of intiger {1} equal to 1?:{2}", p, v, isDigit1);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
