using System;

namespace Bank;

public class BankAccount
{
    public string AccountHolder { get; set; }
    public decimal Balance { get; set; }

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public virtual void CalculateInterest(){}

    public void DisplayInfo()
    {
        Console.WriteLine($"Hesap Sahibi: {AccountHolder}");
        Console.WriteLine($"Mevcut Bakiye: {Balance:C}");
    }
}