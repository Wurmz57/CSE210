using System;

class Comment{
    private string _Name;
    private string _Comment;
    public void DisplayComment(){
        Console.WriteLine(_Name + ", " + _Comment);
    }
    public Comment(string name, string comment){
        _Name = name;
        _Comment = comment;
    }
}