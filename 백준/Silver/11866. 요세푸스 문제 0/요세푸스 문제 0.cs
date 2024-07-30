int[] num = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int N = num[0];
int K = num[1];
int index = 0;
List<int> list = new List<int>();
Queue<int> queue = new Queue<int>();
for(int i = 1; i <= N; i++)
{
    list.Add(i);
}
while(list.Count>0)
{
    index = (index + K - 1) % list.Count;
    queue.Enqueue(list[index]);
    list.RemoveAt(index);
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