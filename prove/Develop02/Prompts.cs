using System;

public class Prompts{
    public List<string> _promptsList = new List<string>();
    public void ChooseRandomAndDisplay(){
        Random Random = new Random();
        int Prompt = Random.Next(1, 5);
        Console.WriteLine(_promptsList(Prompt));
    }
}