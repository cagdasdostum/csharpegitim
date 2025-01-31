using System;

namespace ConsoleApp21;

public class KomutCd
{
  public static void Calistir(string path, string[] args)
  {
    if(args.Length < 2)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("komut parametreleri eksik ya da geçersiz.");
      return;
    }

    string? hedefPath ="";
    string hedef = args[1]; //hedef klasör ya da ..
    if(hedef == "..") //bir üst klasör
    {
      hedefPath = Path.GetDirectoryName(path);
    }
    
      else
      {
        string[] altKlasorler = Directory.GetDirectories(path);
        foreach (string klasor in altKlasorler)
        {
          if (Path.GetFileName(klasor) == hedef)
          {
            hedefPath = klasor;
            break;
          }
        }

      }

      if(!string.IsNullOrEmpty(hedefPath))
      {
        Directory.SetCurrentDirectory(hedefPath);
      }
      else
      {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Dosya ya da klasör bulunamadı.");
        return;
      }


    
  }
}
