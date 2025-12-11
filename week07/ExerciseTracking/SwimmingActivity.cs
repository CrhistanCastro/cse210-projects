using System;

public class SwimmingActivity : Activity
{
    private int _swimmingLap;
    public SwimmingActivity(string name,int time,int swimLap) : base(name,time)
    {
        _swimmingLap = swimLap;
    }
    
    public override double CalculateDistance()
    {
        double distance = _swimmingLap * 50.0 / 1000.0;
        return Math.Round(distance, 1);
    }
    public override double CalculateSpeed()
    {
        double speed= (CalculateDistance() / _time) * 60;
        return Math.Round(speed, 1);
    }
    public override double CalculatePace()
    {
        double pace= _time / CalculateDistance();
        return Math.Round(pace, 1);
    }
}