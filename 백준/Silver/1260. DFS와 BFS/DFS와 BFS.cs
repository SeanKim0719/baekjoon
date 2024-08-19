var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = input[0]; int M = input[1]; int V = input[2];
List<int>[] node = new List<int>[N+1];
bool[] visit_DFS = new bool[N+1];
bool[] visit_BFS = new bool[N+1];
List<int> route_DFS = new List<int>();
List<int> route_BFS = new List<int>();
for (int i = 1; i <= N; i++)
{
    node[i] = new List<int>();
}
for (int i = 0; i < M; i++)
{
    var input_2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    node[input_2[0]].Add(input_2[1]);
    node[input_2[1]].Add(input_2[0]);
}
for(int i = 1; i <= N ; i++)
{
    node[i].Sort();
}

DFS(V, node, route_DFS, visit_DFS);
BFS(V, node, route_BFS, visit_BFS);
Console.WriteLine(string.Join(" ",route_DFS));
Console.WriteLine(string.Join(" ",route_BFS));
static void DFS(int node, List<int>[] edge, List<int> route, bool[] visit)
{
    visit[node] = true;
    route.Add(node);
    foreach(int i in edge[node])
    {
        if (!visit[i])
        {
            DFS(i, edge, route, visit);
        }
    }
}

static void BFS(int node, List<int>[] edge, List<int> route, bool[] visit)
{
    Queue<int> queue = new Queue<int>();
    queue.Enqueue(node);
    while(queue.Count > 0)
    {
        int x = queue.Dequeue();
        visit[x] = true;
        if(!route.Contains(x)) route.Add(x);
        foreach (int i in edge[x])
        {
            if (!visit[i])
            {
                queue.Enqueue(i);
            }
        }
    }
}