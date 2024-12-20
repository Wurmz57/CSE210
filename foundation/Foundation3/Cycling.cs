using System;

class Cycling: Activity{
    private float _speed;
    public override float Distance(){
        return _speed / 60 * _time;
    }
    public override float Speed()
    {
       return _speed;
    }
    public override float Pace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return _day + " Cycling (" + _time + " min): Distance " + Distance() + " km, Speed: " + Speed() + " kph, Pace: " + Pace() + " min per km";
    }
    public Cycling(int time, float Speed){
        _time = time;
        _speed = Speed;
    }
}