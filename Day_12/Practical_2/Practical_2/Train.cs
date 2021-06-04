using Practical_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public class Train : PublicTransport, ICarrier
    {
        public Train(Engine engine, int seats)
        {
            Engine = engine;
            PassengerSeats = seats;
        }

        public override void Carry()
        {
            Console.WriteLine($"This train carries {PassengerSeats} passenger");
        }
    }
}
