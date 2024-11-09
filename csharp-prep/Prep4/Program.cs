using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        bool continueEntering = true;
        float number;
        float sum = 0;
        float average = 0;
        float max = 0;
        float minPositive;
        float sortedList;

        List<float> numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (continueEntering) 
        {
            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());
            if (number == 0)
            {
                continueEntering = false;   
            }
            else
            {
                numbers.Add(number);
            }   
        }

        sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        minPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {minPositive}");
        
        numbers.Sort();
        foreach (float n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}