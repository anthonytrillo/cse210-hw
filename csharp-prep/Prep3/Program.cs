using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        bool response = true;

        // Console.Write("What is the magic number? ");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);

        do {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);

            if (magicNumber > guessNumber) {
                Console.WriteLine("Higuer");
            } else if (magicNumber < guessNumber) {
                Console.WriteLine("Lower");
            } else {
                Console.WriteLine("You guess it!");
                response = false;
            }
        } while (response);
    }
}