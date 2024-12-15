using System;

class Program
{
    static void Main(string[] args)
    {
        Scipture _scripture = new Scipture("If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.");
        bool _allHidden = false;
        string _end;
        while (! _allHidden)
        {
            Console.Clear();
            _scripture.DisplayText();
            Console.WriteLine();
            Console.WriteLine("Please press enter to continue or quit to end.");
            _end = Console.ReadLine();
            _allHidden = _scripture.CheckHidden();
            if (_end == "quit"){
                _allHidden = true;
            }
            _scripture.HideRandomWords();
        }
        
    } 
}