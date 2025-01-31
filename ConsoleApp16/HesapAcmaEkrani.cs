namespace ConsoleApp16;

public class HesapAcmaEkrani
{
  public static void Goster(List<Hesap> liste)
  {
    Console.Clear();
    Console.WriteLine("Hesap numaranız oluşturuluyor....");
    Hesap hesap = new();
    hesap.HesapNumarasi = (int)DateTime.Now.Ticks;

    Console.WriteLine("Hesap türünüzü yazınız(Bireysel/Ticari):");
    hesap.Bakiye = 0;
  }
}
