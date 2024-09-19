using System;

namespace Oop_Homeworks.Soru9;

public class CheckingAccount : Account
{
    public CheckingAccount(int accountNumber, decimal balance, string writeCheck) : base(accountNumber, balance)
    {
        WriteCheck = writeCheck;
    }
    public string WriteCheck { get; set; }
    public virtual void bilgi()
    {
        System.Console.WriteLine($"Bu ayki tasarrufunuz: {WriteCheck}");
    }


}
