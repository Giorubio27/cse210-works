using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assign1 = new Assignment();
        assign1.SetTopic("math");
        assign1.SetStudentName("Gary");
        Console.WriteLine($"{assign1.GetSummary()}");

        MathAssignment newMath = new MathAssignment();
        newMath.SetStudentName("Roberto Rodriguez");
        newMath.SetTopic("Fractions");
        newMath.SetTexbook("7.3");
        newMath.SetProblems("Problems 1-19");
        Console.WriteLine(newMath.GetSummary());
        Console.WriteLine(newMath.GetHomework());
        Console.WriteLine();

        WritingAssignment writing1 = new WritingAssignment();
        writing1.SetStudentName("Mary Waters");
        writing1.SetTopic("European History");
        writing1.SetTitle("The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}