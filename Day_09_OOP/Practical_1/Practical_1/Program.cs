using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitten = new Cat();
            Console.WriteLine("Creating Cat object");

            Console.Write("Enter name: ");
            kitten.Name = Console.ReadLine();

            Console.Write("Enter breed: ");
            kitten.Breed = Console.ReadLine();

            Console.Write("Enter age: ");
            kitten.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter sex: ");
            string gender = Console.ReadLine().ToUpper();

            if (gender == "MALE")
                kitten.Gender = true;
            else
                kitten.Gender = false;
            
            Console.WriteLine("Cat object created.");

            Console.Write("Enter food weight in grams: ");
            int foodGrams = int.Parse(Console.ReadLine());
            kitten.Eat(foodGrams);

            Console.Write("Enter meowing count: ");
            int meowingCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < meowingCount; i++)
            {
                kitten.Meow();
            }
        }
    }
}
