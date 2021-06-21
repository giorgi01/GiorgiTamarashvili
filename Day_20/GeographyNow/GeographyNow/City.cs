using System;
using System.Collections.Generic;
using System.Text;

namespace GeographyNow
{
    public class City : GeographicEntity
    {
        public bool IsCapital { get; set; }
        public Country Country { get; set; }

        public City()
        {
        }

        public City(string name, double area, int citizens, bool isCapital, Country country)
        {
            Name = name;
            Area = area;
            Citizens = citizens;
            IsCapital = isCapital;
            Country = country;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(", ");
            sb.Append(Country.Name);
            if (IsCapital) sb.Append(" (Capital)");
            return Convert.ToString(sb);
        }
    }
}
