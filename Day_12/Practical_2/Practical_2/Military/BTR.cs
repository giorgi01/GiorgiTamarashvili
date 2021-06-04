using Practical_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    class BTR : MilitaryVehicle, IDamageable, ICarrier
    {
        public int PassengerSeats { get; set; }
        public int SeatsOccupied { get; set; }

        public BTR(Engine engine, int durability, int seats)
        {
            Engine = engine;
            Durability = durability;
            PassengerSeats = seats;
            MilitaryVehicleType = MilitaryVehicleType.ArmouredPersonelCarrier;
        }

        public void TakeDamage(int damage)
        {
            Durability -= damage;
            Console.WriteLine($"BTR gets a damage, durability reduced by {damage}");
        }

        public void Carry()
        {
            Console.WriteLine($"This transport can carry {PassengerSeats} passenger");
        }

        public bool AvailableSeat()
        {
            if (PassengerSeats == SeatsOccupied)
                return false;
            return true;
        }
    }
}
