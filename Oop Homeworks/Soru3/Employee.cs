using System;

namespace Oop_Homeworks.Soru3;

public class Employee
{
    public Employee(string name, int ıd, decimal salary)
    {
        Name = name;
        Id = ıd;
        Salary = salary;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary { get; set; }
    public virtual void Bilgilendirme()
    {
        System.Console.WriteLine($"çalışanın adı= {Name}\nçalışanın kimlik numarası= {Id}\nçalışanın maaşı= {Salary}");
    }
}
