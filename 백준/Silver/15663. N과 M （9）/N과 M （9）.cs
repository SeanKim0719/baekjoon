using System.Text;

var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0],m = input[1];
var arr = Console.ReadLine().Split().Select(int.Parse).OrderBy(x=>x).ToList();
var visited = new bool[n+1];
var select = new int[m+1];
var ans = new List<string>();
dfs(0);
Console.WriteLine(string.Join("\n",ans.Distinct()));
void dfs(int cnt)
{
    if(cnt == m)
    {
        var sb = new StringBuilder();
        for(int i = 0; i < m; i++) { sb.Append($"{select[i]} ");}
        ans.Add(sb.ToString());
        return;
    }
    for(int i = 0; i < n; i++)
    {
        if (!visited[i]) 
        {
            visited[i] = true;
            select[cnt] = arr[i];
            dfs(cnt+1);
            visited[i] = false;
        }
    }
}