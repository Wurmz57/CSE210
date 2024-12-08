using System;

class Program
{
    static void Main(string[] args)
    {
        bool _end = false;
        int _selected = 0;
        while (! _end){
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please select an excercise ");
            _selected = int.Parse(Console.ReadLine());
            if (_selected == 1){
                Breathing breathing = new Breathing();
                breathing.BreathingIntro();
            }
            else if (_selected == 2){
                Reflection reflection = new Reflection();
                reflection.ReflectionIntro();
            }
            else if (_selected == 3){
                Listing listing = new Listing();
                listing.ListingIntro();
            }
            else if (_selected == 4){
                _end = true;
            }
        } 
    }
}