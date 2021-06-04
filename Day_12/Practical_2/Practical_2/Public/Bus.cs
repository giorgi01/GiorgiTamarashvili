using Practical_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public class Bus : PublicTransport, ICarrier
    {

        public Bus(Engine engine, int seats)
        {
            Engine = engine;
            PassengerSeats = seats;
        }

        public override void Carry()
        {
            Console.WriteLine($"This bus carries {PassengerSeats} passenger");
        }
    }
}
