// **** EXTRA CREDIT **** I did the original design and decided to add a feature to allow me to pick references and scriptures from a different file called repentref.csv and get scriptures from that instead. This will allow me to memorize key scriptures by topic which could potentially motivate me and others to study more efficiently. I used Gemini to help me figure out how to make it happen.

using System;
using System.Data;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Reference ref1 = new Reference("1Nephi", 3, 7);

        // Scripture script1 = new Scripture(ref1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Console.WriteLine("What topic file would you like? ");
        string file = Console.ReadLine();

        Reference loader = new Reference("temp", 0, 0);
        List<Scripture> availableScriptures = loader.LoadTopic(file);

        Scripture script1 = availableScriptures[0];


        
        while (true)
        {

            
            Console.Clear();
            script1.GetDisplayText();
            Console.WriteLine(script1.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit'");
            string userInput = Console.ReadLine();
            script1.HideRandomWords(3);
            if (userInput == "quit")
            {
                break;
            }
            if (script1.IsHiddenCompletely())
            {
                break;
            }
        } 





    }
}