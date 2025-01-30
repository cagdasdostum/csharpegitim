
namespace ConsoleApp16;

public class MenuEkranı
{
  public static int Goster()
  {
    Console.WriteLine("-----------------DOTNET BANK------------------");
    Console.Clear();
    Console.WriteLine("1- Müşteri Ekle");
    Console.WriteLine("2- Müşterileri Listele");
    Console.WriteLine("3- Hesap Aç");
    Console.WriteLine("4- Para Çek");
    Console.WriteLine("5- Para Yatır");
    Console.WriteLine("6- Havale Yap");
    Console.WriteLine("0- Çıkış Yap");
    Console.WriteLine("Seçiminizi girin:");
    return Convert.ToInt32(Console.ReadLine());
    
  }
}
