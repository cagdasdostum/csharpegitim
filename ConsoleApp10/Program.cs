Kitap[] kitaplar = {
  new(){Ad = "C# Öğreniyorum", Fiyat = 199.99, SayfaAdedi = -5},
  new(){Ad = "Python", Fiyat = 179.99, SayfaAdedi = 140},
  new(){Ad = "Yapay Zeka Temelleri", Fiyat = 259.99, SayfaAdedi = 90}
  };

Console.OutputEncoding = System.Text.Encoding.UTF8;

  foreach (Kitap k  in kitaplar)
  {
    Console.WriteLine($"Kitap Adı:{k.Ad}, Fiyat:{k.Fiyat:c2}, Sayfa Adedi:{k.SayfaAdedi}");
  }

class Kitap
{
  private int sayfa;
  public string? Ad {get; set;}
  public double Fiyat {get; set;}
  public int SayfaAdedi {
    get => sayfa;
    set => sayfa = value < 0 ? 0 : value;}

}