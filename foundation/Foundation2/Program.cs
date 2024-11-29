using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        //Loading customer address
        Address address = new Address("Rua Silva Teles, 30, Andaraí", "Rio de Janeiro","RJ", "Brazil");
        
        //Loading customer data
        Customer customer = new Customer("Robson Paulo da Silva", address);

        //Once the customer for the order has been defined, the next step is to create a purchase order.
        Order order = new Order(customer);

        //Then the products chosen by the customer need to be included in their purchase order.
        order.setProduct(new Product(1, "Logitech Mouse", 5.60 , 2));
        order.setProduct(new Product(2, "Keyboard Dell", 10.0 , 1));
        order.setProduct(new Product(3, "Laptop Samsung", 500.0 , 1));
        order.setProduct(new Product(4, "Mouse Pad RedDragon", 2.0 , 1));


        Console.Clear();

        //Once the order is completed, we will inform you of the total value of the order.       
        
        
        Console.WriteLine("First Client");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("Shipping label");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine(order.getShippingLabel());
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("Packing label");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine(order.getPackingLabel());
        
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine($"Order total including shipping: ${order.getTotalOrderCoast()}");
        Console.WriteLine("---------------------------------------------------------------------------");
        //Console.WriteLine(product.getTotalCost());

        //---------------------------------------------------------------------
        //This second part refers to the second customer and his order.
        //Loading other customer address
        address = new Address("2520 21st Street Apt 720", "Springfield","VT", "USA");
        
        //Loading customer data
        customer = new Customer("John Smith", address);

        //Once the customer for the order has been defined, the next step is to create a purchase order.
        order = new Order(customer);

        order.setProduct(new Product(1, "Set of frying pans", 42.99 , 1));
        order.setProduct(new Product(2, "Libbey Ascent 16-Piece Tumbler and Rocks Glass Set", 10.0 , 2));
        order.setProduct(new Product(3, "Riveira Bamboo Wooden Spoons for Cooking 6-Piece", 500.0 , 1));

        Console.WriteLine("");
        Console.WriteLine("Second client");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("Shipping label");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine(order.getShippingLabel());
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("Packing label");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine(order.getPackingLabel());
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine($"Order total including shipping: ${order.getTotalOrderCoast()}");
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}