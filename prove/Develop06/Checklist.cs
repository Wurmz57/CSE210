using System;

class Checklist : Goals
{
    private int _targetCompleted = 0;
    private int _targetToComplete;
    private int _bonusPoints;
    private bool _givePoints = false;
    public override void RecordCompleted()
    {
        _givePoints = true;
        _targetCompleted += 1;
    }
    public override int AddPoints()
    {
        if (IsCompleted() == true){
            return _goalPoints + _bonusPoints;
        }
        else if (_givePoints == true){
            _givePoints = false;
            return _goalPoints;
        }
        return 0;
    }
    public override string GetStringRepresentation()
    {
        return "Checklist," + _goalName + "," + _goalDescription + "," + _goalPoints + "," + _targetToComplete + "," + _bonusPoints + "," + _targetCompleted;
    }
    public override string ExtraPrint()
    {
        return "Completed: " + _targetCompleted + "/" + _targetToComplete;
    }
        public bool IsCompleted()
    {
        if (_targetCompleted == _targetToComplete){
            return true;
        }
        else{
            return false;
        }
    }
    public Checklist(string _name, string _description, int _points, int _target, int _bonus){
        _goalName = _name;
        _goalDescription = _description;
        _goalPoints = _points;
        _targetToComplete = _target;
        _bonusPoints = _bonus;
    }
    public Checklist(string _name, string _description, int _points, int _target, int _bonus, int _completed){
        _goalName = _name;
        _goalDescription = _description;
        _goalPoints = _points;
        _targetToComplete = _target;
        _bonusPoints = _bonus;
        _targetCompleted = _completed;
    }
}