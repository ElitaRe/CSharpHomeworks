﻿
using System;

namespace Extra2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            int flg = 0;
            int i = 0, l1, l2, yn = 0;

            Console.Write("\n\nCompare two strings whether they are equal or not :\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the 1st string : ");
            str1 = Console.ReadLine();

            Console.Write("Input the 2nd string : ");
            str2 = Console.ReadLine();

            l1 = str1.Length;
            l2 = str2.Length;
            /*compare checking when they are equal in length*/
            if (l1 == l2)
            {
                for (i = 0; i < l1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        yn = 1;
                        i = l1;

                    }
                }
            }
            /*initialize the flage where they are equal, smaller and greater in length*/
            if (l1 == l2)
                flg = 0;
            else if (l1 > l2)
                flg = 1;
            else if (l1 < l2)
                flg = -1;
            /*display the message where the strings are same or smaller or greater*/
            if (flg == 0)
            {
                if (yn == 0)
                    Console.Write("\nThe length of both strings are equal and \nalso, both strings are same.\n\n");
                else
                    Console.Write("\nThe length of both strings are equal \nbut they are not same.\n\n");
            }
            else if (flg == -1)
            {
                Console.Write("\nThe length of the first string is smaller than second.\n\n");
            }
            else
            {
                Console.Write("\nThe length of the first string is greater than second.\n\n");
            }
        }
    }
}