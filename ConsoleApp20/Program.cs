//sayilar.txt isimli dosyadaki aralarında virgül bulunan sayıları toplayan ve sonucu ekranda gösteren uygulama

string? dosyaYolu = @"C:\BtkCSharp";

//File.Create(dosyaYolu+@"\sayilar.txt"); // sayilar.txt oluşturduk.

if(File.Exists(dosyaYolu+@"\sayilar.txt"))
{
  string icerik = File.ReadAllText(dosyaYolu+ @"\sayilar.txt");
  string[] sayilarStr = icerik.Split(',');

  int toplam = 0;
  foreach (string s in sayilarStr)
  {
    int sayi = Convert.ToInt32(s);
    toplam += sayi;
  }

  Console.Write($"Sayılar: {icerik}");
  Console.WriteLine("\nToplam: " + toplam);
}
else
{
  Console.WriteLine("Dosya bulunamadı..");
}
