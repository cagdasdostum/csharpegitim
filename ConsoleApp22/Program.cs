using System.Text.Json;

Console.WriteLine("JSON işlemleri");

Kisi kisi = new(){Id = 1, Ad = "Kemal", Soyad = "Can", Tel = "5554446674"};

string jsonText = JsonSerializer.Serialize(kisi);
Console.WriteLine("Serileştirme " + jsonText);

Kisi jsonKisi = JsonSerializer.Deserialize<Kisi>(jsonText);
Console.WriteLine($"Geri Serileştirme: {jsonKisi.Id} - " +
$"{jsonKisi.Ad} {jsonKisi.Soyad} {jsonKisi.Tel}");

class Kisi
{
  public int Id { get; set; }
  public string Ad { get; set; }
  public string Soyad { get; set; }
  public string Tel { get; set; }
  
}