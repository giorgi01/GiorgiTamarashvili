using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeographyNow
{
    public static class Menu
    {
        private static int GetUserChoice()
        {
            Console.WriteLine("1. Search Country, 2. Search City");
            return int.Parse(Console.ReadLine());
        }

        private static string GetGeoEntityFromUser(string entityName)
        {
            Console.WriteLine($"Enter {entityName} name");
            return Console.ReadLine();
        }

        public static GeographicEntity GetGeographicEntity()
        {
            int choice = GetUserChoice();
            if (choice == 1)
            {
                List<Country> countires = GetCountries();
                string countryName = GetGeoEntityFromUser("country");
                foreach (var country in countires)
                    if (country.Name.Equals(countryName)) return country;
            }
            else if (choice == 2)
            {
                List<City> cities = GetCities();
                string cityName = GetGeoEntityFromUser("city");
                foreach (var city in cities)
                    if (city.Name.Equals(cityName)) return city;
            }
            return null;
        }

        private static List<City> GetCities()
        {
            List<City> cities = new List<City>();
            using (StreamReader sr = new StreamReader("Cities.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var cityProps = line.Split('|');

                    string name = cityProps[0];
                    double area = double.Parse(cityProps[1]);
                    int citizens = int.Parse(cityProps[2]);
                    bool isCapital = bool.Parse(cityProps[3]);
                    Country country = new Country(cityProps[4]);

                    City city = new City(name, area, citizens, isCapital, country);
                    cities.Add(city);
                    country.Cities.Add(city);
                }
            }

            return cities;
        }

        private static List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();
            var cities = GetCities();
            using (StreamReader sr = new StreamReader("Cities.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var cityProps = line.Split('|');
                    string countryName = cityProps[4];
                    var countryCities = new List<City>();
                    foreach (var city in cities)
                    {
                        if (city.Country.Name == countryName)
                        {
                            countryCities.Add(city);
                        }
                    }
                    Country country = new Country(countryName, countryCities);
                    countries.Add(country);
                }
            }

            return countries;
        }
    }
}
