using System;

class Program
{
    private List<Video> _Videos = new List<Video>();
    private void Main(string[] args){
        CreateList();
        foreach (Video video in _Videos){
            video.DisplayVideo();
        }
    }
    private void CreateList(){
        _Videos.Add(new Video("Video 1", "Account 1", 100));
        _Videos[1].AddComment("Commenter 1", "Comment 1");
        _Videos[1].AddComment("Commenter 2", "Comment 2");
        _Videos[1].AddComment("Commenter 3", "Comment 3");
        _Videos.Add(new Video("Video 2", "Account 2", 200));
        _Videos[2].AddComment("Commenter 1", "Comment 1");
        _Videos[2].AddComment("Commenter 2", "Comment 2");
        _Videos[2].AddComment("Commenter 3", "Comment 3");
        _Videos.Add(new Video("Video 3", "Account 3", 300));
        _Videos[3].AddComment("Commenter 1", "Comment 1");
        _Videos[3].AddComment("Commenter 2", "Comment 2");
        _Videos[3].AddComment("Commenter 3", "Comment 3");
    }
}