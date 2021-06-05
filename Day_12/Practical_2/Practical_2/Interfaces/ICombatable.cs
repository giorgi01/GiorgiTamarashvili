namespace Practical_2.Interfaces
{
    public interface ICombatable
    {
        Weapon MountedWeapon { get; set; }

        void Combat();
    }
}