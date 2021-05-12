using System;

namespace Detyra_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var mo = new ManagementObject(@"\root\cimv2:Win32_OperatingSystem@"
);
            var lastBootUp = ManagementDateTimeConverter.ToDateTime(mo["LastBootupTime"
                ].Tostring());
            Console.WriteLine(DateTime.Now.ToUniversalTime() - lastBootUp.TouniversalTime());

        }
    }
}