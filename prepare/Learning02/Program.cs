using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "BYU-I";
        job1._jobTitle = "Professor";
        job1._startYear = 2024;
        job1._endYear = 2026;

        job2._company = "Apple";
        job2._jobTitle = "Intern";
        job2._startYear = 2026;
        job2._endYear = 2028;

        Resume resume = new Resume();

        resume._name = "Jaden";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}
