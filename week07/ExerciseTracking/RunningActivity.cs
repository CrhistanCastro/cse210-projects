using System;

public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string name,int time,double distance) : base(name,time)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return Math.Round(_distance, 1);
    }
    public override double CalculateSpeed()
    {
        double speed = (_distance / _time) * 60;
        return Math.Round(speed, 1);
    }
    public override double CalculatePace()
    {
        double pace = _time / _distance;
        return Math.Round(pace, 1);
    }
}