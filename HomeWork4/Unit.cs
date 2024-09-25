namespace HomeWork4
{
    public class Unit
    {
        public string Name { get; private set; }
        private float Health { get; set; }
        private const float BaseDamage = 5f;
        private Weapon Weapon { get; set; }
        public Armor.Helm Helm { get; private set; }
        public Armor.Shell Shell { get; private set; }
        public Armor.Boots Boots { get; private set; }
        
        public Unit(): this( "Unknown Unit",10){}
        public Unit(string name, float health )
        {
            Name = name;
            InitializeHealth(health);
        }

        public float RealHealth()
        {
            return Health * (1f + Helm.Armor + Shell.Armor + Boots.Armor);
        }

        public bool SetDamage(float damage)
        {
            Health -= damage / (Helm.Armor + Shell.Armor + Boots.Armor);
            if (Health > 0) return false;
            return true;
        }
        public void EquipWeapon(Weapon weapon)
        {
            Weapon = weapon;
        }
        public void EquipHelm(Armor.Helm helm)
        {
            Helm = helm;
        }
        public void EquipShell(Armor.Shell shell)
        {
            Shell = shell;
        }
        public void EquipBoots(Armor.Boots boots)
        {
            Boots = boots;
        }
        public float Damage(Weapon weapon)
        {
            return weapon.GetDamage() + BaseDamage;
        }
        public float Damage()
        {
            return  BaseDamage;
        }

        private void InitializeHealth(float health)
        {
            if (health < 10)
            {
                Health = 10;
            } 
            else if (health > 100)
            {
                Health = 100;
            }
            else
            {
                Health = health;
            }
        }
    }
}