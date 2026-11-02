using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }
}