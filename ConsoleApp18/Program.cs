using System.IO;

string path = @"C:\BtkCSharp";
string cDiski = @"C:\\";
Directory.CreateDirectory(path);
Console.WriteLine($"{path} isimli klasör oluşturuldu.");

if (Directory.Exists(path))
{
  Console.WriteLine("Klasör bu dizinde zaten var.");
}

string[] altKlasorler = Directory.GetDirectories(cDiski);
Console.WriteLine($"Klasörler: {altKlasorler.Length}");
foreach (string klasor in altKlasorler)
{
  Console.WriteLine(klasor);
}

string[] altDosyalar = Directory.GetFiles(cDiski);
Console.WriteLine($"Dosyalar: {altDosyalar.Length}");

foreach (string dosya in altDosyalar)
{
  Console.WriteLine(dosya);
}