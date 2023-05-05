using System;

namespace Program
{
    class FactorialTask
    {
        static long Factorial(int num)
        {
            return num == 0 || num == 1 ? 1 : num * Factorial(num - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(14));
            Console.WriteLine(Factorial(0));
            Console.WriteLine(Factorial(20));
        }
    }
}