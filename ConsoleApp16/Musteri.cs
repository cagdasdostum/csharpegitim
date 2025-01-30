namespace ConsoleApp16;

public class Musteri
{
  public int MusteriNo
  {
    get; set;
  }

  public string AdSoyad
  {
    get; set;
  }

  public void Yazdir() 
  {
    Console.WriteLine($"Müşteri Numarası: {MusteriNo} | Müşterinin Adı Soyadı: {AdSoyad}");
  }

}
