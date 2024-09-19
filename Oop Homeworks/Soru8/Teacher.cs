using System;

namespace Oop_Homeworks.Soru8;

public class Teacher : Person
{
    public Teacher(string name, int age, string subjectTaught) : base(name, age)
    {
        SubjectTaught = subjectTaught;
    }
    public string SubjectTaught { get; set; }

    public override void AttendedClass()
    {
        System.Console.WriteLine("Öğretmen derse girdi");
    }

}
