int[] RasgeleUret()
{
  List<int> sonuc = new();
  Random rnd = new();

  while(sonuc.Count<6)
  {
    int sayi = rnd.Next(0, 2);
    /*if(!sonuc.Contains(sayi))*/ //dizi içinde aynı sayıdan birden fazla içermemesi için
      sonuc.Add(sayi);

  }

  return sonuc.ToArray(); //listeyi diziye dönüştürme metodu
}

void Yazdir(int[] liste) 
{
  foreach (var s in liste)
  {
    Console.Write($"{s}, ");
  }
  Console.WriteLine("");
}


//  ana program burası
for(int i = 0; i<6; i++)
{
  int[] sayilar = RasgeleUret();
  Yazdir(sayilar);
}