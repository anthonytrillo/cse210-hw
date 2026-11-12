using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        File.WriteAllLines(fileName, _entries.Select(entry => entry.ToString()).ToArray());
    }

    public void LoadFromFile(string fileName)
    {
        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 3)
            {
                continue;
            }
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];
            loadedEntries.Add(entry);
        }
        _entries = loadedEntries;
    }
}