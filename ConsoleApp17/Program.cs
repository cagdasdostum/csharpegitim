Console.WriteLine("hesaplama uygulaması");
int s1 = 0, s2 = 0;
try
{
Console.WriteLine("1.sayıyı girin:");
s1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.sayıyı girin:");
s2 = Convert.ToInt32(Console.ReadLine());

}catch(Exception e)
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine(e.Message);
  return;
}
finally
{
  Console.ForegroundColor = ConsoleColor.White;
}

int top = s1+s2;

Console.WriteLine($"{s1} + {s2} = {top}");

