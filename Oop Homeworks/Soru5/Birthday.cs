using System;

namespace Oop_Homeworks.Soru5;

public class Birthday : Event
{
    public Birthday(string name, DateTime date, string location) : base(name, date, location)
    {
    }
    public virtual void Birth()
    {
        System.Console.WriteLine($"{Date} doğum günü tarihiniz");
    }
}
