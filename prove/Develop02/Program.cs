using System;

class Program
{
    static void Main(string[] args)
    {
        bool _end = false;
        int _selected = 0;
        List<string> _entriesList = new List<string>();
        WriteDisplay journal = new WriteDisplay();
        SaveLoad tofile = new SaveLoad();
        string _filename;
        while (! _end){
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please select an option ");
            _selected = int.Parse(Console.ReadLine());
            if (_selected == 1){
                journal.AddEntry(_entriesList);
            }
            else if (_selected == 2){
                journal.DisplayJournal(_entriesList);
            }
            else if (_selected == 3){
                Console.WriteLine("Choose a file to load from: ");
                _filename = Console.ReadLine();
                _entriesList = tofile.Load(_filename);
            }
            else if (_selected == 4){
                Console.WriteLine("Choose a file to save to: ");
                _filename = Console.ReadLine();
                tofile.Save(_filename, _entriesList);
            }
            else if (_selected == 5){
                _end = true;
            }
        } 
    }
}