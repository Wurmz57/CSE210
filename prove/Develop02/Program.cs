using System;

class Program
{
    static void Main(string[] args)
    {
        //Select from write, display, save, load
        WriteDisplay.AddEntry(_entriesList);
        WriteDisplay.DisplayJournal;
        SaveLoad.Save;
        SaveLoad.Load;
    }
}