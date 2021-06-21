using System;
using System.Collections.Generic;
using System.Text;

namespace GeographyNow
{
    public abstract class GeographicEntity
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public int Citizens { get; set; }

        public override string ToString()
        {
            return $"Country name: {Name}, country area: {Area}, country citizens quantity: {Citizens}";
        }
    }
}
