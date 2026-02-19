using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        BikingActivity newBike = new BikingActivity("06/12/2025", 30, 6);
        newBike.GetSpeed();
        newBike.GetPace();
        Console.WriteLine(newBike.GetSummary());

        RunningActivity newRun = new RunningActivity("06/12/2026", 70, 5);
        newRun.GetSpeed();
        newRun.GetPace();
        Console.WriteLine(newRun.GetSummary());

        SwimmingActivity newSwim = new SwimmingActivity("07/2026", 100, 50);
        newSwim.GetSpeed();
        newSwim.GetPace();
        Console.WriteLine(newSwim.GetSummary());
        
    }
}