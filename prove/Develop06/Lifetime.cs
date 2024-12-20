using System;

class Lifetime : Goals
{
    public bool _givePoints = false;
    public override void RecordCompleted()
    {
        _givePoints = true;
    }
    public override int AddPoints()
    {
        if (_givePoints == true){
            _givePoints = false;
            return _goalPoints;
        }
        return 0;
    }
    public override string GetStringRepresentation()
    {
        return "Lifetime," + _goalName + "," + _goalDescription + "," + _goalPoints;
    }
    public override string ExtraPrint()
    {
        return "";
    }
    public Lifetime(string _name, string _description, int _points){
        _goalName = _name;
        _goalDescription = _description;
        _goalPoints = _points;
    }
}