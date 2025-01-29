Console.WriteLine("bir sayı girin:");
int sayi = Convert.ToInt32(Console.ReadLine());

if(sayi>0)
{
  int sonuc = 1;
  for(int i = sayi; i >=1; i--)
  {
    sonuc*=i;
  }

  Console.WriteLine($"{sayi}! = {sonuc}");
}
else
{
  Console.WriteLine("negatif sayıların faktöriyeli hesaplanamaz.");
}