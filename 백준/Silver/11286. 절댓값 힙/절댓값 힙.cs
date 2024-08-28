Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
var h = new PriorityQueue<int,double>();
int n = int.Parse(Console.ReadLine());
while(n>0)
{
    int s = int.Parse(Console.ReadLine());
    if (s==0){if(h.Count==0) Console.WriteLine(0);else Console.WriteLine(h.Dequeue());}
    else { if (s<0)h.Enqueue(s, Math.Abs(s) - 0.1);else h.Enqueue(s,s+0.1);}
    n--;
}
Console.Out.Flush();