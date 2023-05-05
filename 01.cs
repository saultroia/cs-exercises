using System;

namespace Program
{
    class NegativePositiveTask
    {
        public static double NegativePositive(double num)
        {
            return num < 0 ? Math.Pow(num, 2) : Math.Sqrt(num);
        }

        public static void Main()
        {
            Console.WriteLine(NegativePositive(47395));
            Console.WriteLine(NegativePositive(-6.968));
            Console.WriteLine(NegativePositive(0));
            Console.WriteLine(NegativePositive(5.783));
            Console.WriteLine(NegativePositive(-59));
        }
    }
}