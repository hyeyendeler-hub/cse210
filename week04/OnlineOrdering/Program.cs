using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first order with USA customer
        Address address1 = new Address("123 Main Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        // Add products to first order
        Product product1 = new Product("Laptop", 1001, 999.99, 1);
        Product product2 = new Product("Mouse", 1002, 29.99, 2);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Display first order information
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        // Create second order with international customer
        Address address2 = new Address("456 Oak Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);

        // Add products to second order
        Product product3 = new Product("Keyboard", 1003, 79.99, 1);
        Product product4 = new Product("Monitor", 1004, 299.99, 1);
        Product product5 = new Product("Headphones", 1005, 149.99, 1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display second order information
        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}
