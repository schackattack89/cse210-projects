using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2000;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "VP Development";
        job2._startYear = 2014;
        job2._endYear = 2020;


        Resume resume1 = new Resume();
        resume1._name = "Edward Schack";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}