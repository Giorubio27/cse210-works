using System.Buffers.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing activity", "This is an activity to help you relax",60)
    {
        

    }
    public void Run()
    {
        DisplayStartingMessage();
         DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out");
            ShowCountDown(6);
        }
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
        
    }
}