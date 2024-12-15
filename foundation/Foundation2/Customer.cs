using System;

class Customer{
    Address _address = new Address();
    private string _name;
    public Customer(string name, string street, string city, string state, string country){
        _address._setStreet(street);
        _address._setCity(city);
        _address._setState(state);
        _address._setCountry(country);
        _name = name;
    }
    public bool _inUSA(){
        return _address._inUSA();
    }
    public string _getName(){
        return _name;
    }
    public string _getAddress(){
        return _address._completeAddress();
    }
}