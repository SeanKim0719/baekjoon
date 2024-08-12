int com = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
List<int>[] list = new List<int>[com+1];
bool[] visit = new bool[com+1];
int count = 0;

for(int i = 1; i <= com; i++)
{
    list[i] = new List<int>();
}

for(int i = 0;i < N; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
    list[input[0]].Add(input[1]);
    list[input[1]].Add(input[0]);
} // 맵만들기

DFS(1, list, visit);

for(int i = 2; i <= com; i++)
{
    if (visit[i] == true) count++;
} // 연결된 노드 더하기

Console.WriteLine(count);

static void DFS(int node, List<int>[] list, bool[] visit)
{
    visit[node] = true;

    foreach (int i in list[node])
    {
        if (visit[i] != true)
        {
            DFS(i, list, visit);
        }
    }
} // 깊이탐색