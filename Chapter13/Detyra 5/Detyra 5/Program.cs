﻿using System;
public class exercise19
{
    public static void Main()
    {
        string str1;
        string findstring;
        int strt = 0;
        int cnt = -1;
        int idx = -1;

        Console.Write("Input the string : ");
        str1 = Console.ReadLine();
        Console.Write("Input the string to be searched for : ");
        findstring = Console.ReadLine();


        while (strt != -1)
        {
            strt = str1.IndexOf(findstring, idx + 1);
            cnt += 1;
            idx = strt;
        }
        Console.Write("The string '{0}' occurs " + cnt + " times.\n", findstring);
    }
}