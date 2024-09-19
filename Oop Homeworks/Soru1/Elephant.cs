using System;

namespace Oop_Homeworks.Soru1;

public class Elephant : Animal
{
    public Elephant(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void MakeSound()
    {
        base.MakeSound();
        System.Console.WriteLine($"{Name} boru gibi ses çıkardı!!!");
    }
}
