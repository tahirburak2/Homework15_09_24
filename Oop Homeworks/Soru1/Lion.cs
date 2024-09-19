using System;

namespace Oop_Homeworks.Soru1;

public class Lion : Animal
{
    public Lion(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void MakeSound()
    {
        base.MakeSound();
        System.Console.WriteLine($"{Name} kükredi!!");
    }
}
