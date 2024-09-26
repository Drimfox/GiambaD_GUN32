namespace HomeWork5;

public struct Rate
{
    private readonly float _health;
    
    public Unit Unit { get; }
    public int Damage { get; }
    public float Health => (float)Math.Round(_health, 2);

    public Rate(Unit unit, int damage, float health)
    {
        Unit = unit;
        Damage = damage;
        _health = health;
    }
}