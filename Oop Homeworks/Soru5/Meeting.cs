using System;

namespace Oop_Homeworks.Soru5;

public class Meeting : Event
{
    public Meeting(string name, DateTime date, string location) : base(name, date, location)
    {
    }
    public virtual void MeetingComplete()
    {
        System.Console.WriteLine("toplantı tarihi geçti");
    }
}
