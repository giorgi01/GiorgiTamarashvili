using System;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your day of birth");
            short day = short.Parse(Console.ReadLine());

            Console.WriteLine("Enter your month of birth");
            string month = Console.ReadLine();
            string zodiacSign;

            switch (month)
            {
                case "January":
                    if (day < 20)
                        zodiacSign = "Capricorn";
                    else
                        zodiacSign = "Aquarius";
                    break;
                case "February":
                    if (day < 19)
                        zodiacSign = "Aquarius";
                    else
                        zodiacSign = "Pisces";
                    break;
                case "March":
                    if (day < 21)
                        zodiacSign = "Pisces";
                    else
                        zodiacSign = "Aries";
                    break;
                case "April":
                    if (day < 20)
                        zodiacSign = "Aries";
                    else
                        zodiacSign = "Taurus";
                    break;
                case "May":
                    if (day < 21)
                        zodiacSign = "Taurus";
                    else
                        zodiacSign = "Gemini";
                    break;
                case "June":
                    if (day < 21)
                        zodiacSign = "Gemini";
                    else
                        zodiacSign = "Cancer";
                    break;
                case "July":
                    if (day < 23)
                        zodiacSign = "Cancer";
                    else
                        zodiacSign = "Leo";
                    break;
                case "August":
                    if (day < 23)
                        zodiacSign = "Leo";
                    else
                        zodiacSign = "Virgo";
                    break;
                case "September":
                    if (day < 23)
                        zodiacSign = "Virgo";
                    else
                        zodiacSign = "Libra";
                    break;
                case "October":
                    if (day < 23)
                        zodiacSign = "Libra";
                    else
                        zodiacSign = "Scorpio";
                    break;
                case "November":
                    if (day < 22)
                        zodiacSign = "Scorpio";
                    else
                        zodiacSign = "Saggitarius";
                    break;
                case "December":
                    if (day < 22)
                        zodiacSign = "Saggitarius";
                    else
                        zodiacSign = "Capricorn";
                    break;
                default: // default დავწერე მხოლოდ იმიტომ რომ switch-მა მომთხოვა
                    zodiacSign = "Unknown";
                    break;
            }
            Console.WriteLine($"{day} {month} is {zodiacSign}");
        }
    }
}
