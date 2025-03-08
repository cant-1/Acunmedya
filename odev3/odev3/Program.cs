using System;

namespace odev3;

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager(1, "Ahmet Yılmaz", 10000, "Yönetim", 5);
        Developer developer = new Developer(2, "Ayşe Demir", 8000, "Yazılım", "C# ve .NET ");

        Console.WriteLine("Yönetici Bilgileri:");
        Console.WriteLine(manager);
        Console.WriteLine($"Bonus: {manager.CalculateBonus()}");

        Console.WriteLine("\nGeliştirici Bilgileri:");
        Console.WriteLine(developer);
        Console.WriteLine($"Bonus: {developer.CalculateBonus()}");
    }
}