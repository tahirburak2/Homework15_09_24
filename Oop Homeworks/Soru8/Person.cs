using System;

namespace Oop_Homeworks.Soru8;

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void AttendedClass()
    {

    }

}
