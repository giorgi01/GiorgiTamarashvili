using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    public class Motorcycle : Vehicle
    {
        public bool ThreeWheeled { get; set; }

        public Motorcycle(Engine engine, bool threeWheleed)
        {
            Engine = engine;
            ThreeWheeled = threeWheleed;
        }
    }
}
