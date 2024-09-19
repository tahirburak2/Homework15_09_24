using System;

namespace Oop_Homeworks.Soru9;

public class Account
{
    public Account(int accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public int AccountNumber { get; set; }

    public decimal Balance { get; set; }


}
