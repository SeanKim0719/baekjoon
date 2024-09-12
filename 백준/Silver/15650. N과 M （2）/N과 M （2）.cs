using System.Text;
var sb = new StringBuilder();
var input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int n = input[0], m = input[1];
var arr = new int[n+1];
var use = new bool[n+1];
dfs(0, 1);
Console.WriteLine(sb.ToString());
void dfs(int cnt,int num)
{
    if (cnt == m)
    {
        for (int i = 0; i < m; i++)
        {
            sb.Append($"{arr[i]} ");
        }
        sb.Append("\n");
        return;
    }
    for (int i = num; i <= n; i++)
    {
        if (!use[i])
        {
            use[i] = true;
            arr[cnt] = i;
            dfs(cnt + 1, i + 1);
            use[i] = false;
        }
    }
}