using System;

namespace Program
{
    class IfYearIsLeapTask
    {
        static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IfYearIsLeap(2022)); 
            Console.WriteLine(IfYearIsLeap(1819)); 
            Console.WriteLine(IfYearIsLeap(2000)); 
            Console.WriteLine(IfYearIsLeap(1612)); 
            Console.WriteLine(IfYearIsLeap(1982)); 
        }
    }
}