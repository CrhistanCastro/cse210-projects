using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public double TotalCost()
    {
        double total = Math.Round(_price * _quantity,2);

        return total;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"{_name}|{_productId}, ${_price}");
    }
}