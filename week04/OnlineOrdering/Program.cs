using System;

class Program
{
    static void Main(string[] args)
    {
       
        // order 1
        

        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Product product1 = new Product(
            "Wireless Mouse",
            "MOU-101",
            25.00,
            2
        );

        Product product2 = new Product(
            "Keyboard",
            "KEY-202",
            45.00,
            1
        );

        Product product3 = new Product(
            "USB Cable",
            "USB-303",
            10.00,
            3
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


     
        // ORDER 2
       

        Address address2 = new Address(
            "45 Oxford Road",
            "Johannesburg",
            "Gauteng",
            "South Africa"
        );

        Customer customer2 = new Customer(
            "Banze Billy",
            address2
        );

        Product product4 = new Product(
            "Laptop Stand",
            "LAP-404",
            60.00,
            1
        );

        Product product5 = new Product(
            "Webcam",
            "WEB-505",
            80.00,
            2
        );

        Product product6 = new Product(
            "Headphones",
            "HEA-606",
            50.00,
            1
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        
        
   

        Console.WriteLine("------------------------------");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("------------------------------");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");


     

        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("--------------------------");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}