using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string Grade = Console.ReadLine();
        int Percent = int.Parse(Grade);
        string Letter = "";
        if (Percent >= 90)
        {
            Letter = "A";
        }
        else if (Percent >= 80)
        {
            Letter = "B";
        }
        else if (Percent >= 70)
        {
            Letter = "C";
        }
        else if (Percent >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }
        Console.WriteLine("Your grade is: ");
        Console.Write(Letter);
        if (Percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Failed! Try again later!");
        }
    }
}