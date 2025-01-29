internal class Program
{
    private static void Main(string[] args)
    {
        string[] isimler = new string[3];
        int[] notlar = new int[3];


        for (int i = 0; i < isimler.Length; i++)
        {
            Console.WriteLine($"{i + 1}. öğrencinin ismini girin");
            isimler[i] = Console.ReadLine();
        }

        for (int i = 0; i < notlar.Length; i++)
        {
            Console.WriteLine($"{i + 1}. öğrencinin notunu girin");
            notlar[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine("Öğrenci listesi:");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");

        foreach (string isim in isimler)
        {
            Console.Write($"{isim,-20} | ");
        }


        Console.WriteLine("");
        Console.WriteLine("Not listesi:");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");

        foreach (int not in notlar)
        {
            Console.Write($"{not,-20} | ");
        }


        Console.WriteLine("");

        int enBuyuk = int.MinValue;
        string enBasarili = "";

        for (int i = 0; i < notlar.Length; i++)
        {
            if (notlar[i] > enBuyuk)
            {
                enBuyuk = notlar[i];
                enBasarili = isimler[i];
            }
        }

        Console.WriteLine($"en başarılı öğrenci: {enBasarili} | notu: {enBuyuk}");
    }
}