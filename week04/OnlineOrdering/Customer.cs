using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool UsaOrNot()
    {
        bool usaOrNot = _address.UsaOrNot();

        return usaOrNot;
    }
    public string DisplayCustomer()
    {
        return $"Name: {_name}\nAddress: {_address.DisplayAddress()}";
    }
}