using System;

public class Activity{
    private int _timeDuration;
    public void DisplayEndingMessage(){
        Console.WriteLine("You have finished " + _timeDuration + " of the activity");
    }
    public void RunPauseAnimation(){
        for (int i = 15; i > 0; i--){
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(100);
        }
    }
    public void InputTime(){
        Console.Write("How long would you like the activity to last? ");
        _timeDuration = int.Parse(Console.ReadLine());
    }
    public void CountDown(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timeDuration);
    }
}