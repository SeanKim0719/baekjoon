var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
var start = int.Parse(Console.ReadLine());
var edge = Enumerable.Range(0, input[0]+1).Select(x => new List<(int node,int distance)>()).ToList();
var dis = Enumerable.Repeat(-1, input[0]).ToArray();
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
    var pq = new PriorityQueue<(int pos,int distance),int>();
    pq.Enqueue((start,0),0);
    dis[start-1] = 0;
    while (pq.Count > 0)
    {
        var node = pq.Dequeue();
        foreach (var next in edge[node.pos])
        {
            if (dis[next.node - 1] == -1)
            {
                dis[next.node - 1] = next.distance + dis[node.pos-1];
                pq.Enqueue(next, dis[next.node - 1]);
            }
            else if (dis[node.pos-1] + next.distance < dis[next.node-1])
            {
                dis[next.node-1] = dis[node.pos-1] + next.distance;
                pq.Enqueue(next, dis[next.node - 1]);
            }
        }
    }
}