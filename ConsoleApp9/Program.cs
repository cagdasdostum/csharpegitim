List<Ogrenci> liste = new();


do
{
    Console.WriteLine("Eklenecek numara:");
    int num = Convert.ToInt32(Console.ReadLine());
    
    if(num==0)  break;

    Console.WriteLine("İsmini girin:");
    string? isim = Console.ReadLine();
    Console.WriteLine("Ortalamasını girin:");
    double ort = Convert.ToDouble(Console.ReadLine());

    Ogrenci ogr = new();
    ogr.numara = num;
    ogr.isim = isim;
    ogr.ortalama = ort;

    liste.Add(ogr);


} while (true);

foreach (Ogrenci o in liste)
{
    Console.WriteLine($"no:{o.numara}, isim:{o.isim}, ortalama:{o.ortalama}");
}





class Ogrenci
{
    public int numara;
    public string? isim;
    public double ortalama;

}



