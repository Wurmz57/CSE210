using System;

class Program
{
    static void Main(string[] args)
    {
        Order _order = new Order();
        bool _createShipping = false;
        while (! _createShipping){
            _order.PackingLabel();
            Console.WriteLine(_order.ShippingLabel());
            Console.WriteLine("Total price: " + _order.CalculateTotalCost());
            Console.ReadLine();
            _createShipping = true;
        }
    }
}