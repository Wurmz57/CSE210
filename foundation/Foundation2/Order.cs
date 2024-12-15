using System;

class Order{
    private List<Product> _Products = new List<Product>();
    private Customer _customer = new Customer("Jaden Mons", "7511 S 282nd E ave", "Broken Arrow", "Oklahoma", "USA");
    private double _total = 0;
    public double CalculateTotalCost(){
        foreach (Product product in _Products){
            _total += product._totalPrice();
        }
        _total += CheckUSA();
        return _total;
    }
    public void PackingLabel(){
        foreach (Product product in _Products){
            Console.WriteLine(product._getProductName() + ", " + product._getProductID());
        }
    }
    public string ShippingLabel(){
        return _customer._getName() + ", " + _customer._getAddress();
    }
    private double CheckUSA(){
        if (_customer._inUSA() == true){
            return 5.00;
        }
        else{
            return 35.00;
        }
    }
    public Order(){
        Product _product1 = new Product("Product 1", "#01", 5.00, 3);
        Product _product2 = new Product("Product 2", "#03", 4.25, 2);
        Product _product3 = new Product("Product 3", "#02", 2.00, 6);
        _Products.Add(_product1);
        _Products.Add(_product2);
        _Products.Add(_product3);
    }
}
