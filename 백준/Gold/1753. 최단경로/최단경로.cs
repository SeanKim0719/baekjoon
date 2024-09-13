var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
var start = int.Parse(Console.ReadLine());
var edge = Enumerable.Range(0, input[0]+1).Select(x => new List<(int node,int distance)>()).ToList();
var dis = Enumerable.Repeat(-1, input[0]).ToArray();
var visit = new bool[input[0] + 1];
for(int i = 0; i < input[1]; i++)
{
    var len = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    edge[len[0]].Add((len[1], len[2]));
}
dijkstra(start);
var ans = dis.Select(x => x == -1? "INF":$"{x}");
Console.WriteLine(string.Join("\n",ans));

void dijkstra(int start)
{
    var pq = new PriorityQueue<int,int>();
    pq.Enqueue(start,0);
    dis[start-1] = 0;
    while (pq.Count > 0)
    {
        var node = pq.Dequeue();
        if (!visit[node])
        {
            visit[node] = true;
            foreach (var next in edge[node])
            {
                if (dis[next.node-1] == -1)
                {
                    dis[next.node-1] = dis[node-1] + next.distance;
                }
                else
                {
                    dis[next.node-1] = Math.Min(dis[next.node-1], dis[node-1] + next.distance);
                }
                pq.Enqueue(next.node,dis[next.node-1]);
            }
        }
    }
}