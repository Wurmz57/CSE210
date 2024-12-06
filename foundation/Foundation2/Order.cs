using System;

class Order{
    private List<Product> _Products = new List<Product>();
    private Customer _customer;
    private double CalculateTotalCost(){
        return 5.00;
    }
    private string PackingLabel(string product_name, string product_id){
        return product_name + ", " + product_id;
    }
    private string ShippingLabel(string customer_name, string address){
        return customer_name + ", " + address;
    }
    private int CheckUSA(){
        return 5;
    }
}
