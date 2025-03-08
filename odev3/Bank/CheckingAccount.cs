using System;

namespace Bank;

public class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountHolder, decimal initialBalance) : base(accountHolder, initialBalance){}

    public override void CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest.");
    }
}