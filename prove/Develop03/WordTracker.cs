using System;

class WordTracker
{
    private string _word;
    private bool _isHidden;
    public string GetDisplayText(){
        if (_isHidden == true)
            return "_____";
        else
            return _word;
    }
    public void Hide(){
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
    public bool IsHidden(){
        return _isHidden;
    }
    public WordTracker(string word){
        _word = word;
        _isHidden = false;
    }
}