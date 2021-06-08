using System;

namespace Detyra25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some words");
            string strng = Console.ReadLine();
            string[] str = strng.Split(",");

            Array.Sort(str);
            foreach (string arr in str)
            {
                Console.WriteLine(arr);
            }
            Console.ReadLine();
        }
    }
}
