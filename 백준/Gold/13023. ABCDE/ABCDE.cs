var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0], m = input[1];
var node = Enumerable.Range(0, n).Select(_ => new List<int>()).ToList();
int ans = 0;
bool chk = false;
var visit = new bool[n];
for (int i = 0; i < m; i++)
{
    var egdes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    node[egdes[0]].Add(egdes[1]);
    node[egdes[1]].Add(egdes[0]);
}
for (int i = 0; i < n; i++)
{
    DFS(i, 0);
    if (chk) { ans++; break; }
}
Console.WriteLine(ans);
void DFS(int x, int cnt)
{
    if (cnt == 4 || chk)
    { 
        chk = true;
        return;
    }
    visit[x] = true;
    foreach (int i in node[x])
    {
        if (!visit[i])
        {
            DFS(i, cnt+1);
        }
    }
    visit[x] = false;
}