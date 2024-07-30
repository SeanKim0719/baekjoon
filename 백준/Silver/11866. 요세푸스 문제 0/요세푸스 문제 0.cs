int[] num = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int N = num[0];
int K = num[1];
List<int> list = new List<int>();
Queue<int> queue = new Queue<int>();
for(int i = 1; i <= N; i++)
{
    list.Add(i);
}
list.TrimExcess();
for (int i = K-1; list.Count > 0; i += K-1)
{ 
    if(i >= list.Count)
    {
        while (i >= list.Count)
        {
            i -= list.Count;
        }
        queue.Enqueue(list[i]);
        list.RemoveAt(i);
    }
    else
    {
        queue.Enqueue(list[i]);
        list.RemoveAt(i);
    }
}
for (int i = 0; i < list.Count; i++) 
{
    queue.Enqueue(list[i]);
}
if (queue.Count == 1)
{
    Console.WriteLine("<{0}>", queue.Dequeue());
}
else
{
    Console.Write("<{0}, ", queue.Dequeue());
    while (queue.Count > 1)
    {
        Console.Write(queue.Dequeue() + ", ");
    }
    Console.Write("{0}>", queue.Dequeue());
}