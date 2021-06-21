using System;
using System.Collections.Generic;
using System.Text;

namespace GeographyNow
{
    public class Country : GeographicEntity
    {
        public List<City> Cities { get; set; } = new List<City>();

        public Country(string name)
        {
            Name = name;
        }

        public Country(string name, List<City> cities)
        {
            Name = name;
            Cities = cities;
            Area = 0;
            Citizens = 0;
            foreach (City city in cities)
            {
                Area += city.Area;
                Citizens += city.Citizens;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(", Cities: ");
            foreach (City city in Cities)
            {
                sb.Append(city.Name);
                if (city.IsCapital) sb.Append(" (Capital)");
                sb.Append(", ");
            }
            return Convert.ToString(sb);
        }
    }
}