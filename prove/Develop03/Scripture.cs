using System;

class Scipture
{
    private ScriptureReference _reference = new ScriptureReference("James", 1, 5);
    private List<WordTracker> _words = new List<WordTracker>();
    private bool check;
    Random Random = new Random();
    public void ListMaker(string scripture){
        List<string> _wordList = scripture.Split(' ').ToList();
        foreach (string word in _wordList)
        {
            WordTracker _word = new WordTracker(word);
            _words.Add(_word);
        }
    }
    public void DisplayText(){
        Console.WriteLine(_reference.DisplayText() + " ");
        foreach (WordTracker word in _words){
            Console.Write(word.GetDisplayText() + " ");
        }
    }
    public void HideRandomWords(){
        int length = _words.Count;
        int index = Random.Next(0, length);
        _words[index].Hide();
    }
    public bool CheckHidden(){
        foreach (WordTracker word in _words){
            check = word.IsHidden();
            if (check == false){
                return false;
            }
        }
        return true;
    }
    public Scipture(string scripture){
        ListMaker(scripture);
    }
}