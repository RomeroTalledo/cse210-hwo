using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the Addreess
        Address address = new Address("123 Main St", "Los Angeles", "CA", "USA");

        // Create the Custmomer
        Customer customer = new Customer("Dallin Romero Talledo", address);

        // Create the order
        Order order = new Order(customer);

        // add the products
        order.AddProduct(new Product(1, "Laptop", 1000, 1));
        order.AddProduct(new Product(2, "Mouse", 50, 2));

        // Display the Information
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Costo Total: ${order.TotalCost()}");
    }
    
}