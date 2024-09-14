using System.Text;

var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
var sb = new StringBuilder();
var visit = new bool[input[0]+1];
var ans = Enumerable.Repeat(0, input[1]).ToArray();
Array.Sort(arr);
dfs(0);
Console.WriteLine(sb.ToString());
void dfs(int cnt)
{
    if(cnt == input[1])
    {
        for(int i = 0; i < cnt; i++)
        {
            sb.Append($"{ans[i]} ");
        }
        sb.AppendLine();
        return;
    }
    for(int i = 0; i < input[0]; i++)
    {
        if (!visit[i])
        {
            visit[i] = true;
            ans[cnt] = arr[i];
            dfs(cnt + 1);
            visit[i] = false;
        }
    }
}