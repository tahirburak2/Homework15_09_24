using System;

namespace Oop_Homeworks.Soru10;

public class Archer : Character
{
    public Archer(string name, int health) : base(name, health)
    {
    }
    public virtual void BowAttack()
    {
        System.Console.WriteLine($"{Name} yayıyla saldırı yaptı.");
    }
}
