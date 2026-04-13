using System;

public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_length / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }
}