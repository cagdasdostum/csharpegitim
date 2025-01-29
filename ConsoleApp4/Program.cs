using System.Collections;

ArrayList arrayList = new ArrayList();

arrayList = ["izmir", 20, "makü", true];
arrayList.Add("btk");
arrayList.Insert(1,35);

foreach(var i in arrayList)
{
  Console.WriteLine(i);
}

List<int> liste = [5,4,1,2,7,8,9];
liste.RemoveAt(liste.Count-1);
liste.Add(3);
liste.AddRange([1,8,4]);
liste.Insert(0,11);

foreach(var i in liste)
{
  Console.Write($"{i}, ");
}