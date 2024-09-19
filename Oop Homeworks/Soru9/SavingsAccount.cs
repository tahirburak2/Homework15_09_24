using System;

namespace Oop_Homeworks.Soru9;

public class SavingsAccount : Account
{
    public SavingsAccount(int accountNumber, decimal balance, int monthSaving) : base(accountNumber, balance)
    {
        MonthSaving = monthSaving;
    }
    public int MonthSaving { get; set; }


}
