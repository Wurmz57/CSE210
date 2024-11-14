using System;

class Program
{
    static void Main(string[] args)
    {
        Random Random = new Random();
        int Find = Random.Next(0, 100);
        int Guess = -1;

        while (Guess != Find)
        {
            Console.Write("What is your guess? ");
            Guess = int.Parse(Console.ReadLine());

            if (Find > Guess)
            {
                Console.WriteLine("Higher");
            }
            else if (Find < Guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}