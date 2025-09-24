using System;

class Program
{
    static void Main(string[] args)
    {
        Random magicNumber = new Random();
        int number = magicNumber.Next(1, 100);

        Console.WriteLine("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Higher");
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower");
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }
        }

                Console.WriteLine("You guessed it!");

    }
}