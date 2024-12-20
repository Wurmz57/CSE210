using System;

class Simple : Goals
{
    private bool _isCompleted = false;
    private bool _pointsGiven = false;
    public override void RecordCompleted()
    {
        _isCompleted = true;
    }
    public override int AddPoints()
    {
        if (_isCompleted == true){
            if (_pointsGiven == false){
                _pointsGiven = true;
                return _goalPoints;
            }
        }
        return 0;
    }
    public override string GetStringRepresentation()
    {
        return "Simple," + _goalName + "," + _goalDescription + "," + _goalPoints + "," + _isCompleted + "," + _pointsGiven;
    }
    public override string ExtraPrint()
    {
        if (_isCompleted == true){
            return "[X]";
        }
        else{
            return "[ ]";
        }
    }
    public Simple(string _name, string _description, int _points){
        _goalName = _name;
        _goalDescription = _description;
        _goalPoints = _points;
    }
    public Simple(string _name, string _description, int _points, bool _completed, bool _given){
        _goalName = _name;
        _goalDescription = _description;
        _goalPoints = _points;
        _isCompleted = _completed;
        _pointsGiven = _given;
    }
}