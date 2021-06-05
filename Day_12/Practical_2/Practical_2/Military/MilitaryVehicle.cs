using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public abstract class MilitaryVehicle : Vehicle
    {
        public int Durability { get; set; } // hp
        public MilitaryVehicleType MilitaryVehicleType { get; set; }

        public override void Describe()
        {
            Console.WriteLine($"This vehicle is {MilitaryVehicleType} type, whichs horsepower is {Engine.HorsePower}, with {Engine.Cylinders} cylinders");
            Console.WriteLine($"Vehicle's durability is {Durability}, Fuel type is - {Engine.FuelType}");
        }
    }
}
