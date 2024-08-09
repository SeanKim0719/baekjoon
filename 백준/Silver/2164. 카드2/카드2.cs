int N = int.Parse(Console.ReadLine());
Queue<int> list = new Queue<int>();
for(int i = 1; i <= N; i++)
{
    list.Enqueue(i);
}
while (list.Count > 1)
{
    list.Dequeue();
    list.Enqueue(list.Dequeue());
}
Console.WriteLine(list.Dequeue());