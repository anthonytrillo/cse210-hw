using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program.");

        Journal journal = new Journal();
        DisplayMenu(journal);
    }

    static void DisplayMenu(Journal journal)
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Write(journal);
                break;
            case "2":
                Display(journal);
                break;
            case "3":
                Load(journal);
                break;
            case "4":
                Save(journal);
                break;
            case "5":
                Quit(journal);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    static void Write(Journal journal)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString("MM/dd/yyyy");
        entry._prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(entry._prompt);

        entry._entry = Console.ReadLine();
        journal.AddEntry(entry);

        Console.WriteLine("Entry added successfully.");
        DisplayMenu(journal);
    }

    static void Display(Journal journal)
    {
        Console.WriteLine("Displaying journal entries...");
        journal.DisplayAll();
        DisplayMenu(journal);
    }

    static void Load(Journal journal)
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);
        DisplayMenu(journal);
    }

    static void Save(Journal journal)
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName);
        Console.WriteLine("Journal saved successfully.");
        DisplayMenu(journal);
    }

    static void Quit(Journal journal)
    {
        if (journal._entries.Count > 0)
        {
            Console.WriteLine("You have unsaved changes. Are you sure you want to quit? (y/n)");
            string confirmation = Console.ReadLine();
            if (confirmation == "y")
            {
                Environment.Exit(0);
            }
        }
        else
        {
            Environment.Exit(0);
        }
        DisplayMenu(journal);
    }
}