using System;

namespace Oop_Homeworks.Soru7;

public class Product
{
    public Product(string name, decimal price, int stockQuantitiy)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantitiy;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public virtual void CheckStock()
    {
        System.Console.WriteLine($"şuan eldeki stokta bulunan miktar:{StockQuantity}");
    }

    public virtual void UpdateStock(int sayı)
    {
        sayı = int.Parse(Console.ReadLine());
        StockQuantity = sayı + StockQuantity;
        System.Console.WriteLine($"şuan eldeki stokta bulunan miktar:{StockQuantity}");

    }
    public virtual void Bilgilendirme()
    {

        System.Console.WriteLine($"Ürünün adı: {Name}\nÜrünün ücreti: {Price}\nÜrünün adedi: {StockQuantity}");
    }
}
