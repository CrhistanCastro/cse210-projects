using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Ordering Page\n");

        Address address1 = new Address("E Miller St", "Springfield", "Illinois", "USA");
        Customer customer1 = new Customer("George Williams", address1);
        Product product1 = new Product("Fragance Candles", "F021C", 37.50, 5);
        Product product2 = new Product("Rain Jacket", "R513J", 22.79, 2);
        Product product3 = new Product("VR Headset", "VR215H", 329, 1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("Order 1");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine($"The total price of the order is ${Math.Round(order1.TotalPrice(), 2)}\n");

        Address address2 = new Address("Alberto Defillo", "Santo Domingo", "Distrito Nacional", "Dominican Republic");
        Customer customer2 = new Customer("Alberto Parra", address2);
        Product productA = new Product("Laptop Backpack", "L268P", 27.76, 1);
        Product productB = new Product("Copy Paper", "C864P", 63.66, 3);
        Product productC = new Product("Basketball Shoe", "B397S", 35, 1);
        Order order2 = new Order(customer2);
        order2.AddProduct(productA);
        order2.AddProduct(productB);
        order2.AddProduct(productC);

        Console.WriteLine("Order 2");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine($"The total price of the order is ${Math.Round(order2.TotalPrice(), 2)}\n");
    }
}