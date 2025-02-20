using System;

namespace Quiz1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Question1
			Console.Write("Bir sayi girin: ");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number > 0)
				Console.WriteLine("pozitif");
			else if (number < 0)
				Console.WriteLine("negatif");
			else
				Console.WriteLine("sifir");


			// Question2
			Console.Write("Bir sayi girin: ");
			int dayNumber = Convert.ToInt32(Console.ReadLine());
			switch (dayNumber)
			{
				case 1:
					Console.WriteLine("Pazartesi");
					break;
				case 2:
					Console.WriteLine("Salı");
					break;
				case 3:
					Console.WriteLine("Çarşamba");
					break;
				case 4:
					Console.WriteLine("Perşembe");
					break;
				case 5:
					Console.WriteLine("Cuma");
					break;
				case 6:
					Console.WriteLine("Cumartesi");
					break;
				case 7:
					Console.WriteLine("Pazar");
					break;
				default:
					Console.WriteLine("Geçersiz gün numarası");
					break;
			}

			// Question3
			Console.Write("Birinci sayi: ");
			double num1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("İkinci sayi: ");
			double num2 = Convert.ToDouble(Console.ReadLine());

			Console.Write("işlemi girin (+, -, *, /): ");
			char operation = Convert.ToChar(Console.ReadLine());

			double result;

			switch (operation)
			{
				case '+':
					result = num1 + num2;
					Console.WriteLine("Sonuç: " + result);
					break;
				case '-':
					result = num1 - num2;
					Console.WriteLine("Sonuç: " + result);
					break;
				case '*':
					result = num1 * num2;
					Console.WriteLine("Sonuç: " + result);
					break;
				case '/':
					if (num2 != 0)
					{
						result = num1 / num2;
						Console.WriteLine("Sonuç: " + result);
					}
					else
					{
						Console.WriteLine("Bir sayi 0'a bölünemez.");
					}
					break;
				default:
					Console.WriteLine("Geçersiz işlem.");
					break;
			}

			// Question4
			Console.Write("Birinci sayi: ");
			int n1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("İkinci sayi: ");
			int n2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Üçüncü sayi: ");
			int n3 = Convert.ToInt32(Console.ReadLine());

			int largest;

			if (n1 >= n2 && n1 >= n3)
				largest = n1;
			else if (n2 >= n1 && n2 >= n3)
				largest = n2;
			else
				largest = n3;

			Console.WriteLine("En büyük sayi: " + largest);

			// Question5
			Console.Write("Şifre girin: ");
			string password = Console.ReadLine();

			bool hasUpperCase = false;
			bool hasSpecialChar = false;

			foreach (char c in password)
			{
				if (char.IsUpper(c))
					hasUpperCase = true;
				if ("@#$%".Contains(c))
					hasSpecialChar = true;
			}

			if (password.Length >= 8 && hasUpperCase && hasSpecialChar)
				Console.WriteLine("guclu");
			else
				Console.WriteLine("zayif");

		}
	}
}