using Practical_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public abstract class PublicTransport : Vehicle, ICarrier
    {
        public int PassengerSeats { get; set; }
        public int SeatsOccupied { get; set; } = 0;

        public virtual bool AvailableSeat()
        {
            if (PassengerSeats == SeatsOccupied)
                return false;
            return true;
        }

        public abstract void Carry();
    }
}
