// 1-	For döngüsü ile sayının rakamlarının toplamını bulan algoritmayı yazınız.
// 2-	while döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritmayı yazınız(Kullanıcıdan 10 ile 100 arasında bir sayı al ve eğer bu aralık dışında girerse tekrar iste.)
// 3-	foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritmayı yazınız.( 0-12: Çocuk, 13-19: Genç, 20-64: Yetişkin, 65+: Yaşlı.)
// 4-	Bir dizide tekrar eden elemanları bulan algoritmayı yazınız.
// 5-	Bir dizide en uzun ve en kısa kelimeyi bulan algoritmayı yazınız.
// 6-	Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritmayı yazınız.
// 7-	Bir string dizisinin boyutunu dinamik olarak genişleten algoritmayı yazınız.
// 8-	Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran algoritmayı yazınız.
// 9-	Kullanıcıdan ratgele sayılar alıp listeye ekleyen,bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritmayı yazınız.
// 10-	Bir sayı listesinde 10’dan küçük olanları silen algoritmayı yazınız.
// 11-	Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.

class Program
{
    static void Main()
    {
        // 1- For döngüsü ile sayının rakamlarının toplamını bulan algoritma
        int number = 12345;
        int sum = 0;
        for (int temp = number; temp > 0; temp /= 10)
        {
            sum += temp % 10;
        }
        Console.WriteLine("Sum of digits: " + sum);

        // 2- While döngüsü ile belirli şartlara uyan bir değer alma algoritması
        int input = 0;
        while (input < 10 || input > 100)
        {
            Console.Write("Enter a number (10-100): ");
            bool isValid = int.TryParse(Console.ReadLine(), out input);
            if (!isValid)
            {
                Console.WriteLine("Invalid input, please enter a number.");
                input = 0; // Hatalı girişte döngünün devam etmesini sağlamak için sıfırla
            }
        }
        Console.WriteLine("Valid number: " + input);

        // 3- Foreach döngüsü ile yaş kategorisi belirleme algoritması
        int[] ages = { 5, 17, 30, 70 };
        foreach (int age in ages)
        {
            string category = age < 13 ? "Çocuk" :
                              age < 20 ? "Genç" :
                              age < 65 ? "Yetişkin" : "Yaşlı";
            Console.WriteLine($"Age {age}: {category}");
        }

        // 4- Dizide tekrar eden elemanları bulan algoritma
        int[] numbers = { 1, 2, 3, 2, 4, 5, 6, 1, 7, 8, 5 };
        var duplicates = numbers.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine("Duplicates: " + string.Join(", ", duplicates));

        // 5- Dizide en uzun ve en kısa kelimeyi bulan algoritma
        string[] words = { "apple", "banana", "cherry", "kiwi", "watermelon" };
        string longest = words.OrderByDescending(w => w.Length).First();
        string shortest = words.OrderBy(w => w.Length).First();
        Console.WriteLine($"Longest: {longest}, Shortest: {shortest}");

        // 6- Kullanıcının girdiği bir cümleyi diziye kaydedip sıralayan algoritma
        Console.Write("Enter a sentence: ");
        string[] sentenceWords = Console.ReadLine().Split(' ').OrderBy(w => w).ToArray();
        Console.WriteLine("Sorted words: " + string.Join(", ", sentenceWords));

        // 7- String dizisinin boyutunu dinamik olarak genişleten algoritma
        List<string> dynamicList = new List<string> { "one", "two" };
        dynamicList.Add("three");
        dynamicList.Add("four");
        Console.WriteLine("Expanded list: " + string.Join(", ", dynamicList));

        // 8- Kullanıcının girdiği kelimeleri listeye kaydedip tersten yazdıran algoritma
        List<string> wordList = new List<string>();
        Console.WriteLine("Enter words (type 'exit' to stop):");
        while (true)
        {
            string word = Console.ReadLine();
            if (word == "exit") break;
            wordList.Add(word);
        }
        wordList.Reverse();
        Console.WriteLine("Reversed words: " + string.Join(", ", wordList));

        // 9- Kullanıcıdan rastgele sayılar alıp listeye ekleyen, ortalamasını alan ve sıralayan algoritma
        List<int> randomNumbers = new List<int>();
        Console.WriteLine("Enter numbers (type -1 to stop):");
        while (true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == -1) break;
            randomNumbers.Add(num);
        }
        Console.WriteLine("Sorted: " + string.Join(", ", randomNumbers.OrderBy(n => n)));
        Console.WriteLine("Average: " + randomNumbers.Average());

        // 10- Sayı listesinde 10’dan küçük olanları silen algoritma
        List<int> numberList = new List<int> { 3, 15, 8, 20, 7, 12 };
        numberList.RemoveAll(n => n < 10);
        Console.WriteLine("Filtered list: " + string.Join(", ", numberList));

        // 11- Öğrenci notlarını 50’nin altındaysa 50 olarak güncelleyen algoritma
        List<int> grades = new List<int> { 45, 60, 30, 90, 50 };
        grades = grades.Select(g => g < 50 ? 50 : g).ToList();
        Console.WriteLine("Updated grades: " + string.Join(", ", grades));
    }
}
