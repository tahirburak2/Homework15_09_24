using System;

namespace Oop_Homeworks.Soru8;

public class Student : Person
{
    public Student(string name, int age, int gradeLevel) : base(name, age)
    {
        GradeLevel = gradeLevel;
    }
    public int GradeLevel { get; set; }

    public override void AttendedClass()
    {
        System.Console.WriteLine("Öğrenci derse girdi");
    }
}
