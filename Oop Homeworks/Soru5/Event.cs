using System;

namespace Oop_Homeworks.Soru5;

public class Event
{
    public Event(string name, DateTime date, string location)
    {
        Name = name;
        Date = date;
        Location = location;
    }

    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
}
