
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - Customer in the United States
        Address address1 = new Address("123 Main Street", "Seattle", "Washington", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Laptop", "L100", 1200.00, 1);
        Product product2 = new Product("Mouse", "M200", 25.00, 2);
        Product product3 = new Product("Keyboard", "K300", 45.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Order 2 - Customer outside the United States
        Address address2 = new Address("Calle 72 #45-10", "Barranquilla", "Atlantico", "Colombia");
        Customer customer2 = new Customer("Maria Rodriguez", address2);

        Product product4 = new Product("Headphones", "H400", 80.00, 2);
        Product product5 = new Product("Phone Case", "P500", 15.00, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Order 1
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
