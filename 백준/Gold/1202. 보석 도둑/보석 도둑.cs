var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0],k = input[1];
var jewels = new List<(int weight,int value)>();
var bags = new List<int>();
var pq = new PriorityQueue<int, int>();
int index = 0;
long max = 0;
for(int i = 0; i < n; i++)
{
    var jewel = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    jewels.Add((jewel[0], jewel[1]));
}
for(int i = 0; i < k; i++)
{
    bags.Add(int.Parse(Console.ReadLine()));
}
jewels.Sort((a,b)=>a.weight.CompareTo(b.weight));
bags.Sort();
foreach(var bag in bags)
{
    while (index < n && jewels[index].weight <= bag)
    {
        pq.Enqueue(jewels[index].value, -jewels[index].value);
        index++;
    }
    if(pq.Count > 0)
    {
        max += pq.Dequeue();
    }
}
Console.WriteLine(max);