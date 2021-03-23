using System;

namespace detyra9
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "The \"use\" of quotations causes difficulties.";
            string string2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties.";
            Console.WriteLine(string1);
            Console.WriteLine(string2);
        }
    }
}
