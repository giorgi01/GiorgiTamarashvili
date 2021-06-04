using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public class Sedan : Vehicle
    {
        public CarClass CarClass { get; set; }

        public Sedan(Engine engine, CarClass carClass)
        {
            Engine = engine;
            CarClass = carClass;
        }
    }
}
