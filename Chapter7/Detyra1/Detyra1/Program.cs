using System;

namespace Detyra1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[21];

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
