using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int _menu = 0;
        int _complete = 0;
        Manager _goalManager = new Manager();
        while (_menu != 6){
            Console.WriteLine("Current score: " + _goalManager.DisplayScore());
            Console.WriteLine("Please select a menu option:");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. Display list of goals");
            Console.WriteLine("3. Complete a goal");
            Console.WriteLine("4. Save list of goals");
            Console.WriteLine("5. Load list of goals");
            Console.WriteLine("6. Quit");
            _menu = int.Parse(Console.ReadLine());
            if (_menu == 1){
                _goalManager.CreateGoal();
            }
            else if (_menu == 2){
                _goalManager.PrintGoal();
            }
            else if (_menu == 3){
                Console.WriteLine("Choose a goal to mark as completed");
                _complete = int.Parse(Console.ReadLine()) - 1;
                _goalManager.RecordCompleted(_complete);
            }
            else if (_menu == 4){
                Console.WriteLine("Type a file to save to");
                _goalManager.SaveGoalList(Console.ReadLine());
            }
            else if (_menu == 5){
                Console.WriteLine("Type a file to load from");
                _goalManager.LoadGoalList(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}