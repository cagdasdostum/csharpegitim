// diziler

char[] array = {'a','r','r','a','y'};

Console.WriteLine(array.Length);
array.SetValue('d',1);  // 1.indexteki 'r' değerini 'd' ile değiştirdik.
Console.WriteLine(array.GetValue(1));

string[] sehirler = new string[4];
sehirler[0] = "izmir";
sehirler[1] = "manisa";
sehirler[2] = "denizli";
sehirler[3] = "burdur";

for(int i = 0; i<sehirler.Length; i++)
{
  Console.WriteLine(sehirler[i]);
}

