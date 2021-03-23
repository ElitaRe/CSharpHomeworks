
using System;

namespace detyra8
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";
            object object1 = string1 + " " + string2;
            string string3 = object1.ToString();
            Console.WriteLine(string3);
        }
    }
}
