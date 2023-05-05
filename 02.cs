using System;

namespace Program
{
    class HowManyDaysTask
    {
        public static int HowManyDays(DateTime dateInThePast, DateTime dateNow)
        {
            return (dateNow - dateInThePast).Days;
        }

        public static void Main()
        {
            Console.WriteLine(HowManyDays(new DateTime(2011, 10, 5), DateTime.Now));
        }
    }
}