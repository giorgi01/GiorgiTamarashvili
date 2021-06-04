namespace Practical_2
{
    public class OffRoadCar : Vehicle
    {
        public bool FourWD { get; set; }
        public OffRoadCar(Engine engine, bool fourWD)
        {
            Engine = engine;
            FourWD = fourWD;
        }
    }
}