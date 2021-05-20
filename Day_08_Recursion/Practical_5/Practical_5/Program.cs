using System;

namespace Practical_5
{
    class Program
    {

        static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            if (word.Length == 1)
            {
                return true;
            }
            else if (word.Substring(0, 1) == word.Substring(word.Length - 1))
            {
                if (word.Length > 3)
                    return IsPalindrome(word.Substring(1, word.Length - 2));
                else
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            string wordFirst = "ABKBA";
            Console.WriteLine($"Is {wordFirst} palindrome? {IsPalindrome(wordFirst)}");
            
            string wordSecond = "ABBCA";
            Console.WriteLine($"Is {wordSecond} palindrome? {IsPalindrome(wordSecond)}");
        }
    }
}
