StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
var heap = new PriorityQueue<int,int>();
int n = int.Parse(sr.ReadLine());
for(int i = 0; i < n; i++)
{
    int input = int.Parse(sr.ReadLine());
    if (input == 0)
    {
        if(heap.Count == 0) { sw.WriteLine(0); }
        else { sw.WriteLine(heap.Dequeue()); }
    }
    else
    {
        heap.Enqueue(input,input);
    }
}
sr.Close();
sw.Close();