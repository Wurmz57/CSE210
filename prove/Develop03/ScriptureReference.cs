using System;

class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    public string DisplayText(){
        if (_endVerse == 0)
            return _book + " " + _chapter + ":" + _verse;
        else
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
    }
    public ScriptureReference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public ScriptureReference(string book, int chapter, int verse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
}