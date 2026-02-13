// --Extra MILE--- I used Previous experience and AI as a tutor to help me integrate a save method into my Listing activity. I did it by 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool activityOn = true;

        while (activityOn)
        {
            
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
                breath1.ShowSpinner(5);
            }
            else if (userChoiceInput == 2)
            {
                ReflectingActivity ref1 = new ReflectingActivity();
                ref1.Run();
                ref1.DisplayEndingMessage();
                ref1.ShowSpinner(5);


            }
            else if (userChoiceInput == 3)
            {
                ListingActivity list1 = new ListingActivity();
                list1.Run();
                list1.DisplayEndingMessage();
                list1.ShowSpinner(5);
                Console.WriteLine("Would you like to save the activity on a file for memories? If so type a filename.");
                string newFile = Console.ReadLine();
                if (newFile != "no")
                {
                    list1.SaveListToFile(newFile);
                }
                
            }
            else if (userChoiceInput == 4)
            {
                activityOn = false;
            }
        }





    }
}