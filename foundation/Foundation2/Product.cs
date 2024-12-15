using System;
using System.Runtime.CompilerServices;

class Product{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;
    private double _total;
    public Product(string name, string ID, double price, int quantity){
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
        _total = _price * _quantity;
    }
    public double _totalPrice(){
        return _total;
    }
    public string _getProductName(){
        return _name;
    }
    public string _getProductID(){
        return _productID;
    }
}