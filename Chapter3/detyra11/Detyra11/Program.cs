using System;


namespace _11.FindInAGivenValueGivenBitNumber
{
    class Program
    {
        static void Main()
        {
            byte value = 0;
            int i;
            byte p;
            Console.Write("Enter the integer number i:");
            bool isiInt = int.TryParse(Console.ReadLine(), out i);
            Console.Write("Enter the position of the bit p:");
            bool isbByte = byte.TryParse(Console.ReadLine(), out p);

            if (isiInt && isbByte && p < 32)
            {
                int mask = 1 << p;
                if ((i & mask) == mask)
                {
                    value = 1;
                }
                Console.WriteLine("value={0}", value);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
