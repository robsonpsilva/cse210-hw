using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address = new Address("Rua Silva Teles, 30, Andaraí", "Rio de Janeiro","RJ", "Brazil");
        
        Customer customer = new Customer("Robson Paulo da Silva", address);

        Product product = new Product(1, "Logitech Mouse", 5.60 , 2);

        Console.Clear();
        Console.WriteLine(customer.getCustomerName());
        Console.WriteLine(customer.getCustomerAddress().getFullAddress());
        Console.WriteLine(product.getTotalCost());
    }
}