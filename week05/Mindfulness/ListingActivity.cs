using System.Diagnostics;

public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "Help you list things to be grateful for", 60)
    {
        _prompts = new List<string>();

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }
    public void Run()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("Get Ready...");
        ShowCountDown(3);
        Console.WriteLine("\nGo!");

        List<string> userInput = GetListFromUser(_duration);

        _count = userInput.Count;

        Console.WriteLine($"You have listed {_count} reponses");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
        
        

        
    }
    public string GetRandomPrompt()
    {
        Random pick = new Random();

        int randomChoice = pick.Next(0, _prompts.Count);

        return _prompts[randomChoice];

    }
    public List<string> GetListFromUser(int _duration)
    {
        List<string> responseList = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int responsesCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter: ");
            string response = Console.ReadLine();

            if (!string.IsNullOrEmpty(response))
            {
                responsesCount++;
                responseList.Add(response);
            }
        }
        Console.WriteLine($"\nTime is up! You have listed{responsesCount} responses");
        return responseList;


    }
}

        
        
        
   
    
        

