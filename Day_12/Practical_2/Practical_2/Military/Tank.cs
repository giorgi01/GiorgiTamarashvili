using Practical_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2
{
    class Tank : MilitaryVehicle, IDamageable, ICombatable
    {
        public Weapon MountedWeapon { get; set; }
        public Tank(Engine engine, int durability, Weapon mountedWeapon)
        {
            Engine = engine;
            Durability = durability;
            MountedWeapon = mountedWeapon;
            MilitaryVehicleType = MilitaryVehicleType.ArmouredCombat;
        }

        public void Combat()
        {
            Console.WriteLine($"Tank shoots the weapon, which damages opponent by {MountedWeapon.Damage}");
        }

        public void TakeDamage(int damage)
        {
            Durability -= damage;
            Console.WriteLine($"Tank gets a damage, durability reduced by {damage}");
        }
    }
}
