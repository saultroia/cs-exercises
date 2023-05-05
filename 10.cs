using System;

namespace Program
{
    class IsPalindromeTask
    {
        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Madam"));                 
            Console.WriteLine(IsPalindrome("123454321"));  
            Console.WriteLine(IsPalindrome("Ut retro"));
            Console.WriteLine(IsPalindrome("Was it a car or a cat I saw")); 
            Console.WriteLine(IsPalindrome("Finis coronat opus")); 
            Console.WriteLine(IsPalindrome("X"));
        }
    }
}