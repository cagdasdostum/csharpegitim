using ConsoleApp21;

string? path;

do
{
  Console.ForegroundColor = ConsoleColor.White;
  path = Directory.GetCurrentDirectory();
  Console.Write($"{Path.GetFileName(path)}>");
  string? komut = Console.ReadLine();
  string[] komutArg = komut.Split(' ');

  switch (komutArg[0])
  {
    case "help":  KomutHelp.Calistir(); break;
    case "exit": return; //return ile uygulama biticek.
    default: Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Komut bulunamadı.");
    break;
  }
}while(true);