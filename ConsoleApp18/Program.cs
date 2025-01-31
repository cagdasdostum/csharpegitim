using System.IO;
Console.ForegroundColor = ConsoleColor.DarkYellow;
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

Console.ForegroundColor = ConsoleColor.DarkBlue;
string[] altDosyalar = Directory.GetFiles(cDiski, "*.sys"); // dosya uzantısı filtresi uyguladık.
Console.WriteLine($"Dosyalar: {altDosyalar.Length}");

foreach (string dosya in altDosyalar)
{
  Console.WriteLine(dosya);
}


//File.Create(path+@"\new.txt");

string kaynakDosya = @"C:\BtkCSharp\new.txt";
string hedefDosya = @"C:\BtkCSharp\yeniDegisik.txt";

File.Move(kaynakDosya, hedefDosya);