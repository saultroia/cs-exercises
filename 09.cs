using System;

namespace Program
{
    class GreaterNumberTask
    {
        public static double GreaterNumber(double x, double y)
        {
            return Math.Max(x, y);
        }

        public static void Main()
        {
            Console.WriteLine(GreaterNumber(25.5, 120));
            Console.WriteLine(GreaterNumber(-1552, -9133));
            Console.WriteLine(GreaterNumber(-543, -543));
        }
    }
}