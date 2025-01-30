//  klavyeden girilen bir metni stack kullanarak tersinden yazdırın.
//  örnek: programlama => amalmargorp



internal class Program
{
    private static void Main(string[] args)
    {
        Stack<char> yigin = new();
        string? metin;

        Console.WriteLine("metin girin:");
        metin = Console.ReadLine();




        foreach (char c in metin)
        {
            yigin.Push(c);
        }

        while (yigin.Count > 0)
        {
            char c = yigin.Pop();
            Console.Write($"{c}");
        }
    }
}