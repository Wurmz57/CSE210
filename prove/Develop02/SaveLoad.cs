using System;
using System.IO;

public class SaveLoad{
    public void Save(string _filename, List<string> _entriesList){
        using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                foreach(string entry in _entriesList)
                {
                    outputFile.WriteLine(entry);
                }
            }
    }
    public List<string> Load(string _filename){
        List<string> _newFile = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            _newFile.Add(line);
        }
        return _newFile;
    }
}