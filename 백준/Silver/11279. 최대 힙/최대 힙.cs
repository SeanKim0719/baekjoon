Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
var h = new PriorityQueue<int,int>();
int n = int.Parse(Console.ReadLine());
while(n>0)
{
    int s = int.Parse(Console.ReadLine());
    if (s == 0){if(h.Count == 0) Console.WriteLine(0);else Console.WriteLine(h.Dequeue());}
    else h.Enqueue(s,-s);
    n--;
}
Console.Out.Flush();