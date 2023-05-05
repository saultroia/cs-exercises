using System;

namespace Program
{
    class TheCubeOfTask
    {
        public static double TheCubeOf(double num)
        {
            return num * num * num;
        }

        public static void Main()
        {
            Console.WriteLine(TheCubeOf(15));   
            Console.WriteLine(TheCubeOf(0.25)); 
            Console.WriteLine(TheCubeOf(-15)); 
            Console.WriteLine(TheCubeOf(-0.5));
        }
    }
}