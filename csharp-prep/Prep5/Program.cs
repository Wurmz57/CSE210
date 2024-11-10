using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string userName = UserName();
        int userNumber = UserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayInputs(userName, squaredNumber);
    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();

        return Name;
    }

    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string Input = Console.ReadLine();
        int Number = int.Parse(Input);

        return Number;
    }

    static int SquareNumber(int Number)
    {
        int Square = Number * Number;

        return Square;
    }

    static void DisplayInputs(string Name, int Square)
    {
        Console.WriteLine($"{Name}, the square of your number is {Square}");
    }
}
