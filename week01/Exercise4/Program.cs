using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("What is your number of choice? ");
        string numberChoice = Console.ReadLine();
        int numberChoiceInt = int.Parse(numberChoice);
        int sum = 0;
        int count = 0;
        int max = 0;
        while (numberChoiceInt != 0)
        {
            if (numberChoiceInt > 0)
            {
                numbers.Add(numberChoiceInt);
                count += 1;

            }
            Console.WriteLine("You can add another number or type 0 to stop.");
            numberChoice = Console.ReadLine();
            numberChoiceInt = int.Parse(numberChoice);
        }
        foreach (int number in numbers)
        {
            sum += number;
            max = numbers.Max();
            count = numbers.Count;




        }
        double average = (double)sum / count;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"the max is {max}");


    }
}