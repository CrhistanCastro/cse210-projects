using System;

public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string name,int time,double speed) : base(name,time)
    {
        _speed = speed;
    }
    
    public override double CalculateDistance()
    {
        double distance = (_speed * _time) / 60;
        return Math.Round(distance, 1);
    }
    public override double CalculateSpeed()
    {
        return Math.Round(_speed, 1);
    }
    public override double CalculatePace()
    {
        double pace = 60 / _speed;
        return Math.Round(pace, 1);
    }
}