int[] sayilar = {5,1,65,7,8,9,0};

Console.WriteLine(sayilar[2]);
Console.WriteLine(sayilar[^2]);
Console.WriteLine(sayilar[2..5]); //ekrana istediğimiz değeri yazdırmaz veri tipini yazdırır. foreach kullanarak yazılabilir.

var yeniDizi2 = sayilar[^7..];
foreach(var s in yeniDizi2)
{
  Console.Write(s + " ");
}