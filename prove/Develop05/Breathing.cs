using System;

public class Breathing : Activity{
    public void BreathingIntro(){
        Console.WriteLine("You have selected the Breathing activity.");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("The Breathing activity will begin shortly. ");
        base.RunPauseAnimation();
    }
    public Breathing(){
    }
}