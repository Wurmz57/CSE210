using System;

abstract class Goals
{
    public string _goalName;
    public string _goalDescription;
    public int _goalPoints;
    public abstract void RecordCompleted();
    public abstract int AddPoints();
    public abstract string GetStringRepresentation();
    public abstract string ExtraPrint();
    public string PrintGoal(){
        return _goalName + " " + ExtraPrint();
    }
}