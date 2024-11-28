using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address = new Address("Rua Silva Teles, 30, Andaraí", "Rio de Janeiro","RJ", "Brazil");
        Console.WriteLine(address.isInUSA());
    }
}