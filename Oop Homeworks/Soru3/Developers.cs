using System;

namespace Oop_Homeworks.Soru3;

public class Developers : Employee
{
    public Developers(string name, int ıd, decimal salary, string programmingLanguage) : base(name, ıd, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public string ProgrammingLanguage { get; set; }
    public virtual void Dil()
    {
        System.Console.WriteLine($"yazılımcının kullandığı dil {ProgrammingLanguage}");
    }

}
