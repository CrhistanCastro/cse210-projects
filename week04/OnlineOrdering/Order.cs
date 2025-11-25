using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product newproduct)
    {
        _products.Add(newproduct);
    }
    public double TotalPrice()
    {
        int shipCost;
        double total = 0;
        if (_customer.UsaOrNot() == true)
        {
            shipCost = 5;
        }
        else
        {
            shipCost = 35;
        }
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }
        return shipCost + total;
    }
    public string PackingLabel()
    {
        string pLabel = "Packing Label:\n";
        foreach(Product pLProduct in _products)
        {
            pLabel += $"Product: {pLProduct.GetName()}|ID: {pLProduct.GetProductId()}\n";
        }
        return pLabel;
    }
    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.DisplayCustomer()}\n";
    }
}