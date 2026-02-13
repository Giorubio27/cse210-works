using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;

    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This is to help you reflect", 60)
    {
        // This is a way to create an instance of a list of prompts
        _prompts = new List<string>();

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        // This is a way of questions
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public void Run()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you find something, press enter");
        Console.ReadLine();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());

        }

    }
    public string GetRandomPrompt()
    {
        Random reflectPick = new Random();

        int randomChoice = reflectPick.Next(0, _prompts.Count);

        return _prompts[randomChoice];
    }
    public string GetRandomQuestion()
    {
        Random question = new Random();

        int randomQuestion = question.Next(0, _questions.Count);

        return _questions[randomQuestion];

    }
    public void DisplayPrompt()
    {
        GetRandomPrompt();

    }
    public void DisplayQuestions()
    {
        GetRandomQuestion();
    }
}