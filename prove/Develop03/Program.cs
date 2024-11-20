using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference r = new Reference("Jeremiah", 33, 6, 6);
        r.setVerse(6,"Nevertheless, I will bring health and healing to it; I will heal my people and will let them enjoy abundant peace and security.");
        

        string prompt = "";
        while (prompt != "quit")
        {
            Console.WriteLine(r.getHiddenReferenceString());
            prompt = Console.ReadLine();
            r.hideWord();
        }
    
    }
}