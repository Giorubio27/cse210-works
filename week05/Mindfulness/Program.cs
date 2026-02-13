using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool activityOn = true;

        while (activityOn)
        {
            Console.Clear();
            Console.WriteLine("Hello friend, This is a program to help you be more mindful on your journey here on earth.");
            Console.WriteLine("Please choose out of one of the following activities.");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string userChoice = Console.ReadLine();
            int userChoiceInput = int.Parse(userChoice);

            if (userChoiceInput == 1)
            {
                BreathingActivity breath1 = new BreathingActivity();
                breath1.Run();
                breath1.DisplayEndingMessage();
            }
            else if (userChoiceInput == 2)
            {
                ReflectingActivity ref1 = new ReflectingActivity();
                ref1.DisplayStartingMessage();
                ref1.Run();
                ref1.DisplayEndingMessage();


            }
            else if (userChoiceInput == 3)
            {
                ListingActivity list1 = new ListingActivity();
                list1.DisplayStartingMessage();
                list1.Run();
                list1.DisplayEndingMessage();
            }
            else if (userChoiceInput == 4)
            {
                activityOn = false;
            }
        }
        

        
        
       
    }
}