using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        RunningActivity running = new RunningActivity("Running", 30, 10);
        SwimmingActivity swimming = new SwimmingActivity("Swimming", 30, 10);
        CyclingActivity cycling = new CyclingActivity("Cycling", 30, 25);
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);
        foreach(Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}