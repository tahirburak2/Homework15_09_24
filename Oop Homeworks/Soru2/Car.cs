using System;

namespace Oop_Homeworks.Soru2;

public class Car : Vehicle
{
    public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }
    public int NumberOfDoors { get; set; }
    public override void Feauture()
    {
        System.Console.WriteLine($"{NumberOfDoors} arabanın kapı sayısıdır.");
    }
}
