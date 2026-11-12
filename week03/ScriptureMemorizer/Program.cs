using System;
using Newtonsoft.Json;

// Exceeds core requirements: scriptures are loaded from scriptures.json
// and one scripture is chosen at random.
// The program ends when every word is hidden or the user types quit.

class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText("scriptures.json");
        List<ScriptureData> data = JsonConvert.DeserializeObject<List<ScriptureData>>(json);
        List<Scripture> scripturesList = new List<Scripture>();
        foreach (ScriptureData item in data)
        {
            Reference reference = new Reference(item.Book, item.Chapter, item.Verse, item.EndVerse);
            scripturesList.Add(new Scripture(reference, item.Text));
        }

        Random random = new Random();
        Scripture scripture = scripturesList[random.Next(scripturesList.Count)];

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to hide a word or type 'quit' to exit.");
        string input = Console.ReadLine();

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            scripture.HideRandomWords(1);
            Console.WriteLine(scripture.GetDisplayText());
            input = Console.ReadLine();
        }
    }
}