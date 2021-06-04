using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public abstract class Vehicle
    {
        public Engine Engine { get; set; }

        public virtual void Move()
        {
            Console.WriteLine("Vehicle is moving");
        }

        public virtual void Describe()
        {
            Console.WriteLine($"Vehicle's horsepower is {Engine.HorsePower} with {Engine.Cylinders} cylinders, Fuel type is {Engine.FuelType}");
        }
    }
}
