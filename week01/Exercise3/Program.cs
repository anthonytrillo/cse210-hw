using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        Console.WriteLine("What is your guess? ");
        string guess = Console.ReadLine();
        int guesses = 1;
        int number = int.Parse(magicNumber);
        int guessNumber = int.Parse(guess);
        while (guessNumber != number)
        {
            if (guessNumber > number)
            {
                Console.WriteLine("Too high!");
            }
            else if (guessNumber < number)
            {
                Console.WriteLine("Too low!");
            }

            Console.WriteLine("What is your guess? ");
            guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

            guesses++;
        }
        Console.WriteLine($"You guessed it! The magic number is {number}.");
        Console.WriteLine($"You guessed it in {guesses} guesses!");
    }
}