using System; 

class Video{
    private string _Title;
    private string _Author;
    private int _Length;
    private List<Comment> _Comments = new List<Comment>();
    private int _Count;
    public void DisplayVideo(){
        Console.WriteLine(_Title + ", " + _Author + " " + _Length + " " + _Count + " Comments.");
        foreach (Comment comment in _Comments){
            comment.DisplayComment();
        }
    }
    public void AddComment(string account, string comment){
        _Comments.Add(new Comment(account,comment));
        _Count = _Comments.Count;
    }
    public Video(string title, string author, int length){
        _Title = title;
        _Author = author;
        _Length = length;
    }
}