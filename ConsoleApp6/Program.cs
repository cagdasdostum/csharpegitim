Queue<int> kuyruk = new();

//eklemek
kuyruk.Enqueue(4); 
kuyruk.Enqueue(3);
kuyruk.Enqueue(6);
kuyruk.Enqueue(9);

while(kuyruk.Count>0)
{
  int eleman = kuyruk.Dequeue();  //kuyruktan çıkıyor
  Console.Write($"{eleman}, ");
}

Console.WriteLine("");

Stack<int> yigin = new();

yigin.Push(4);
yigin.Push(3);
yigin.Push(6);
yigin.Push(9);

while(yigin.Count>0)
{
  int eleman = yigin.Pop();
  Console.Write($"{eleman}, ");
}
