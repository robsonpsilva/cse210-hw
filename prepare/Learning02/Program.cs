using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job = new Job();
        job._jobTitle = "Software Engineer";
        job._company = "Microsoft";
        job._startYear = 2010;
        job._endYear = 2019;

        Job job1 = new Job();
        job1._jobTitle = "Software Architect";
        job1._company = "Google";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Resume res = new Resume();
        res._jobs.Add(job);
        res._jobs.Add(job1);

    }
}