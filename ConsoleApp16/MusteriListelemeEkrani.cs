using System;

namespace ConsoleApp16;

public class MusteriListelemeEkrani
{
  public static void Goster(List<Musteri> liste)
  {
    Console.Clear();
    Console.WriteLine("Müşteri Listesi");

    foreach (Musteri m in liste)
    {
      m.Yazdir();
    }

    Console.WriteLine("Müşteriler listelendi. Devam etmek için bir tuşa bas.");
    Console.ReadKey();
  }
}
