namespace HomeWork4
{

    public abstract class Armor
    {
        public class Helm
        {
            public string Name { get; private set; }
            public float Armor { get; private set; }

            public Helm() : this("Helm", 0) { }
            public Helm( float armor) : this("Helm", armor) { }
            public Helm(string name, float armor)
            {
                Name = name;
                InitializeArmor(armor);
            }

            private void InitializeArmor(float armor)
            {
                if (armor > 1)
                {
                    Armor = 1;
                }
                else if(armor < 0)
                {
                    Armor = 0;
                }
                else
                {
                    Armor = armor;
                }
            }
        }
        
        public class Shell
        {
            public string Name { get; private set; }
            public float Armor { get; private set; }

            public Shell() : this("Shell", 0) { }
            public Shell( float armor) : this("Shell", armor) { }
            public Shell(string name, float armor)
            {
                Name = name;
                InitializeAromor(armor);
            }

            private void InitializeAromor(float armor)
            {
                if (armor > 1)
                {
                    Armor = 1;
                }
                else if(armor < 0)
                {
                    Armor = 0;
                }
                else
                {
                    Armor = armor;
                }
            }
        }
        
        public class Boots
        {
            public string Name { get; private set; }
            public float Armor { get; private set; }

            public Boots() : this("Boots", 0) { }
            public Boots( float armor) : this("Boots", armor) { }

            public Boots(string name, float armor)
            {
                Name = name;
                InitializeAromor(armor);
            }

            private void InitializeAromor(float armor)
            {
                if (armor > 1)
                {
                    Armor = 1;
                }
                else if(armor < 0)
                {
                    Armor = 0;
                }
                else
                {
                    Armor = armor;
                }
            }
        }
    }
}