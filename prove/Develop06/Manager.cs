using System;
using System.Runtime.CompilerServices;

class Manager
{
    private List<Goals> _goalsList = new List<Goals>();
    private int _totalScore = 0;
    private int _type;
    private string _name;
    private string _description;
    private int _points;
    private int _target;
    private int _bonus;
    public void CreateGoal(){
        Console.WriteLine("What kind of goal would you like to make?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Lifetime");
        Console.WriteLine("3. Checklist");
        _type = int.Parse(Console.ReadLine());
        if (_type == 1){
            Console.WriteLine("What is the name of the goal?");
            _name = Console.ReadLine();
            Console.WriteLine("What is a short description of the goal?");
            _description = Console.ReadLine();
            Console.WriteLine("How many points is the goal worth?");
            _points = int.Parse(Console.ReadLine());
            Simple _newGoal = new Simple(_name, _description, _points);
            _goalsList.Add(_newGoal);
        }
        else if (_type == 2){
            Console.WriteLine("What is the name of the goal?");
            _name = Console.ReadLine();
            Console.WriteLine("What is a short description of the goal?");
            _description = Console.ReadLine();
            Console.WriteLine("How many points is the goal worth?");
            _points = int.Parse(Console.ReadLine());
            Lifetime _newGoal = new Lifetime(_name, _description, _points);
            _goalsList.Add(_newGoal);
        }
        else if (_type == 3){
            Console.WriteLine("What is the name of the goal?");
            _name = Console.ReadLine();
            Console.WriteLine("What is a short description of the goal?");
            _description = Console.ReadLine();
            Console.WriteLine("How many points is a step of the goal worth?");
            _points = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times to complete to reach full completion?");
            _target = int.Parse(Console.ReadLine());
            Console.WriteLine("How many points is complete goal completion worth?");
            _bonus = int.Parse(Console.ReadLine());
            Checklist _newGoal = new Checklist(_name, _description, _points, _target, _bonus);
            _goalsList.Add(_newGoal);
        }
        else{
            Console.WriteLine("Please redo and enter a valid goal type.");
        }
    }
    public void SaveGoalList(string _filename){
        using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                outputFile.WriteLine(_totalScore);
                foreach(Goals goal in _goalsList)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
    }
    public void LoadGoalList(string _filename){
        _goalsList.Clear();
        string[] list = System.IO.File.ReadAllLines(_filename);
        foreach (string goal in list)
        {
            string[] _goalLoad = goal.Split(",");
            if (_goalLoad[0] == "Simple"){
                Simple _loadedGoal = new Simple(_goalLoad[1],_goalLoad[2],int.Parse(_goalLoad[3]),bool.Parse(_goalLoad[4]),bool.Parse(_goalLoad[5]));
                _goalsList.Add(_loadedGoal);
            }
            else if (_goalLoad[0] == "Lifetime"){
                Lifetime _loadedGoal = new Lifetime(_goalLoad[1],_goalLoad[2],int.Parse(_goalLoad[3]));
                _goalsList.Add(_loadedGoal);
            }
            else if (_goalLoad[0] == "Checklist"){
                Checklist _loadedGoal = new Checklist(_goalLoad[1],_goalLoad[2],int.Parse(_goalLoad[3]),int.Parse(_goalLoad[4]),int.Parse(_goalLoad[5]), int.Parse(_goalLoad[6]));
                _goalsList.Add(_loadedGoal);
            }
            else{
                _totalScore = int.Parse(goal);
            }
        }
    }
    public int DisplayScore(){
        return _totalScore;
    }
    public void PrintGoal(){
        int i = 0;
        foreach (Goals _goal in _goalsList){
            i += 1;
            Console.WriteLine(i + " " + _goal.PrintGoal());
        }
    }
    public void RecordCompleted(int select){
        _goalsList[select].RecordCompleted();
        _totalScore += _goalsList[select].AddPoints();
    }
}