using System;

public abstract class Activity
{
    protected int _time;
    protected string _name;

    public Activity(string name, int time)
    {
        _name = name;
        _time = time;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public void GetSummary()
    {
        string date = DateTime.Now.ToString("dd MMM yyyy");
        Console.WriteLine($"{date} {_name} ({_time} min)- Distance: {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km");
    }
}