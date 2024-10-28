using System.Threading.Channels;

var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0],m = input[1];
var nodes = Enumerable.Range(0,n+1).Select(x => new List<int>()).ToList();
var rank = Enumerable.Repeat(0,n+1).ToArray();
var que = new Queue<int>();
var ans = new List<int>();
for(int i = 0; i < m; i++)
{
    var order = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 1; j < order[0]; j++)
    {
        nodes[order[j]].Add(order[j+1]);
        rank[order[j+1]]++;
    }
}
for(int i = 1; i <= n; i++)
{
    if (rank[i] == 0) { que.Enqueue(i); }
}
while (que.Count > 0)
{
    int point = que.Dequeue();
    ans.Add(point);
    foreach (var node in nodes[point])
    {
        rank[node]--;
        if (rank[node] == 0) { que.Enqueue(node);}
    }
}
Console.WriteLine(rank.All(x => x == 0) ? string.Join("\n", ans) :0);