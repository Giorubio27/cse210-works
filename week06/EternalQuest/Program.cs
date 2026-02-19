// For my Extramile I went ahead and added a Save leaderboard and display leader board so that everyone could see the highscore of this videogame. I used Gemini AI to help me figure out how to format it into a leaderboard with descending points
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager newgame = new GoalManager();
        newgame.Start();


    }
}