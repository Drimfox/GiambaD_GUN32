

namespace HomeWork5
{
    public class Unit
    {
        private const float BaseDamage = 5f;
        private const float MinArmor = 0f;
        private const float MaxArmor = 1f;
        private const float DefaultHealth = 10f;
        private const string DefaultName = "Unknown Unit";

        private Armor.Helm? _helm;
        private Armor.Shell? _shell;
        private Armor.Boots? _boots;
        
        public string Name { get; }
        public float Health { get; private set; }
        public float Damage => Weapon?.GetDamage() + BaseDamage ?? BaseDamage;
        public float Armor => (float)Math.Clamp(Math.Round((_helm?.Armor ?? 0f) + (_shell?.Armor ?? 0f) + (_boots?.Armor ?? 0f),2), MinArmor,MaxArmor);
        public Weapon? Weapon { get; private set; }


        public Unit() : this(DefaultName) { }
        public Unit(string name)
        {
            Name = name;
            Health = DefaultHealth;
        }
        public Unit(string name, float health)
        {
            Name = name;
            Health = health;
        }
        
        public float RealHealth()
        {
            return Health * (1 + Armor);
        }

        public bool SetDamage(float damage)
        {
            Health = Health - (damage * Armor);
            if (Health > 0) return false;
            return true;
        }
        public void EquipWeapon(Weapon weapon)
        {
            Weapon = weapon;
        }
        public void EquipHelm(Armor.Helm helm)
        {
            _helm = helm;
        }
        public void EquipShell(Armor.Shell shell)
        {
            _shell = shell;
        }
        public void EquipBoots(Armor.Boots boots)
        {
            _boots = boots;
        }
    }
}