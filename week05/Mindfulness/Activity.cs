using System.Runtime.CompilerServices;

public class Activity
{
    private string _name;

    private string _description;

    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;

        _description = description;

        _duration = duration;

    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Are you ready to start the {_name}? {_description}. This activity will last {_duration}");

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great Job. That was a good exercise! ");
    }
    public void ShowSpinner()
    {
        Console.Write("|");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("\\");

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
        
    }
}