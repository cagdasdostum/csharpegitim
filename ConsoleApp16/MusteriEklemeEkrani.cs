namespace ConsoleApp16;

public class MusteriEklemeEkrani
{
  public static void Goster(List<Musteri> liste)
  {
    Console.Clear();
    Console.WriteLine("Eklemek istediğiniz müşterinin adı soyadı:");
    string? adSoyad = Console.ReadLine();

    Musteri musteri = new();
    musteri.AdSoyad = adSoyad;
    musteri.MusteriNo = (int)DateTime.Now.Ticks;

    liste.Add(musteri);
    Console.WriteLine("Müşteri eklendi. Devam etmek için bir tuşa bas.");
    Console.ReadKey();
  }
}
