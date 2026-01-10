using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.WriteLine("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int magicNumberMan = int.Parse(magicNumber);
        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1, 100);
        bool match = false;
        while (match == false)
        {
            Console.WriteLine("What is your guess? ");
            string guessNumber = Console.ReadLine();
            int guessNumberMan = int.Parse(guessNumber);
            if (magicNumber == guessNumberMan)
            {
                Console.Write("You guessed it right!.");
                match = true;
            }
            else if (magicNumber > guessNumberMan)
            {
                Console.WriteLine("You guessed too low");
            }
            else if (magicNumber < guessNumberMan)
            {
                Console.WriteLine("You guessed too high. ");
            }
        }



    }
}