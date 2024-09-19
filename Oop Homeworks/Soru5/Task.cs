using System;

namespace Oop_Homeworks.Soru5;

public class Task : Event
{
    public Task(string name, DateTime date, string location) : base(name, date, location)
    {
    }
    public virtual void MarkAsComplete()
    {
        System.Console.WriteLine("görev tamamlandı");
    }
}
