using System;

public class Prompts{
    public List<string> _promptsList = new List<string>();
    public void CreatePrompts(){
        _promptsList.Add("Who was the most interesting person I interacted with today?");
        _promptsList.Add("What was the best part of my day?");
        _promptsList.Add("How did I see the hand of the Lord in my life today?");
        _promptsList.Add("What was the strongest emotion I felt today?");
        _promptsList.Add("If I had one thing I could do over today, what would it be?");
    }
    public string ChooseRandomAndDisplay(){
        Random Random = new Random();
        int Prompt = Random.Next(0, 5);
        string _prompts = _promptsList[Prompt];
        Console.WriteLine(_prompts);
        return _prompts;
    }
}