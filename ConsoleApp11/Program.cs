namespace ConsoleApp11;

class Program
{
    static void Main(string[] args)
    {
        int toplamDeger = Topla(34,56);
        Console.WriteLine(toplamDeger);
        EkraniTemizle();
        Console.WriteLine(Topla(5,14));
        Bekle();


    
    }

    static void EkraniTemizle()
    {
        Console.Clear();
    }

    static void Bekle()
    {
        Console.WriteLine("Çıkmak için bir tuşa basın");
        Console.ReadKey();
    }

    public static int Topla(int a, int b)
    {
        int sonuc = a+b;
        return sonuc;                
    }
}
