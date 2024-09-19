using System;

namespace Oop_Homeworks.Soru2;

public class Motor : Vehicle
{

    public Motor(string make, string model, int year, bool hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }
    public bool HasSidecar { get; set; }
    public override void Feauture()
    {
        if (HasSidecar = true)
        {
            System.Console.WriteLine("Motorun yanında ek arabası vardır");
        }
    }
}
