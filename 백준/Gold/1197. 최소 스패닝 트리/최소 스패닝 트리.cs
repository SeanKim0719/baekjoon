var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int v = input[0], e = input[1];
var edges = new PriorityQueue<(int start, int end, int weight), int>();
var root = Enumerable.Range(0, v + 1).ToArray();
var rank = Enumerable.Repeat(0, v + 1).ToArray();
int ans = 0;
for(int i = 0; i < e; i++)
{
    var edge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int start = edge[0], end = edge[1], weight = edge[2];
    edges.Enqueue((start,end,weight), weight);
}

while (edges.Count > 0)
{
    var edge = edges.Dequeue();
    if(Find(edge.start) != Find(edge.end))
    {
        Union(edge.start, edge.end);
        ans += edge.weight;
    }
}
Console.WriteLine(ans);

int Find(int x)
{
    if (root[x] == x) { return x; }
    else
    {
        return root[x] = Find(root[x]);
    }
}

void Union(int x, int y)
{
    x = Find(x);
    y = Find(y);
    if(x == y) { return; }
    if (rank[x] == rank[y]) { root[x] = y; }
    else
    {
        root[y] = x;
        if (rank[x] == rank[y]) { rank[x]++; }
    }
}