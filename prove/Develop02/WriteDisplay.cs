using System;

public class WriteDisplay{
    public List<string> _entriesList = new List<string>();
    public string _entries;
    public void AddEntry(string _entries){
        Prompts.ChooseRandomAndDisplay();
        _entries.Add(Console.ReadLine());
    }
    public void DisplayJournal(){
        foreach(string entry in _entriesList)
        {
            Console.WriteLine(entry);
        }
    }
}