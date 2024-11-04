var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = input[0], c = input[1];
var board = new List<string>();
var visit = new bool[26];
int cnt = 1;
int ans = 0;
for(int i = 0; i < r; i++) { board.Add(Console.ReadLine()); }
dfs(0, 0, 1);
Console.WriteLine(ans);
void dfs(int x, int y, int cnt)
{
    visit[board[x][y] - 'A'] = true;
    ans = Math.Max(ans, cnt);
    if (x + 1 < r && !visit[board[x + 1][y] - 'A'])
    {
        visit[board[x + 1][y] - 'A'] = true;
        dfs(x + 1, y, cnt + 1);
        visit[board[x + 1][y] - 'A'] = false;
    }
    if (x - 1 >= 0 && !visit[board[x - 1][y] - 'A'])
    {
        visit[board[x - 1][y] - 'A'] = true;
        dfs(x - 1, y, cnt + 1);
        visit[board[x - 1][y] - 'A'] = false;
    }
    if (y - 1 >= 0 && !visit[board[x][y - 1] - 'A'])
    {
        visit[board[x][y - 1] - 'A'] = true;
        dfs(x, y - 1, cnt + 1);
        visit[board[x][y - 1] - 'A'] = false;
    }
    if (y + 1 < c && !visit[board[x][y + 1] - 'A'])
    {
        visit[board[x][y + 1] - 'A'] = true;
        dfs(x, y + 1, cnt + 1);
        visit[board[x][y + 1] - 'A'] = false;
    }
}
