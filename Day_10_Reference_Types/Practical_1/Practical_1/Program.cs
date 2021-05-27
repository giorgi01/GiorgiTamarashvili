using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            people[0] = new Person("Jemal", 22, "01000023000");
            people[1] = new Person("James", 23, "782130000012");
            people[2] = new Person("Jelena", 24, "123012400013");
            
            Home firstHome = new Home("Some address", "Tbilisi");
            Home secondHome = new Home("Some address", "NYC");
            Home thirdHome = new Home("Some address", "Moscow");

            people[0].Home = firstHome;
            people[1].Home = secondHome;
            people[2].Home = thirdHome;
        }
    }
}
