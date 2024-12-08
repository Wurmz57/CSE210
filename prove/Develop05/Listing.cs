using System;

public class Listing : Activity{
    public void ListingIntro(){
        Console.WriteLine("You have selected the Listing activity.");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("The Listing activity will begin shortly. ");
        base.RunPauseAnimation();
    }
    public Listing(){
    }
}