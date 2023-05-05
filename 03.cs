using System;
using System.Linq;

namespace Program
{
    class DecryptNumberTask
    {
        public static void Main()
        {
            var chars = new char[] { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };

            var encryptedNumber = "#(@*%)$(&$*#&";

            var decryptedNumber = string.Join("", encryptedNumber.Select(c => Array.IndexOf(chars, c)));

            Console.WriteLine(decryptedNumber);
        }
    }
}