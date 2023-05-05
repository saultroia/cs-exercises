using System;

namespace Program
{
    class WordsTask
    {
        static int numberOfWords(string str)
        {
            int numberOfWords = 0;
            for (int i = 1; i < str.Length; i++)
            {
                numberOfWords = (char.IsWhiteSpace(str[i]) ? numberOfWords + 1 : numberOfWords);
            }

            return numberOfWords + 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfWords("Abyssus abyssum invocat"));
            Console.WriteLine(NumberOfWords("Febris amatoria"));
            Console.WriteLine(NumberOfWords("Nimbus"));                                                      
        }
    }
}