using System;
using System.Runtime.CompilerServices;

class Running : Activity{
    private float _distance;
    public override float Distance(){
        return _distance;
    }
    public override float Speed()
    {
        
       return _distance / _time * 60;
    }
    public override float Pace()
    {
        return _time/_distance;
    }
    public override string GetSummary()
    {
        return _day + " Running (" + _time + " min): Distance " + Distance() + " km, Speed: " + Speed() + " kph, Pace: " + Pace() + " min per km";
    }
    public Running(int time, float Distance){
        _time = time;
        _distance = Distance;
    }
}