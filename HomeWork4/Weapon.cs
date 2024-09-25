using System;

namespace HomeWork4
{
    public class Weapon
    {
        private string Name { get;  }
        private float MinDamage { get; set; }
        private float MaxDamage { get; set; }
        public Weapon(string name)
        {
            Name = name;
        }
        public Weapon(string name, float minDamage, float maxDamage): this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }

        public float GetDamage()
        {
            return (MinDamage + MaxDamage) / 2;
        }

        private void SetDamageParams(float minDamage, float maxDamage)
        {
            if (minDamage > maxDamage)
            {
                Console.WriteLine("Cообщение о некорректных входных данных для оружия: " + Name);
                MinDamage = maxDamage;
                MaxDamage = minDamage;
            }
            else
            {
                MinDamage = minDamage;
                MaxDamage = maxDamage;
            }

            if (MinDamage < 1f)
            {
                Console.WriteLine("Установка минимального значения для оружия: " + Name + "  форсированна. Значение по умолчанию: 1");
                MinDamage = 1f;
            }

            if (MaxDamage <= 1f)
            {
                Console.WriteLine("Установка максимального значения для оружия: " + Name + "  форсированна. Значение по умолчанию: 10");
                MaxDamage = 10f;
            }
        }

    }
}