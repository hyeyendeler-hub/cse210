using System;

public class Cycling : Activity
{
    private double _distance; // in miles

    public Cycling(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_length / 60.0);
    }

    public override double GetPace()
    {
        return _length / _distance;
    }
}