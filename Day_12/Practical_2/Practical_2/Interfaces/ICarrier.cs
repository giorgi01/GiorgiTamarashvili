using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2.Interfaces
{
    public interface ICarrier
    {
        int PassengerSeats { get; set; }
        int SeatsOccupied { get; set; }

        void Carry();
        bool AvailableSeat();
    }
}
