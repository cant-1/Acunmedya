using System;

namespace Bank;

public class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountHolder, decimal initialBalance) 
        : base(accountHolder, initialBalance)
    {
    }

    public override void CalculateInterest()
    {
        decimal interest = Balance * 0.05m;
        Balance += interest;
        Console.WriteLine($"Hesaplanan faiz: {interest:C}");
        Console.WriteLine($"Faiz sonrası yeni bakiye: {Balance:C}");
    }
}