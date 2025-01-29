//  parola en az 6 karakter olmalı.
//  parolada harfler olmalı.
//  parolada rakamlar olmalı.
//  parolada özel karakterler olmalı.   char.IsPunctuation(char c)
bool gecerliMi = false;
do
{
Console.WriteLine("parola girin:");
string parola = Console.ReadLine();



int harfler = 0, rakamlar = 0, sembol = 0;

if(parola.Length >= 6)
{
  foreach(char c in parola)
  {
    if(char.IsLetter(c)) harfler++;
    if(char.IsNumber(c)) rakamlar++;
    if(char.IsSymbol(c) || char.IsPunctuation(c)) sembol++;    
  }
  if(harfler != 0 && rakamlar != 0 && sembol != 0)
  {
    gecerliMi = true;
  }
  else
  {
    Console.WriteLine("parolanızın içinde harfler rakamlar ve semboller eksiksiz olmalıdır.");
  }

  Console.WriteLine($"parola geçerli {gecerliMi}");
}
else
{
  Console.WriteLine("parola en az 6 karakter içermelidir.");
}
}while(gecerliMi==false);


