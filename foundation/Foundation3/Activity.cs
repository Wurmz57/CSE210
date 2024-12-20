using System;
using System.ComponentModel.DataAnnotations;

abstract class Activity{
    public int _time;
    public string _day = DateTime.Today.ToString("d/M/yyyy");
    public abstract float Distance();
    public abstract float Speed();
    public abstract float Pace();
    public abstract string GetSummary();
}