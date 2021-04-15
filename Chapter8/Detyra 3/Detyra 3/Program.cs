﻿using System;

namespace Detyra_3
{
    class Program
    {
        static void conversion(string value)
        {
            Console.WriteLine("{0} to decimal is {1}.",
                value, Convert.ToInt32(value, 16));
            Console.WriteLine("{0} to decimal is {1}.\n", value,
                Convert.ToString(Convert.ToInt32(value, 16), 2));
        }

        static void Main(string[] args)
        {
            conversion("2A3E");
            conversion("FA");
            conversion("FFFF");
            conversion("5A0E9");
        }
    }
}
