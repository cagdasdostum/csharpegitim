// Müşteriler var
// Müşterilere ait hesaplar
// Müşteri eklenebilir
// Müşteriler listelenebilir
// Müşteriye hesap açılabilir
// Hesaba para yatırılabilir, çekilebilir
// Bir hesaptan başka hesaba havale edilebilir.

using ConsoleApp16;

int secim = 0;
List<Musteri> musteriListesi = new();
do
{
  secim = MenuEkranı.Goster();

  switch (secim)
  {
    case 0: Console.WriteLine("Uygulama sona erdi..."); break;
    case 1: MusteriEklemeEkrani.Goster(musteriListesi); break;
    case 2: MusteriListelemeEkrani.Goster(musteriListesi); break;
    default:
      Console.WriteLine("Hatalı seçim.."); 
      Console.ReadKey();
      break;

  }
}while(secim != 0);