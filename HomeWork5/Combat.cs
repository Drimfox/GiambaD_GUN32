namespace HomeWork5;

public class Combat
{
    private List<Rate> _rateList = new();

    public void StartCombat(Unit firstUnit, Unit secondUnit)
    {
        Random random = new Random();
        while (firstUnit.Health > 0 && secondUnit.Health > 0)
        {
            float damage;
            if (random.Next(1, 11) % 2 == 0)
            {
                damage = secondUnit.Damage;
                firstUnit.SetDamage(damage);
                _rateList.Add(new Rate(secondUnit, (int)damage, firstUnit.Health));
            }
            else
            {
                damage = firstUnit.Damage;
                secondUnit.SetDamage(damage);
                _rateList.Add(new Rate(firstUnit, (int)damage, secondUnit.Health));
            }
        }
    }

    public void ShowResults()
    {
        foreach (var rate in _rateList)
        {
            Console.WriteLine("Боец {0} нанёс урон {1} и оставил {2} здоровья.", rate.Unit.Name, rate.Damage, rate.Health);
        }

        Console.WriteLine("Победил " + _rateList[^1].Unit.Name + "!");
    }
}