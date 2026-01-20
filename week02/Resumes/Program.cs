using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Microsoft";
        job1._startDate = "2014";
        job1._endDate = "2024";


        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._jobCompany = "Apple";
        job2._startDate = "2013";
        job2._endDate = "2025";


        Resume resume1 = new Resume();
        resume1._name = "Gary Snail";


        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();

    }
}

