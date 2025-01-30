
//Main----------------------------------------
Ogrenci yeniOgrenci = new Ogrenci();  //sınıftan yeni bir nesne(örnek) oluşturduk.

yeniOgrenci.numara = 10;
yeniOgrenci.ad = "çağdaş";

Ogrenci baskaOgrenci = new(); //sınıftan başka bir nesne(örnek) oluşturduk.
baskaOgrenci.numara = 5;
baskaOgrenci.ad = "ömer";

Console.WriteLine($"Yeni öğrenci numara:{yeniOgrenci.numara}, ad:{yeniOgrenci.ad}");
Console.WriteLine($"Başka öğrenci numara:{baskaOgrenci.numara}, ad:{baskaOgrenci.ad}");



///-------------------------------------------- 
class Ogrenci //sınıfı tanımladık
{
  public int numara;
  public string ad;
}