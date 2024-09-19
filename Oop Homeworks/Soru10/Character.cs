using System;

namespace Oop_Homeworks.Soru10;

public class Character
{
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public string Name { get; set; }
    public int Health { get; set; }
}
