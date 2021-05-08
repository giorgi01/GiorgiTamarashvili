using System;

namespace Practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year");
            int year = int.Parse(Console.ReadLine());
            string animal;
            int animalCycleIndex = year % 12;

            switch (animalCycleIndex)
            {
                case 0:
                    animal = "Monkey"; 
                    break;
                case 1:
                    animal = "Rooster";
                    break;
                case 2:
                    animal = "Dog";
                    break;
                case 3:
                    animal = "Pig";
                    break;
                case 4:
                    animal = "Rat";
                    break;
                case 5:
                    animal = "Ox";
                    break;
                case 6:
                    animal = "Tiger";
                    break;
                case 7:
                    animal = "Rabbit";
                    break;
                case 8:
                    animal = "Dragon";
                    break;
                case 9:
                    animal = "Snake";
                    break;
                case 10:
                    animal = "Horse";
                    break;
                default:
                    animal = "Sheep";
                    break;
            }
            Console.WriteLine($"{year} was {animal} year");
        }
    }
}
