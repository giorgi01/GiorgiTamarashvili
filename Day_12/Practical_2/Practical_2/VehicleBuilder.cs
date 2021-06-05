using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    static class VehicleBuilder
    {
        public static Train BuilTrain()
        {
            Console.WriteLine("Building a Bus");
            Engine engine = BuildEngine();

            Console.Write("Enter passenger seats count: ");
            int seats = int.Parse(Console.ReadLine());

            return new Train(engine, seats);
        }

        public static Bus BuildBus()
        {
            Console.WriteLine("Building a Bus");
            Engine engine = BuildEngine();

            Console.Write("Enter passenger seats count: ");
            int seats = int.Parse(Console.ReadLine());

            return new Bus(engine, seats);
        }

        public static BTR BuildBTR()
        {
            Console.WriteLine("Building a BTR");
            Engine engine = BuildEngine();
            
            Console.Write("Enter BTR durability: ");
            int durability = int.Parse(Console.ReadLine());
            
            Console.Write("Enter seats number: ");
            int seats = int.Parse(Console.ReadLine());

            return new BTR(engine, durability, seats);
        }

        public static Tank BuildTank()
        {
            Console.WriteLine("Building a tank");
            Engine engine = BuildEngine();
            Weapon weapon = BuildWeapon();
            Console.Write("Enter tank durability: ");
            int durability = int.Parse(Console.ReadLine());

            return new Tank(engine, durability, weapon);
        }

        private static Engine BuildEngine()
        {
            Console.WriteLine("Let's build engine first!");
            Console.Write("Enter horsepower: ");
            int hp = int.Parse(Console.ReadLine());

            Console.Write("Enter cylinders count: ");
            int cylinders = int.Parse(Console.ReadLine());

            Console.Write("Enter fuel type: ");
            Enum.TryParse(Console.ReadLine(), out FuelType fuelType);

            return new Engine(hp, cylinders, fuelType);
        }

        private static F1Engine BuildF1Engine()
        {
            Console.WriteLine("Let's build F1 engine first!");
            Console.Write("Enter horsepower: ");
            int hp = int.Parse(Console.ReadLine());

            Console.Write("Enter cylinders count: ");
            int cylinders = int.Parse(Console.ReadLine());

            Console.Write("Enter fuel type: ");
            Enum.TryParse(Console.ReadLine(), out FuelType fuelType);

            Console.Write("Enter engine type: ");
            Console.WriteLine("Available engine types: MGUK, MGUH ");
            Enum.TryParse(Console.ReadLine(), out F1EngineType engineType);

            return new F1Engine(hp, cylinders, fuelType, engineType);
        }

        public static OffRoadCar BuildOffRoadCar()
        {
            Console.WriteLine("Building OffRoad car");
            Engine engine = BuildEngine();

            Console.Write("Do you want to add 4WD option to your car? ");
            string answer = Console.ReadLine();

            if (answer.Equals("Yes"))
            {
                return new OffRoadCar(engine, true);
            }
            else
            {
                return new OffRoadCar(engine, false);
            }
        }

        public static Sedan BuildSedan()
        {
            Console.WriteLine("Building Sedan");
            Engine engine = BuildEngine();

            Console.Write("Enter car class: ");
            Console.WriteLine("available classes: Business, Econom, Family, BusinessLux");
            Enum.TryParse(Console.ReadLine(), out CarClass carClass);

            return new Sedan(engine, carClass);
        }

        public static Motorcycle BuildMotorcycle()
        {
            Console.WriteLine("Building Motorcycle");
            Engine engine = BuildEngine();

            Console.Write("Do you want to add third wheel? ");
            string answer = Console.ReadLine();
            if (answer.Equals("Yes"))
            {
                return new Motorcycle(engine, true);
            }
            else
            {
                return new Motorcycle(engine, false);
            }
        }

        public static Vehicle BuildFormulaOneCar()
        {
            Console.WriteLine("Let's build Formula 1 car");
            F1Engine engine = BuildF1Engine();

            return new FormulaOneCar(engine);
        }

        private static Weapon BuildWeapon()
        {
            Console.WriteLine("Let's build weapon");
            Console.Write("Enter damage: ");
            int damage = int.Parse(Console.ReadLine());
            Console.Write("Enter reload time: ");
            double reloadTime = double.Parse(Console.ReadLine());

            return new Weapon(damage, reloadTime);
        }
    }
}
