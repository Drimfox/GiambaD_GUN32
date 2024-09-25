using System;

namespace HomeWork4
{
    /*
     * При запуске программы выводится сообщение “Подготовка к бою:”;
Выводится сообщение с запросом: “Введите имя бойца:”. Далее ожидается ввод имени юнита;
Выводится сообщение с запросом: “Введите начальное здоровье бойца (10-100):”. Далее ожидается целое число в диапазоне от 10 до 100 включительно;
Выводится сообщение с запросом: “Введите значение брони шлема от 0, до 1:”. Далее ожидается число типа float в диапазоне от 0 до 1, включительно;
Выводится сообщение с запросом: “Введите значение брони кирасы от 0, до 1:”. Далее ожидается число типа float в диапазоне от 0 до 1, включительно;
Выводится сообщение с запросом: “Введите значение брони сапог от 0, до 1:”. Далее ожидается число типа float в диапазоне от 0 до 1, включительно;
Выводится сообщение с запросом: “Укажите минимальный урон оружия (0-20): “. Далее ожидается число типа float в диапазоне от 0 до 20 включительно;
Выводится сообщение с запросом: “Укажите максимальный урон оружия (20-40): “. Далее ожидается число типа float в диапазоне от 20 до 40 включительно;
На основе введенных данных создается экземпляр класса Unit для игрока;
В консоль выводится сообщение “Общий показатель брони равен: “. Далее выводится значение свойства Armor юнита;
В консоль выводится сообщение “Фактическое значение здоровья равно: “ . Далее выводится значение свойства RealHealth;
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            float heroHealth;
            float helmArmor;
            float shellArmor;
            float bootsArmor;
            float minWeaponDamage;
            float maxWeaponDamage;
            
            Console.WriteLine("Подготовка к бою:");
            
            Console.WriteLine("Введите имя бойца:");
            
            string heroName =  Console.ReadLine();
            
            do
            {
                Console.WriteLine("Введите начальное здоровье бойца (10-100): ");
            } while (!float.TryParse(Console.ReadLine(), out heroHealth));
            do
            {
                Console.WriteLine("Введите значение брони шлема от 0, до 1: ");
            } while (!float.TryParse(Console.ReadLine(), out helmArmor));
            do
            {
                Console.WriteLine("Введите значение брони кирасы от 0, до 1: ");
            } while (!float.TryParse(Console.ReadLine(), out shellArmor));
            do
            {
                Console.WriteLine("Введите значение брони сапог от 0, до 1: ");
            } while (!float.TryParse(Console.ReadLine(), out bootsArmor));
            do
            {
                Console.WriteLine("Укажите минимальный урон оружия (0-20): ");
            } while (!float.TryParse(Console.ReadLine(), out minWeaponDamage));
            do
            {
                Console.WriteLine("Укажите максимальный урон оружия (20-40): ");
            } while (!float.TryParse(Console.ReadLine(), out maxWeaponDamage));

            Unit hero = new Unit(heroName, heroHealth);
            Weapon weapon = new Weapon("Pistik", minWeaponDamage, maxWeaponDamage);
            hero.EquipWeapon(weapon);
            hero.EquipBoots(new Armor.Boots(bootsArmor));
            hero.EquipHelm(new Armor.Helm(helmArmor));
            hero.EquipShell(new Armor.Shell(shellArmor));
            hero.SetDamage(10);
            
            Console.WriteLine("Вашего героя зовут: " + hero.Name + "-Властитель миров!");
            Console.WriteLine("Общий показатель брони равен: " + (hero.Boots.Armor + hero.Shell.Armor + hero.Helm.Armor));
            Console.WriteLine("Фактическое значение здоровья равно: " + hero.RealHealth());
        }
    }
}