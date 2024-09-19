using System;
using System.Xml.Serialization;

namespace Oop_Homeworks.Soru10;

public class Mage : Character
{
    public Mage(string name, int health) : base(name, health)
    {
    }
    public virtual void CastSpell()
    {
        System.Console.WriteLine($"{Name} büyü saldırısı yaptı.");
    }
}