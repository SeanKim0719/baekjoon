var n = int.Parse(Console.ReadLine());
var queen = new bool[n,n];
var ans = 0;
dfs(0);
Console.WriteLine(ans); 
void dfs(int cnt)
{
    if (cnt == n) { ans++; return; }
    for (int i = 0; i < n; i++)
    {
        int check = 0;
        for (int j = 1; j < cnt+1; j++)
        {
            if (queen[cnt - j, i]) break;
            if (i - j >= 0) { if (queen[cnt - j, i - j]) break; }
            if (i + j < n) { if (queen[cnt - j, i + j]) break; }
            check++;
        }
        if (check == cnt)
        {
            queen[cnt, i] = true;
            dfs(cnt + 1);
            queen[cnt, i] = false;
        }
    }
}