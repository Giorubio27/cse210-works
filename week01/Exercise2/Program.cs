using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        string letter = "";
        Console.Write("What is your grade percent? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        if (grade >= 90)
        {

            if (grade >= 90)
            {
                letter = "A";
            }


        }
        else if (grade >= 80)
        {

            if (grade >= 80)
            {
                letter = "B";
            }

        }
        else if (grade >= 70)
        {

            if (grade >= 70)
            {
                letter = "C";
            }

        }
        else if (grade >= 60)
        {

            if (grade >= 60)
            {
                letter = "D";
            }

        }
        else if (grade >= 50)
        {

            if (grade >= 50)
            {
                letter = "F";
            }

        }
        if (grade >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("Nice try, Try again soon");
        }
        Console.WriteLine($"{letter}");




    }
}