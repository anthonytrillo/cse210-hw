using System;

public class Job
{
    public string _companyName { get; set; }
    public string _jobTitle { get; set; }
    public string _startDate { get; set; }
    public string _endDate { get; set; }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startDate} - {_endDate}");
    }
}