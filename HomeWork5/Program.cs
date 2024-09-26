
using System.Diagnostics;

namespace HomeWork5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new();
            
            Console.WriteLine("Подготовка к бою: Создание бойцов!");

            var combat = new Combat();

            var firstUnitGendolf = new Unit("Gendolf", random.Next(100) + 1);
            var secondUnitSaruman = new Unit("Saruman", random.Next(100) + 1);

            var fenixWeapon = new Weapon("Fenix", (float)random.Next(5) + 1, (float)random.Next(30) + 1);
            var staffWeapon = new Weapon("Fenix", (float)random.Next(5) + 1, (float)random.Next(30) + 1);
            var bootsOfTravel = new Armor.Boots ("bootsOfTravel", random.NextSingle());
            var shapkaUshanka = new Armor.Helm ("shapkaUshanka",random.NextSingle());
            
            firstUnitGendolf.EquipWeapon(fenixWeapon);
            firstUnitGendolf.EquipHelm(shapkaUshanka);
            secondUnitSaruman.EquipWeapon(staffWeapon);
            secondUnitSaruman.EquipBoots(bootsOfTravel);

            if (firstUnitGendolf.Weapon != null)
            {
                Console.WriteLine(
                    "Боец №1! Имя: {0}, кол-во здоровья: {1}, общий показатель брони: {2}, Максимальный урон: {3}, Минимальный урон: {4}",
                    firstUnitGendolf.Name,
                    firstUnitGendolf.Health,
                    firstUnitGendolf.Armor,
                    firstUnitGendolf.Weapon.DamageInterval.Max + 5,
                    firstUnitGendolf.Weapon.DamageInterval.Min);
            }

            if (secondUnitSaruman.Weapon != null)
            {
                Console.WriteLine(
                    "Боец №2! Имя: {0}, кол-во здоровья: {1}, общий показатель брони: {2}, Максимальный урон: {3}, Минимальный урон: {4}",
                    secondUnitSaruman.Name,
                    secondUnitSaruman.Health,
                    secondUnitSaruman.Armor,
                    secondUnitSaruman.Weapon.DamageInterval.Max + 5,
                    secondUnitSaruman.Weapon.DamageInterval.Min);
            }

            Console.WriteLine("БОЙ!!");
            combat.StartCombat(firstUnitGendolf,secondUnitSaruman);
            combat.ShowResults();
        }
    }
}