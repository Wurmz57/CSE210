using System;

public class WriteDisplay(){
    Prompts prompts = new Prompts();
    public void AddEntry(List<string> _entriesList){
        prompts.CreatePrompts();
        string prompt = prompts.ChooseRandomAndDisplay();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string entry = dateText + " " + prompt + " " + Console.ReadLine();
        _entriesList.Add(entry);
    }
    public void DisplayJournal(List<string> _entriesList){
        foreach(string entry in _entriesList)
        {
            Console.WriteLine(entry);
        }
    }
}