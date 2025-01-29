
int[] sayilar = {4,8,2,1,-3};

Console.WriteLine($"sayı adedi: {sayilar.Length}");
Console.WriteLine("Dizideki sayılar:");
for(int i = 0; i<sayilar.Length; i++)
{
  Console.Write($"{sayilar[i]}, ");
}

int toplam = 0;

foreach(int sayi in sayilar) 
{
  toplam += sayi;
}

Console.WriteLine( $"\ntoplam: {toplam}");