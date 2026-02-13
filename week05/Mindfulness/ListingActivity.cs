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
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            GetRandomPrompt();
            ShowSpinner();
            GetListFromUser();

        }

    }
    public string GetRandomPrompt()
    {
        Random pick = new Random();

        int randomChoice = pick.Next(0, _prompts.Count);

        return _prompts[randomChoice];

    }
    public List<string> GetListFromUser()
    {
        
        List<string> userList = new List<string>();
        Console.WriteLine(GetRandomPrompt());
        string response = Console.ReadLine();
        userList.Add(response);
        return userList;
        
        
    }
}
    
        

