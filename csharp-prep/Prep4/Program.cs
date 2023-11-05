using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0) {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int largest = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}