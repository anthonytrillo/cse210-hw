using System;

public class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Adviters";
        job1._jobTitle = "Software Engineer";
        job1._startDate = "2023";
        job1._endDate = "2026";

        Job job2 = new Job();
        job2._companyName = "Globant";
        job2._jobTitle = "Manager";
        job2._startDate = "2022";
        job2._endDate = "2024";

        job1.Display();
        job2.Display();
    }
}