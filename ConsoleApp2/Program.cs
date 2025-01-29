string metin = "Btk akademi ile, C# programlamaya giriş.";
//  string -> kaarakter dizisi
//  string özelleştirilmiş bir dizidir.

Console.WriteLine(metin[0]);
Console.WriteLine(metin[^1]);
Console.WriteLine(metin[4..11]);

foreach(char c in metin)
{
  Console.Write(c);
}
Console.WriteLine(metin.Length);
string sub = metin.Substring(4,15);
Console.WriteLine(sub);
Console.WriteLine(metin.Trim());

string replaced = metin.Replace("C#","Python");
Console.WriteLine(replaced);

string[] parts = metin.Split(",");
Console.WriteLine(parts[1]);

bool isStartWith = metin.StartsWith("btk"); //false çünkü büyük küçük harf duyarlı..
Console.WriteLine(isStartWith);

Console.WriteLine($"nokta ile mi biter? {metin.EndsWith(".")}");