using System;
namespace Bank;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banka Hesabı Polimorfizm Örneği\n");

        SavingsAccount savingsAccount = new SavingsAccount("Ahmet Yılmaz", 1000);
        Console.WriteLine("Vadeli Hesap Bilgileri:");
        savingsAccount.DisplayInfo();
        savingsAccount.CalculateInterest();
        Console.WriteLine();

        CheckingAccount checkingAccount = new CheckingAccount("Ayşe Demir", 2000);
        Console.WriteLine("Vadesiz Hesap Bilgileri:");
        checkingAccount.DisplayInfo();
        checkingAccount.CalculateInterest();
        Console.WriteLine();

        Console.WriteLine("Polimorfizm Örneği:");
        BankAccount[] accounts = new BankAccount[2];
        accounts[0] = savingsAccount;
        accounts[1] = checkingAccount;

        foreach (BankAccount account in accounts)
        {
            account.DisplayInfo();
            account.CalculateInterest();
            Console.WriteLine();
        }

        Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}