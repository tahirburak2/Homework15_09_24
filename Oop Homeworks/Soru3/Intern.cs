using System;

namespace Oop_Homeworks.Soru3;

public class Intern : Employee
{
    public Intern(string name, int ıd, decimal salary, int lastWeek) : base(name, ıd, salary)
    {
        LastWeek = lastWeek;
    }
    public int LastWeek { get; set; }

    public virtual void Week()
    {
        System.Console.WriteLine($"Stajyerin son {LastWeek} haftası kaldı");
    }
}
