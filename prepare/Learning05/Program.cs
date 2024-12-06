using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments assignment1 = new Assignments("Jaden Mons", "Coding");
        Console.WriteLine(assignment1.GetSummary());

        Math assignment2 = new Math("Jaden Mons", "Calculus", "Week 2", "1-3");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        Writing assignment3 = new Writing("Jaden Mons", "War", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}