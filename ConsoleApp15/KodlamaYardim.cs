namespace ConsoleApp15;

public class KodlamaYardim
{
  public static bool UygunMu(string ad)
  {
    //  1- sayı ile başlayamaz
    //  2- içinde boşluk ve özel karakter olamaz
    Console.WriteLine($"{ad} Kontrol ediliyor.....");
    
    if(char.IsDigit(ad[0]))
      return false;
    
    foreach (char c in ad)
    {
      if(char.IsWhiteSpace(c))
        return false;
      else if(char.IsSymbol(c))
        return false;
      else if(char.IsPunctuation(c))
        return false;
    }
    
    return true;

  }
}
