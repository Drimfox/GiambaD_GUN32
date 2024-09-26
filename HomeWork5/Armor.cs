namespace HomeWork5
{

    public abstract class Armor
    {
        public class Helm
        {
            private float _armorValue;
            public string Name { get; }
            public float Armor
            {
                get => _armorValue;
                private set
                {
                    if (value < 0f) 
                    {
                        _armorValue = 0f;
                        Console.WriteLine("Armor Helm не может быть меньше 0. Установленно 0.");
                    } 
                    else if (value > 1f) 
                    {
                        _armorValue = 1f;
                        Console.WriteLine("Armor Helm не может быть больше 1. Установленно 1.");
                    } 
                    else 
                    {
                        _armorValue = value;
                    }
                }
            }

            public Helm() : this("Helm", 0) { }
            public Helm( float armor) : this("Helm", armor) { }
            public Helm(string name, float armor)
            {
                Name = name;
                Armor = armor;
            }
        }
        
        public class Shell
        {
            private float _armorValue;
            public string Name { get; private set; }
            public float Armor
            {
                get => _armorValue;
                private set
                {
                    if (value < 0f) 
                    {
                        _armorValue = 0f;
                        Console.WriteLine("Armor Shell не может быть меньше 0. Установленно 0.");
                    } 
                    else if (value > 1f) 
                    {
                        _armorValue = 1f;
                        Console.WriteLine("Armor Shell не может быть больше 1. Установленно 1.");
                    } 
                    else 
                    {
                        _armorValue = value;
                    }
                }
            }

            public Shell() : this("Shell", 0) { }
            public Shell( float armor) : this("Shell", armor) { }
            public Shell(string name, float armor)
            {
                Name = name;
                Armor = armor;
            }
        }
        
        public class Boots
        {
            private float _armorValue;
            public string Name { get; private set; }
            public float Armor
            {
                get => _armorValue;
                private set
                {
                    if (value < 0f) 
                    {
                        _armorValue = 0f;
                        Console.WriteLine("Armor Boots не может быть меньше 0. Установленно 0.");
                    } 
                    else if (value > 1f) 
                    {
                        _armorValue = 1f;
                        Console.WriteLine("Armor Boots не может быть больше 1. Установленно 1.");
                    } 
                    else 
                    {
                        _armorValue = value;
                    }
                }
            }

            public Boots() : this("Boots", 0) { }
            public Boots( float armor) : this("Boots", armor) { }
            public Boots(string name, float armor)
            {
                Name = name;
                Armor = armor;
            }
        }
    }
}