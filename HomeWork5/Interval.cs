namespace HomeWork5;

public struct Interval
{
    private static readonly Random Random = new();

    private const float DefoultMinValue = 1f;
    private const float DefoultMaxValue = 10f;
    
    private readonly float _minValue;
    private readonly float _maxValue;

    public float Get => (float)Random.NextDouble() * (_maxValue - _minValue) + _minValue;
    public float Max => _maxValue;
    public float Min => _minValue;
    public float Average => (_maxValue + _minValue) / 2f;


    public Interval(int minValue, int maxValue) : this((float)minValue, (float)maxValue) { }
    public Interval(float minValue, float maxValue)
    {
        if (minValue > maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
            Console.WriteLine("Некорректные входные данные для оружия! Значения меняются!");
        }
        else
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }
        if (_minValue < DefoultMinValue)
        {
            _minValue = DefoultMinValue;
            Console.WriteLine("Установка минимального значения форсированна. Значение по умолчанию: " + DefoultMinValue);
        }
        if (_maxValue <= DefoultMinValue)
        {
            _maxValue = DefoultMaxValue;
            Console.WriteLine("Установка максимального значения форсированна. Значение по умолчанию: " + DefoultMaxValue);
        }
    }

    public Interval(float value) : this(value, value) { }
}