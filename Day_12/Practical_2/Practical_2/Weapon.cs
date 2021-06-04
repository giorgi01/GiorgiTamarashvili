namespace Practical_2
{
    public class Weapon
    {
        public int Damage { get; set; }
        public double ReloadTime { get; set; } // in seconds

        public Weapon(int damage, double reloadTime)
        {
            Damage = damage;
            ReloadTime = reloadTime;
        }
    }
}