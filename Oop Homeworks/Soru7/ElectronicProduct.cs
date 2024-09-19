using System;

namespace Oop_Homeworks.Soru7;

public class ElectronicProduct : Product
{
    public ElectronicProduct(string name, decimal price, int stockQuantitiy) : base(name, price, stockQuantitiy)
    {
    }
    public override void Bilgilendirme()
    {
        base.Bilgilendirme();
    }
    public override void CheckStock()
    {
        base.CheckStock();
    }
    public override void UpdateStock(int sayı)
    {
        base.UpdateStock(sayı);
    }
}
