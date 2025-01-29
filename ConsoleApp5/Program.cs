
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> ogrenciler = new(); //c# yeni versiyonlarındda böyle kullanılabiliyormuş.
        int numara = 0;
        string ad = "";
        do
        {
            Console.WriteLine("Eklenecek öğrencinin numarasını girin:");
            numara = Convert.ToInt32(Console.ReadLine());
            if (numara != 0)
            {

              if(ogrenciler.ContainsKey(numara))
              {
                Console.WriteLine($"{numara} numaralı öğrenci zaten var.");
                continue;
              } 
                

                Console.WriteLine("Eklenecek öğrencinin adını girin:");
                ad = Console.ReadLine();

                ogrenciler.Add(numara, ad); //yeni öğrenciyi listeye ekle.
            }



        } while (numara != 0);

        Console.WriteLine("Öğrenci No | Öğrenci Adı");
        foreach(var ogr in ogrenciler)
        {
          Console.WriteLine($"{ogr}");
        }
    }
}