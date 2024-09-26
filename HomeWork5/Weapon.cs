using System;

namespace HomeWork5
{
    public class Weapon
    {
        public string Name { get; }
        public Interval DamageInterval { get; }
        
        public Weapon(string name)
        {
            Name = name;
        }
        public Weapon(string name, float minDamage, float maxDamage): this(name)
        {
            DamageInterval = new Interval(minDamage, maxDamage);
        }

        public float GetDamage()
        {
            return DamageInterval.Get;
        }

    }
}