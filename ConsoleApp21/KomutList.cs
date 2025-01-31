using System;

namespace ConsoleApp21;

public class KomutList
{
  public static void Calistir(string path, string[] args)
  {
    string[] klasorler = Directory.GetDirectories(path);
    string[] dosyalar = Directory.GetFiles(path);

    Console.ForegroundColor = ConsoleColor.Yellow;
    foreach (string klasor in klasorler)
    {
      Console.WriteLine(Path.GetFileName(klasor));
    }

    foreach (string dosya in dosyalar)
    {
      Console.WriteLine(Path.GetFileName(dosya));
    }
  }
}
