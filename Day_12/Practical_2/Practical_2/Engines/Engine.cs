namespace Practical_2
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public int Cylinders { get; set; }
        public FuelType FuelType { get; set; }
        public Engine(int hp, int cylinders, FuelType fuelType)
        {
            HorsePower = hp;
            Cylinders = cylinders;
            FuelType = fuelType;
        }
    }
}