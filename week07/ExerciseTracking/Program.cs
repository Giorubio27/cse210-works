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
        
    }
}