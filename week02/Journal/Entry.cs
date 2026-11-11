using System;

public class Entry {
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _entry { get; set; }
    public int _mood { get; set; }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt} - {_entry}");
    }

    public override string ToString()
    {
        return $"{_date}|{_prompt}|{_entry}";
    }
}