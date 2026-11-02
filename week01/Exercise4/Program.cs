using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            numbers.Add(number);
            number = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"The sum is {numbers.Sum()}.");
        Console.WriteLine($"The average is {numbers.Average()}.");
        Console.WriteLine($"The largest number is {numbers.Max()}.");
        Console.WriteLine($"The smallest positive number is {numbers.Where(x => x > 0).Min()}.");
    }
}