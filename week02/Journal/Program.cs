using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
// I decided to add a days since feature to my code so that after putting in my entry I could see how many days its been since my last entry. I used the help
// of Gemini AI to learn about how to use Datetime to accomplish this task and find the difference.

class Program
{
    static void Main(string[] args)
    {

        Journal myJournal1 = new Journal();
        int userInputNumber = 0;



        do
        {
            Console.WriteLine("Hello World! This is the Journal Project.");
            Console.WriteLine("What do you desire to do?");
            Console.WriteLine("1 write");
            Console.WriteLine("2 display Journal");
            Console.WriteLine("3 Save Journal");
            Console.WriteLine("4 Load Journal");
            Console.WriteLine("5 Close your Epistle");
            Console.WriteLine("6 See how long it has been since you last wrote.");

            string userInput = Console.ReadLine();
            userInputNumber = int.Parse(userInput);

            if (userInputNumber == 1)
            {

                PromptGenerator prompt = new PromptGenerator();
                string randyprompt = prompt.GetRandomPrompt();

                Entry e1 = new Entry();
                e1._promptText = randyprompt;
                DateTime todaysTime = DateTime.Now;
                e1._date = todaysTime.ToShortDateString();
                Console.WriteLine(randyprompt);
                Console.WriteLine("Entry: ");
                e1._entryText = Console.ReadLine();
                e1.Display();

                myJournal1.AddEntry(e1);


            }
            else if (userInputNumber == 2)
            {

                myJournal1.DisplayAll();
            }
            else if (userInputNumber == 3)
            {

                Console.WriteLine("What file do you wish to save it to? ");
                string file = Console.ReadLine();
                myJournal1.SaveToFile(file);



            }
            else if (userInputNumber == 4)
            {

                Console.WriteLine("Which File did you want to load? ");
                string loadFile = Console.ReadLine();
                myJournal1.LoadFromFile(loadFile);


            }
            else if (userInputNumber == 6)
            {
                myJournal1.DisplayDateSinceLastEntry();
            }

        } while (userInputNumber != 5);

        Console.WriteLine("Have a nice day");
    }




}