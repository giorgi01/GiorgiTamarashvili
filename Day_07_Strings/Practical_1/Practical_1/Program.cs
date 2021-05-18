using System;

namespace Practical_1
{
    class Program
    {
        // მესმის ამ და მესამე ფუნქციის სახელი რომ არაა შესაბამისი მაგრამ უკეთესი პირობიდან გამომდინარე ვერ მოვიფიქრე :d
        static int GetVowelsCount(string text, bool vowel = true)
        {
            // vowel = false ==> get consonants
            // ამ ფუნქციის გაკეთება შეგვეძლო შემდეგი პარამეტრებითაც string text, string type = "vowel"
            
            string vowels = "AEIOUaeiou";

            if (vowel)
            {
                int counter = 0;
                foreach (char character in text)
                {
                    if (vowels.Contains(character)) counter += 1;
                }
                return counter;
            }
            else
            {
                int counter = 0;
                foreach (char character in text)
                {
                    if (!vowels.Contains(character) && IsAlpha(character)) counter += 1;
                }
                return counter;
            }
        }

        // ეს დამატებითი ფუნქცია შევქმენი უკედ კითხვადობისთვის, ისე შეგვეძლო ზემოთ if-ში პირდაპირ სთეითმენთი ჩაგვესვა
        static bool IsAlpha(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        static void PrintVowels(string text, bool vowel = true)
        {
            string vowels = "AEIOUaeiou";

            if (vowel)
            {
                Console.Write("Vowels: ");
                foreach (char character in text)
                {
                    if (vowels.Contains(character))
                        Console.Write(character + " ");
                }
            }
            else
            {
                Console.Write("Consonants: ");
                foreach (char character in text)
                {
                    if (!vowels.Contains(character) && IsAlpha(character))
                        Console.Write(character + " ");
                }
            }
            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            string text = "Hello, world!";

            int vowelsCount = GetVowelsCount(text);
            int consonantsCount = GetVowelsCount(text, vowel: false); // vowel: false ამ სტილით ჩავწერე რათა უკედ იყოს აღქმადი რომ აქ ხმოვანს არ ითვლის

            Console.WriteLine("Vowel count: " + vowelsCount);
            PrintVowels(text);

            Console.WriteLine("Consonants count: " + consonantsCount);
            PrintVowels(text, vowel: false);                          // '---' ანალოგიურად
        }
    }
}
