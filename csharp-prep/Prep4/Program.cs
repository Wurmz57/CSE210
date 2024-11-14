using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List<int>();
        
        int Number = 1;
        while (Number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string Input = Console.ReadLine();
            Number = int.Parse(Input);
            
            if (Number != 0)
            {
                Numbers.Add(Number);
            }
        }

        int Sum = 0;
        foreach (int sumNumber in Numbers)
        {
            Sum += sumNumber;
        }
        Console.WriteLine($"The sum is: {Sum}");

        float Average = ((float)Sum) / Numbers.Count;
        Console.WriteLine($"The average is: {Average}");
        
        int Highest = Numbers[0];

        foreach (int highNumber in Numbers)
        {
            if (highNumber > Highest)
            {
                Highest = Number;
            }
        }

        Console.WriteLine($"The max is: {Highest}");
    }
}