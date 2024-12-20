using System;

class Program
{
    static void Main(string[] args)
    {
        Running _run = new Running(30, 5);
        Cycling _cycle = new Cycling(30, 10);
        Swimming _swim = new Swimming(30, 15);
        Console.WriteLine(_run.GetSummary());
        Console.WriteLine(_cycle.GetSummary());
        Console.WriteLine(_swim.GetSummary());
    }
}