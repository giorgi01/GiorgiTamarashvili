using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_1
{
    class Cat
    {
        private string _name;
        private int _age;
        private int _catRation = 10;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Breed { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                    _age = value;
            }
        }
        public bool Gender { get; set; }

        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }

        public void Eat(int grams)
        {
            Console.WriteLine(_name + " starts eating.");
            while (grams > 0)
            {
                Console.WriteLine("Eating...");
                grams -= _catRation;
            }
            Console.WriteLine(_name + " finished eating.");
        }
    }
}
