using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter a number:");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The sum of all numbers is: " + numbers.Sum());
        Console.WriteLine("The average of all numbers is: " + numbers.Average());
        Console.WriteLine("The largest number is: " + numbers.Max());

    }
}