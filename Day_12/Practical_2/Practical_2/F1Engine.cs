using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public class F1Engine : Engine
    {
        public F1EngineType EngineType { get; set; }
        public F1Engine(int hp, int cylinders, FuelType fuelType, F1EngineType engineType)
            : base(hp, cylinders, fuelType)
        {
            EngineType = engineType;
        }
    }
}
