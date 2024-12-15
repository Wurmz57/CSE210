using System;

class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public bool _inUSA(){
        if (_country == "USA"){
            return true;
        }
        else{
            return false;
        }
    }
    public string _completeAddress(){
        return _street + " " + _city + " " + _state + ", " + _country;
    }
    public void _setStreet(string street){
        _street = street;
    }
    public void _setCity(string city){
        _city = city;
    }
    public void _setState(string state){
        _state = state;
    }
    public void _setCountry(string country){
        _country = country;
    }
}