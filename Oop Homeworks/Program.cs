using Oop_Homeworks.Soru1;
using Oop_Homeworks.Soru10;
using Oop_Homeworks.Soru3;
using Oop_Homeworks.Soru4;
using Oop_Homeworks.Soru7;
using Oop_Homeworks.Soru9;

namespace Oop_Homeworks;

class Program
{
  static void Main(string[] args)
  {
    //    Lion lion1=new("aslan kıral",23,"yeleli");
    //    lion1.MakeSound();
    //   Product product1=new Product("samet",5,345);
    //   product1.CheckStock();
    //   product1.UpdateStock();
    // FoodProduct foodProduct1=new FoodProduct("muz",15,1000);
    // foodProduct1.Bilgilendirme();
    // System.Console.WriteLine("-------------------------");
    // foodProduct1.UpdateStock(1200);
    // System.Console.WriteLine("-------------------------");

    // foodProduct1.Bilgilendirme();
    // CheckingAccount checkingAccount1=new CheckingAccount(32,253442352,"32");
    // checkingAccount1.bilgi();

    // Warrior warrior=new Warrior("Beyza",10);
    // warrior.SwordAttack();
    //       Manager manager=new Manager("Beyza",6161,100000,5);

    // manager.Bilgilendirme();
    Library library = new Library("ölüm", "burak", 345, 043287);

    library.Borrow();
  }
}
