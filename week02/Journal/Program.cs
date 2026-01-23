using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("What do you desire to do?");
        Console.WriteLine("1 write");
        Console.WriteLine("2 display Journal");
        Console.WriteLine("3 Load Journal");
        Console.WriteLine("4 Save Journal");
        Console.WriteLine("5 Close your Epistle");
        string userInput = Console.ReadLine();
        int userInputNumber = int.Parse(userInput);
        if (userInputNumber == 1)
        {
            
            PromptGenerator prompt = new PromptGenerator();
            string randyprompt = prompt.GetRandomPrompt();

            Entry e1 = new Entry();
            e1._promptText = randyprompt;
            Console.WriteLine("What date is it today?");
            e1._date = Console.ReadLine();
            Console.WriteLine(randyprompt);
            Console.WriteLine("Entry: ");
            e1._entryText = Console.ReadLine();
            e1.Display();

            Journal myJournal1 = new Journal();
            myJournal1.AddEntry(e1);



        }
        else if (userInputNumber == 2)
        {
            
        }
        else if (userInputNumber == 3)
        {

        }
        else if (userInputNumber == 4)
        {

        }
        else if (userInputNumber == 5)
        {
            Console.WriteLine("Have a nice day");
        }
    }

    


}