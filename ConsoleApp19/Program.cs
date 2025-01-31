string? folderPath = @"C:\BtkCSharp";
if(!Directory.Exists(folderPath))
{
  Directory.CreateDirectory(folderPath);
  Console.WriteLine("Klasör oluşturuldu.");
}

string filePath = folderPath + @"\merhaba.txt";
string icerik = "Merhaba c# programlama dili";

File.WriteAllText(filePath, icerik);
Console.WriteLine("İçerik oluştruldu.");

string okunan = File.ReadAllText(filePath);
Console.WriteLine($"Okunan veri: {okunan}");

string yeniIcerik = "\nbugün günlerden Cuma";

File.AppendAllText(filePath, yeniIcerik);
