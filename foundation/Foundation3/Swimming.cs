using System;

class Swimming : Activity{
    private float _laps;
    public override float Distance(){
        return _laps * 50 / 1000;
    }
    public override float Speed()
    {
       return _laps * 50 / 1000 / _time * 60;
    }
    public override float Pace()
    {
        return _time / _laps * 50 / 1000;
    }
    public override string GetSummary()
    {
        return _day + " Swimming (" + _time + " min): Distance " + Distance() + " km, Speed: " + Speed() + " kph, Pace: " + Pace() + " min per km";
    }
    public Swimming(int time, float Laps){
        _time = time;
        _laps = Laps;
    }
}