var n = int.Parse(Console.ReadLine());
var planet = new List<(int x, int y, int z, int num)>();
var root = Enumerable.Range(0, n+1).ToList();
var rank = Enumerable.Repeat(0, n+1).ToList();
var pq = new PriorityQueue<(int gap,int first,int second), int>();
int ans = 0, cnt = 0;
for(int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToList();
    planet.Add((input[0], input[1],input[2],i+1));
}
AddEdges(planet,pq,p=>p.x);
AddEdges(planet,pq,p=>p.y);
AddEdges(planet,pq,p=>p.z);
while (cnt < n-1)
{
    var get = pq.Dequeue();
    if (Find(get.first) != Find(get.second))
    {
        Union(get.first, get.second);
        ans += get.gap; cnt++;
    }
}
Console.WriteLine(ans);
int Find(int x)
{
    if (x == root[x]) { return x; }
    return root[x] = Find(root[x]);
}
void Union(int x,int y)
{
    x = Find(x); y = Find(y);
    if(x == y) { return; }
    if (rank[x] > rank[y]) { root[y] = x; }
    else if (rank[x] < rank[y]) { root[x] = y; }
    else { root[y] = x; rank[x]++; }
}
void AddEdges(List<(int x, int y, int z, int num)> planets, PriorityQueue<(int gap, int first, int second), int> pq,
              Func<(int x, int y, int z, int num), int> selector)
{
    planets.Sort((a, b) => selector(a).CompareTo(selector(b)));
    for (int i = 1; i < planets.Count; i++)
    {
        int gap = selector(planets[i]) - selector(planets[i - 1]);
        pq.Enqueue((gap, planets[i - 1].num, planets[i].num), gap);
    }
}
