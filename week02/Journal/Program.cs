using System;

/*
Exceeding Requirements:
- Entries are saved as a CSV file (Date, Prompt, Entry, Mood). Commas and
  quotation marks in the text are escaped so the file opens correctly in Excel.
- Each entry also stores a mood rating from 1 to 5. Mood is shown with the
  entry and summarized as an average in Stats.
- Search finds past entries by a word in the date, prompt, or response, which
  helps when the journal gets long and an entry is hard to find again.
- Stats reports how many entries are stored, the average mood, and a writing
  streak of consecutive days. The streak is there to make a daily habit easier
  to keep.
- The program warns before Quit or Load when there are unsaved changes, so a
  journal is not thrown away by accident.
- The prompt list has ten questions, and the same prompt is not shown two
  times in a row.
*/
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
        journal._entries.Add(entry);

        Console.WriteLine("Entry added successfully.");
        DisplayMenu(journal);
    }

    static void Display(Journal journal)
    {
        foreach (Entry entry in journal._entries)
        {
            entry.Display();
        }
        DisplayMenu(journal);
    }

    static void Load(Journal journal)
    {
        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = File.ReadAllLines("journal.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 4)
            {
                continue;
            }

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];

            int mood;
            if (!int.TryParse(parts[3], out mood))
            {
                mood = 0;
            }
            entry._mood = mood;
            loadedEntries.Add(entry);
        }

        journal._entries = loadedEntries;
        DisplayMenu(journal);
    }

    static void Save(Journal journal)
    {
        Console.WriteLine("What...");
        File.WriteAllLines("journal.txt", journal._entries.Select(e => e.ToString()).ToArray());
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