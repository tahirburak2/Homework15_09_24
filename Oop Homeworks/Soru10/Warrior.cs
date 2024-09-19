using System;

namespace Oop_Homeworks.Soru10;

public class Warrior : Character
{
    public Warrior(string name, int health) : base(name, health)
    {
    }
    public virtual void SwordAttack()
    {
        System.Console.WriteLine($"{Name} kılıç saldırısı yaptı.");
    }
}
