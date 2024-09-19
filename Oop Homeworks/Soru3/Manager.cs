using System;

namespace Oop_Homeworks.Soru3;

public class Manager : Employee
{
    public Manager(string name, int ıd, decimal salary, int numberOfTeams) : base(name, ıd, salary)
    {
        NumberOfTeams = numberOfTeams;
    }
    public int NumberOfTeams { get; set; }
    public override void Bilgilendirme()
    {
        base.Bilgilendirme();
        System.Console.WriteLine($"Müdürün altında çalışan takım sayısı: {NumberOfTeams}");
    }

}
