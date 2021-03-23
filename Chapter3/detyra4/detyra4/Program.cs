using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace detyra4
{
    class Program
    {
        static void Main()
        {
            bool is3Digit1 = false;
            Console.Write("Enter the number:");
            int number;
            bool isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber)
            {
                if ((number & 8) == 8)
                {
                    is3Digit1 = true;
                }
                Console.WriteLine("Is the third digit equal to 1?:{0}", is3Digit1);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}