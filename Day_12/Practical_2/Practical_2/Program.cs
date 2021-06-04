using System;

namespace Practical_2
{
    class Program
    {
        static Vehicle GetVehicle()
        {
            Console.WriteLine("What type of vehicle you want to build? ");
            Console.WriteLine("Available options: Military, Public, Standard, Sport");
            
            string vehicleType = Console.ReadLine();
            string transportType;

            switch (vehicleType)
            {
                case "Military":
                    
                    Console.WriteLine("What type of military transport do you want?");
                    Console.WriteLine("Available options: Tank, BTR");

                    transportType = Console.ReadLine();
                    if (transportType == "Tank")
                    {
                        return VehicleBuilder.BuildTank();
                    }
                    else
                    {
                        return VehicleBuilder.BuildBTR();
                    }
                case "Public":
                    
                    Console.WriteLine("What type of public transport do you want?");
                    Console.WriteLine("Available options: Bus, Train");

                    transportType = Console.ReadLine();
                    if (transportType == "Bus")
                    {
                        return VehicleBuilder.BuildBus();
                    }
                    else
                    {
                        return VehicleBuilder.BuilTrain();
                    }
                case "Standard":

                    Console.WriteLine("What type of standard transport do you want?");
                    Console.WriteLine("Available options: Sedan, Motorcycle");

                    transportType = Console.ReadLine();
                    if (transportType == "Sedan")
                    {
                        return VehicleBuilder.BuildSedan();
                    }
                    else
                    {
                        return VehicleBuilder.BuildMotorcycle();
                    }
                case "Sport":

                    Console.WriteLine("What type of sport transport do you want?");
                    Console.WriteLine("Available options: FormulaOneCar, OffRoad");

                    transportType = Console.ReadLine();
                    if (transportType == "FormulaOne")
                    {
                        return VehicleBuilder.BuildFormulaOneCar();
                    }
                    else
                    {
                        return VehicleBuilder.BuildOffRoadCar();
                    }
                default:
                    Console.WriteLine("Not valid input, so you are building Sedan");
                    return VehicleBuilder.BuildSedan();
            }
        }

        static void Main(string[] args)
        {
            Vehicle vehicle = GetVehicle();
            vehicle.Describe();
        }
    }
}
